﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_DAW
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx?q=" + Server.UrlEncode(TBSearch.Text));
        }

    }
}