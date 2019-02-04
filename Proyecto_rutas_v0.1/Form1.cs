using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proyecto_rutas_v0._1
{
    public partial class Login_1 : Form
    {
        public Login_1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu_rutas = new MenuPrincipal();
            
            menu_rutas.Show();
            this.Hide();

            
            /*
            Usuarios UsuarioOB = new Usuarios();
            UsuarioOB.Usuario = this.textBox1.Text;
            UsuarioOB.Contraseña = this.textBox2.Text;

            if(UsuarioOB.Buscar() == true)
            {
                MessageBox.Show(UsuarioOB.Mensaje, "Login");
            }
            else
            {
                MessageBox.Show(UsuarioOB.Mensaje, "ERROR");
            }
            */
        }
    }
}
