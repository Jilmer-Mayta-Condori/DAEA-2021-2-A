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
            String str = "Server=<DESKTOP-6TPRNVU\\LOCAL>;Database=School;Integrated Security=true";
            con = new SqlConnection(str);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
        }
    }
}
