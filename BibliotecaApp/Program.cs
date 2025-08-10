using System;
using System.Windows.Forms;
namespace BibliotecaApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cargar/crear biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Si no hay usuarios, crear admin por defecto
            if (biblioteca.Usuarios.Count == 0)
            {
                biblioteca.Usuarios.Add(new Usuario { Id = 1, Nombre = "Administrador", Email = "admin@local", Contrasena = "admin" });
                biblioteca.GuardarDatos();
            }

            Application.Run(new FormLogin(biblioteca));
        }
    }
}