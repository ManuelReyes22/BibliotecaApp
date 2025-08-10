namespace BibliotecaApp
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnSalir;

        private void InitializeComponent()
        {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(30, 30);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(30, 80);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(200, 40);
            this.btnLibros.Text = "Libros";
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(30, 130);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(200, 40);
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(30, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(264, 251);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormPrincipal";
            this.Text = "Sistema Biblioteca";
            this.ResumeLayout(false);
        }
    }
}