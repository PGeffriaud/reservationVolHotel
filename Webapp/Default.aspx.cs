using System;
using System.Data;

namespace Webapp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Bienvenue " + txtFirstName.Text + " " + txtName.Text;
        }
    }
}