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

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        SqlConnection conn; 
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection("Server=DESKTOP-6TPRNVU\\LOCAL;DataBase=db_lab03;Integrated Security=true");
                conn.Open();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "select * from tbl_usuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                String user = txtUsuario.Text;
                String password = txtPassword.Text;

                Boolean usuario = false;
                Boolean contra = false;

                while (reader.Read())
                {
                    if (user.Equals(reader["usuario_nombre"].ToString()))
                    {
                        usuario = true;
                        if (password.Equals(reader["usuario_password"].ToString()))
                        {
                            contra = true;
                        }
                    }
                }
                reader.Close();

                if (usuario == true && contra == true)
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else if (usuario.Equals(false))
                {
                    MessageBox.Show("Error en el usuario");
                }
                else if (contra.Equals(false))
                {
                    MessageBox.Show("Error en la contraseña");
                }
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar conexion = new Conectar();
            conexion.Show();
        }
    }
}
