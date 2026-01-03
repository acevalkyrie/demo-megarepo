using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class colors : System.Web.UI.Page
{
    public string strColor = "white";

    protected void btnPink_Click(object sender, EventArgs e)
    {
        ClearColors();
        btnPink.BackColor = System.Drawing.Color.Pink;
        btnPink.ForeColor = System.Drawing.Color.HotPink;
    }

    protected void btnRed_Click(object sender, EventArgs e)
    {
        ClearColors();
        btnRed.BackColor = System.Drawing.Color.Red;
        btnRed.ForeColor = System.Drawing.Color.LightSalmon;
    }

    protected void btnBlue_Click(object sender, EventArgs e)
    {
        ClearColors();
        btnBlue.BackColor = System.Drawing.Color.Blue;
        btnBlue.ForeColor = System.Drawing.Color.SkyBlue;
    }

    protected void btnYellow_Click(object sender, EventArgs e)
    {
        ClearColors();
        btnYellow.BackColor = System.Drawing.Color.Yellow;
        btnYellow.ForeColor = System.Drawing.Color.DarkGoldenrod;
    }

    private void ClearColors()
    {
        btnPink.BackColor = default(System.Drawing.Color);
        btnPink.ForeColor = default(System.Drawing.Color);
        btnRed.BackColor = default(System.Drawing.Color);
        btnRed.ForeColor = default(System.Drawing.Color);
        btnBlue.BackColor = default(System.Drawing.Color);
        btnBlue.ForeColor = default(System.Drawing.Color);
        btnYellow.BackColor = default(System.Drawing.Color);
        btnYellow.ForeColor = default(System.Drawing.Color);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        strColor = txtColor.Text;
    }
}