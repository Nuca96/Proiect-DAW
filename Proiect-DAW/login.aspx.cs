using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Proiect_DAW
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            if (!Roles.RoleExists("User"))
            {
                Roles.CreateRole("User");
            }
            Roles.AddUserToRole(CreateUserWizard1.UserName, "User");
        }
    }
}