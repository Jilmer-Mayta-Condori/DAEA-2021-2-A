using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson NegPerson = new clsNegPerson();
            dt = NegPerson.getAll();

            dgvDatos.DataSource = dt;
            dgvDatos.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();

            dt = np.searchPersonName(txtName.Text);

            dgvDatos.DataSource = dt;
            dgvDatos.Refresh();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson NegPerson = new clsNegPerson();
            dt = NegPerson.getAll();

            txtName.Text = "";

            dgvDatos.DataSource = dt;
            dgvDatos.Refresh();

        }
    }
}
