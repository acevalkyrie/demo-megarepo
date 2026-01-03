using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZelley_Final_Project
{
    static class clsGlobal
    {
        /// <summary>
        /// Create strings used for connecting to database and setting consistent coloring across the various forms.
        /// </summary>
        static public string DataConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Prompts.accdb;Persist Security Info=False;";

        static public string TitleColors = "MidnightBlue";
        static public string HeaderColors = "Teal";
        static public string ForegroundColor = "Navy";
        static public string BackgroundColor = "Cornsilk";
    }
}
