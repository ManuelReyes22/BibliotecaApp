using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormBiblioteca : Form
    {
        public Biblioteca biblioteca;
        public string initialTab = "Usuarios";

        public FormBiblioteca(Biblioteca biblio)
        {
            InitializeComponent();
            biblioteca = biblio;
            RefrescarTodo();
        }

        public void SelectTab(string name)
        {
            initialTab = name;
            switch (name)
            {
                case "Libros": tabControl1.SelectedTab = tabLibros; break;
                case "Prestamos": tabControl1.SelectedTab = tabPrestamos; break;
                default: tabControl1.SelectedTab = tabUsuarios; break;
            }
        }

        private void RefrescarTodo()
        {
            // Usuarios
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = biblioteca.Usuarios.Select(u => new { u.Id, u.Nombre, u.Email }).ToList();

            // Libros
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = biblioteca.Libros.Select(l => new { l.Id, l.Titulo, l.Autor, Disponible = l.Disponible ? "Sí" : "No" }).ToList();

            // Prestamos
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = biblioteca.Prestamos.Select(p => new
            {
                p.Id,
                Usuario = biblioteca.Usuarios.FirstOrDefault(u => u.Id == p.IdUsuario)?.Nombre ?? "-",
                Libro = biblioteca.Libros.FirstOrDefault(l => l.Id == p.IdLibro)?.Titulo ?? "-",
                p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion?.ToString() ?? ""
            }).ToList();

            // Comboboxes
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.DataSource = biblioteca.Usuarios.ToList();

            cmbLibros.DataSource = null;
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "Id";
            cmbLibros.DataSource = biblioteca.Libros.Where(x => x.Disponible).ToList();
        }

        // --- Usuarios: agregar
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text.Trim();
            string email = txtEmailUsuario.Text.Trim();
            string contrasena = txtContrasenaUsuario.Text.Trim();
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Rellena todos los campos de usuario.");
                return;
            }
            if (biblioteca.Usuarios.Any(u => u.Email == email))
            {
                MessageBox.Show("Ya existe un usuario con ese email.");
                return;
            }
            biblioteca.Usuarios.Add(new Usuario { Id = biblioteca.ProximoIdUsuario(), Nombre = nombre, Email = email, Contrasena = contrasena });
            biblioteca.GuardarDatos();
            RefrescarTodo();
            txtNombreUsuario.Clear(); txtEmailUsuario.Clear(); txtContrasenaUsuario.Clear();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            int id = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
            var usu = biblioteca.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usu != null)
            {
                if (MessageBox.Show($"Eliminar usuario {usu.Nombre}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    biblioteca.Usuarios.Remove(usu);
                    biblioteca.GuardarDatos();
                    RefrescarTodo();
                }
            }
        }

        // --- Libros: agregar
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloLibro.Text.Trim();
            string autor = txtAutorLibro.Text.Trim();
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Rellena todos los campos de libro.");
                return;
            }
            biblioteca.Libros.Add(new Libro { Id = biblioteca.ProximoIdLibro(), Titulo = titulo, Autor = autor, Disponible = true });
            biblioteca.GuardarDatos();
            RefrescarTodo();
            txtTituloLibro.Clear(); txtAutorLibro.Clear();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null) return;
            int id = (int)dgvLibros.CurrentRow.Cells[0].Value;
            var libro = biblioteca.Libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                if (MessageBox.Show($"Eliminar libro {libro.Titulo}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    biblioteca.Libros.Remove(libro);
                    biblioteca.GuardarDatos();
                    RefrescarTodo();
                }
            }
        }

        // --- Prestamos: prestar
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null || cmbLibros.SelectedItem == null)
            {
                MessageBox.Show("Selecciona usuario y libro.");
                return;
            }
            var usuario = (Usuario)cmbUsuarios.SelectedItem;
            var libro = (Libro)cmbLibros.SelectedItem;
            if (!libro.Disponible) { MessageBox.Show("El libro no está disponible."); return; }

            Prestamo p = new Prestamo
            {
                Id = biblioteca.ProximoIdPrestamo(),
                IdUsuario = usuario.Id,
                IdLibro = libro.Id,
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = null
            };
            biblioteca.Prestamos.Add(p);
            // marcar libro no disponible
            var lib = biblioteca.Libros.FirstOrDefault(x => x.Id == libro.Id);
            if (lib != null) lib.Disponible = false;

            biblioteca.GuardarDatos();
            RefrescarTodo();
        }

        // --- Prestamos: devolver
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null) { MessageBox.Show("Selecciona un préstamo."); return; }
            int idPrest = (int)dgvPrestamos.CurrentRow.Cells[0].Value;
            var prest = biblioteca.Prestamos.FirstOrDefault(p => p.Id == idPrest);
            if (prest == null) return;
            if (prest.FechaDevolucion != null) { MessageBox.Show("Ya fue devuelto."); return; }

            prest.FechaDevolucion = DateTime.Now;
            var lib = biblioteca.Libros.FirstOrDefault(l => l.Id == prest.IdLibro);
            if (lib != null) lib.Disponible = true;

            biblioteca.GuardarDatos();
            RefrescarTodo();
        }
    }
}
