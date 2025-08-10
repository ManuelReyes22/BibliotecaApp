namespace BibliotecaApp
{
    using System;
    using System.Windows.Forms;

    public partial class FormLogin : Form
    {
        private Biblioteca biblioteca;

        public FormLogin(Biblioteca biblio)
        {
            InitializeComponent();
            biblioteca = biblio;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (biblioteca.ValidarUsuario(txtUsuario.Text.Trim(), txtContrasena.Text.Trim()))
            {
                FormPrincipal frm = new FormPrincipal(biblioteca);
                frm.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
