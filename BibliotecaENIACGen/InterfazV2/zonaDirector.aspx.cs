﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazV2
{
    public partial class zonaDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void altaPas(object sender, EventArgs e)
        {
            Response.Redirect("altaPAS.aspx");
        }
        protected void bajaPas(object sender, EventArgs e)
        {
            Response.Redirect("bajaPAS.aspx");
        }
        protected void nuevoDirector(object sender, EventArgs e)
        {
            Response.Redirect("NuevoDirector.aspx");
        }
        protected void checkPrestamos(object sender, EventArgs e)
        {
            Response.Redirect("prestamosChequear.aspx");
        }
    }
}