using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using LZelley_Final_Project;
using System.Windows.Forms;

namespace LZelley_Final_Project
{
    class clsData
    {

        string _strConnectionString = clsGlobal.DataConnectionString; // variable to link to connectionstring property
        string _strSQL = ""; // variable to link to SQL property
        DataTable dtData; // data table for data from database

        /// <summary>
        /// string to contain connection string to database
        /// </summary>
        public string ConnectionString
        {
            get { return _strConnectionString; }
            set {
                _strConnectionString = value;
                FillDataTable();
            }
        }

        /// <summary>
        /// store query to database
        /// </summary>
        public string SQL
        {
            get { return _strSQL; }
            set {
                _strSQL = value;
                FillDataTable(); // fill the data table
            }
        }

        /// <summary>
        /// data table accessible from application
        /// </summary>
        public DataTable dt
        {
            get { return dtData; }
            set { dtData = value; }
        }

        /// <summary>
        /// fill datatable with data from database based on properties of SQL and connection string
        /// </summary>
        private void FillDataTable()
        {
            // if connection string and sql are filled, continue
            if (ConnectionString != "" && SQL != "")
            {
                // create connection to database
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                // open connection
                conn.Open();
                // create dataset
                DataSet ds = new DataSet();
                // fill dataset with data adapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, ConnectionString);
                adapter.Fill(ds);
                // close connection to database
                conn.Close();
                // fill data table with data set
                dtData = ds.Tables[0];
            }
        }

        /// <summary>
        /// Add new data row to table from user inputs corresponding to database's fields.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Content"></param>
        /// <param name="Complexity"></param>
        /// <param name="Emotion"></param>
        public void CreatePrompt(string Type, string Content, bool Complexity, string Emotion)
        {
            // create SQL statement
            SQL = "SELECT ID, type, content, complexity, emotion FROM tblPrompts WHERE ID = 0";
            // create connection to database
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            // open connection
            conn.Open();
            // create dataset
            DataSet ds = new DataSet();
            // fill dataset with data adapter
            OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, ConnectionString);
            adapter.Fill(ds);
            // create data row
            DataRow dr = ds.Tables[0].NewRow();
            //update values in data row
            dr["type"] = Type;
            dr["content"] = Content;
            dr["complexity"] = Complexity;
            dr["emotion"] = Emotion;

            // add data row to table
            ds.Tables[0].Rows.Add(dr);
            // create command builder
            System.Data.OleDb.OleDbCommandBuilder cb = new System.Data.OleDb.OleDbCommandBuilder(adapter);
            // update adapter
            adapter.Update(ds.Tables[0]);
            // close connection to database
            conn.Close();
        }
    }
}
