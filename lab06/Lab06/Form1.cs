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

namespace Lab06
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-6TPRNVU\\LOCAL;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
            txtPersonID.Enabled = false;
            btnSearchContrato.Enabled = false;
            btnSearchFacturacion.Enabled = false;
            btnSearchLastname.Enabled = false;
            btnSearchNombre.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(ds, "Person");

            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", con);

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["FirstName"] = txtFirstName.Text;
            fila["LastName"] = txtLastName.Text;
            if (txtHireDate.Checked == false)
            {
            }
            else
            {
                fila["HireDate"] = txtHireDate.Text;
            }
            if (txtEnrollmentDate.Checked == false)
            {
            }
            else
            {
                fila["EnrollmentDate"] = txtEnrollmentDate.Text;
            }
            

            tablePerson.Rows.Add(fila);

            adapter.Update(tablePerson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '"+ txtPersonID.Text + "'");
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonId = '" + txtPersonID.Text + "'");

            tablePerson.Rows.Remove(fila[0]);

            adapter.Update(tablePerson);
        }

        private void btnOrdenApellido_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName ASC";
            dgvListado.DataSource = dv;
        }

        private void btnBuscarXCodigo_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "PersonID = '"+ txtPersonID.Text +"'";
            dgvListado.DataSource = dv;
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                string hiredate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hiredate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hiredate;

                string EnrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(EnrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = EnrollmentDate;
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchNombre_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "FirstName = '" + txtSearchName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnSearchLastname_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "LastName = '" + txtSearchLastName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnSearchContrato_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "HireDate = '" + dtpSearchDateContrato.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnSearchFacturacion_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "EnrollmentDate = '" + dtpSearchDateInscripcion.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            btnSearchContrato.Enabled = false;
            btnSearchFacturacion.Enabled = false;
            btnSearchLastname.Enabled = false;
            btnSearchNombre.Enabled = true;
        }

        private void txtSearchLastName_TextChanged(object sender, EventArgs e)
        {
            btnSearchLastname.Enabled = true;
            btnSearchContrato.Enabled = false;
            btnSearchFacturacion.Enabled = false;
            btnSearchNombre.Enabled = false;
        }

        private void dtpSearchDateContrato_ValueChanged(object sender, EventArgs e)
        {
            btnSearchContrato.Enabled = true;
            btnSearchNombre.Enabled = false;
            btnSearchFacturacion.Enabled = false;
            btnSearchLastname.Enabled = false;
        }

        private void dtpSearchDateInscripcion_ValueChanged(object sender, EventArgs e)
        {
            btnSearchFacturacion.Enabled = true;
            btnSearchContrato.Enabled = false;
            btnSearchNombre.Enabled = false;
            btnSearchLastname.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "FirstName = '" + txtSearchName.Text + "'";
            dgvListado.DataSource = dv;
        }
    }
}
