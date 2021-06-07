using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06_EntityCVProject
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTITYEntities ctx = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Repeater1.DataSource = ctx.tblHakkimizda.ToList();
            //Repeater1.DataBind();

            //Repeater2.DataSource = ctx.tblHakkimizda.ToList();
            //Repeater2.DataBind();
        }
    }
}