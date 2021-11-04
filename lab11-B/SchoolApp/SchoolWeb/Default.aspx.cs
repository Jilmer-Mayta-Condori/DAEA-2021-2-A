using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolBLL;
using SchoolEntities;

namespace SchoolWeb
{
    public partial class _Default : Page
    {
        CPersonBLL personBL = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = personBL.ListarBLL();
            gvListado.DataBind();
        }
    }
}