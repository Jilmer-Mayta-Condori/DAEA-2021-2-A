using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace Presentacion_Web
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson NegPerson = new clsNegPerson();
            dt = NegPerson.getAll();

            dgDatos.DataSource = dt;
            dgDatos.DataBind();
        }
    }
}