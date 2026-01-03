using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class about : System.Web.UI.Page
{
    // create variables
    string strName = "Levi Zelley";
    public string strColor = "#85dce6";
    string strHobby = "Writing";
    string strAspiration = "Full-Stack Web Developer & Designer";
    string strWebsite = "<a href='https://randomcolour.com/'>https://randomcolour.com/</a>";

    // create method to display variables
    protected void DisplayData(string variable)
    {
        switch(variable)
        {
            case "N":
                Response.Write("<i>" + strName + "</i>");
                break;
            case "H":
                Response.Write("<i>" + strHobby + "</i>");
                break;
            case "A":
                Response.Write("<i>" + strAspiration + "</i>");
                break;
            case "W":
                Response.Write("<i>" + strWebsite + "</i>");
                break;
        }
    }
}