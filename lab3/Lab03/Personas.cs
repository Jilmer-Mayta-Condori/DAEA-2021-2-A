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
    public partial class Personas : Form
    {
        SqlConnection conn;

        public Personas(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                String sql = "select * from tbl_usuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();

            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }
}
