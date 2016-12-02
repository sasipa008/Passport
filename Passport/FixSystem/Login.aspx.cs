using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            th.ac.psu.passport.Authentication authen = new th.ac.psu.passport.Authentication();
            string[] result = authen.GetUserDetails(txtID.Text,txtPassword.Text);
            foreach (string s in result)
            {
                string a = s;
                Label3.Text = "Login Complete";
                Response.Redirect("FixTests/Create"); //ลิ้งไปยังหน้าอื่น
                //or
               /* Server.Transfer("Create.cshtml");*/
            }
        }
    }
}