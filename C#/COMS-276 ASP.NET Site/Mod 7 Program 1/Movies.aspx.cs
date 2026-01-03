using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Security.Policy;

public partial class Movies : System.Web.UI.Page
{

    protected void gvMovies_SelectedIndexChanged(object sender, EventArgs e)
    {
        // get values from screen based on selected row
        string strName = gvMovies.SelectedRow.Cells[2].Text;
        // display to screen with an alert
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Movie Title: " + strName + "')", true);
    }
}