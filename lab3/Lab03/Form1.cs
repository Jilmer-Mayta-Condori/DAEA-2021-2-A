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

namespace Lab03
{
    public partial class Form1 : Form
    {
        //SqlConnection nos permite manejar el acceso al servidor
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declaramos las variables para alamcenar los valores de los TextBox
            // y definimos una cadena de conexion
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtContraseña.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            //La cadena de conexion cambia en funcion del checkbox
            if (chkAutenticacion.Checked)
            {
                str += "Integrated Security=true";
            }
            else
            {
                str += "User Id=" + user + ";Password=" + pwd + ";";
            }

            //Abir una conexion xon el servidor, usando la cadena de conexión
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\nVersion del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                }
                else
                {
                    MessageBox.Show("Estado del servidor: " + conn.State);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n " + ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if( conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                    btnDesconectar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La conexion ya esta cerrada");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al cerrar la conexion: " + ex.ToString());
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas(conn);
            persona.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos(conn);
            curso.Show();
        }
    }
}
