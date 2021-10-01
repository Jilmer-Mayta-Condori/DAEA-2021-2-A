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

namespace Lab05
{
    public partial class Form1 : Form
    {

        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-6TPRNVU\\LOCAL;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha eliminado el registro correctamente ");
            }
            con.Close();
        }   

        private void btnListar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            con.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", Convert.ToDateTime(txtHireDate.Text));
            cmd.Parameters.AddWithValue("@EnrollmentDate", Convert.ToDateTime(txtEnrollmentDate.Text));

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado una nueva persona con el codigo " + codigo);
            con.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Text);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente ");
            }
            con.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            String FirstName = txtFirstName.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BuscarPersonaNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@FirstName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = FirstName;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListado.DataSource = dt;
            dgvListado.Refresh();

            con.Close();
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
            
        }
    }
}
