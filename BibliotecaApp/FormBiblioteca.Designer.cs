namespace BibliotecaApp
{
    partial class FormBiblioteca
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabPrestamos;

        // Usuarios controls
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtContrasenaUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;

        // Libros controls
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;

        // Prestamos controls
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnDevolver;

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabUsuarios = new TabPage();
            dgvUsuarios = new DataGridView();
            txtNombreUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            txtContrasenaUsuario = new TextBox();
            btnAgregarUsuario = new Button();
            btnEliminarUsuario = new Button();
            tabLibros = new TabPage();
            dgvLibros = new DataGridView();
            txtTituloLibro = new TextBox();
            txtAutorLibro = new TextBox();
            btnAgregarLibro = new Button();
            btnEliminarLibro = new Button();
            tabPrestamos = new TabPage();
            dgvPrestamos = new DataGridView();
            cmbUsuarios = new ComboBox();
            cmbLibros = new ComboBox();
            btnPrestar = new Button();
            btnDevolver = new Button();
            tabControl1.SuspendLayout();
            tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabUsuarios);
            tabControl1.Controls.Add(tabLibros);
            tabControl1.Controls.Add(tabPrestamos);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            tabUsuarios.Controls.Add(dgvUsuarios);
            tabUsuarios.Controls.Add(txtNombreUsuario);
            tabUsuarios.Controls.Add(txtEmailUsuario);
            tabUsuarios.Controls.Add(txtContrasenaUsuario);
            tabUsuarios.Controls.Add(btnAgregarUsuario);
            tabUsuarios.Controls.Add(btnEliminarUsuario);
            tabUsuarios.Location = new Point(4, 29);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Size = new Size(592, 287);
            tabUsuarios.TabIndex = 0;
            tabUsuarios.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeight = 29;
            dgvUsuarios.Location = new Point(12, 14);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(560, 200);
            dgvUsuarios.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(12, 220);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre";
            txtNombreUsuario.Size = new Size(180, 27);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Location = new Point(200, 220);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.PlaceholderText = "Email";
            txtEmailUsuario.Size = new Size(180, 27);
            txtEmailUsuario.TabIndex = 2;
            // 
            // txtContrasenaUsuario
            // 
            txtContrasenaUsuario.Location = new Point(392, 220);
            txtContrasenaUsuario.Name = "txtContrasenaUsuario";
            txtContrasenaUsuario.PlaceholderText = "Contraseña";
            txtContrasenaUsuario.Size = new Size(180, 27);
            txtContrasenaUsuario.TabIndex = 3;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(12, 250);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(180, 30);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(200, 250);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(180, 30);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // tabLibros
            // 
            tabLibros.Controls.Add(dgvLibros);
            tabLibros.Controls.Add(txtTituloLibro);
            tabLibros.Controls.Add(txtAutorLibro);
            tabLibros.Controls.Add(btnAgregarLibro);
            tabLibros.Controls.Add(btnEliminarLibro);
            tabLibros.Location = new Point(4, 29);
            tabLibros.Name = "tabLibros";
            tabLibros.Size = new Size(592, 287);
            tabLibros.TabIndex = 1;
            tabLibros.Text = "Libros";
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeight = 29;
            dgvLibros.Location = new Point(12, 14);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(560, 200);
            dgvLibros.TabIndex = 0;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(12, 220);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.PlaceholderText = "Título";
            txtTituloLibro.Size = new Size(263, 27);
            txtTituloLibro.TabIndex = 1;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(309, 220);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.PlaceholderText = "Autor";
            txtAutorLibro.Size = new Size(263, 27);
            txtAutorLibro.TabIndex = 2;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(12, 250);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(263, 30);
            btnAgregarLibro.TabIndex = 3;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(309, 250);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(263, 30);
            btnEliminarLibro.TabIndex = 4;
            btnEliminarLibro.Text = "Eliminar libro";
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // tabPrestamos
            // 
            tabPrestamos.Controls.Add(dgvPrestamos);
            tabPrestamos.Controls.Add(cmbUsuarios);
            tabPrestamos.Controls.Add(cmbLibros);
            tabPrestamos.Controls.Add(btnPrestar);
            tabPrestamos.Controls.Add(btnDevolver);
            tabPrestamos.Location = new Point(4, 29);
            tabPrestamos.Name = "tabPrestamos";
            tabPrestamos.Size = new Size(592, 287);
            tabPrestamos.TabIndex = 2;
            tabPrestamos.Text = "Prestamos";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeight = 29;
            dgvPrestamos.Location = new Point(12, 14);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(560, 200);
            dgvPrestamos.TabIndex = 0;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.Location = new Point(12, 220);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(256, 28);
            cmbUsuarios.TabIndex = 1;
            // 
            // cmbLibros
            // 
            cmbLibros.Location = new Point(316, 220);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(256, 28);
            cmbLibros.TabIndex = 2;
            // 
            // btnPrestar
            // 
            btnPrestar.Location = new Point(12, 249);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(256, 30);
            btnPrestar.TabIndex = 3;
            btnPrestar.Text = "Prestar";
            btnPrestar.Click += btnPrestar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(316, 249);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(256, 30);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Devolver";
            btnDevolver.Click += btnDevolver_Click;
            // 
            // FormBiblioteca
            // 
            ClientSize = new Size(600, 320);
            Controls.Add(tabControl1);
            Name = "FormBiblioteca";
            Text = "Gestión Biblioteca";
            tabControl1.ResumeLayout(false);
            tabUsuarios.ResumeLayout(false);
            tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabLibros.ResumeLayout(false);
            tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabPrestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }
    }
}