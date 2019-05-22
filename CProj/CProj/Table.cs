using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CProj
{
    abstract class Table
    {
        public int Id{ get; set; }
        static DataSet dst = new DataSet();

         protected string connectionString = @"Data Source=DESKTOP-ELCV2UO\MSSQLSERVER1;" +
                                             "Integrated Security=SSPI;" +
                                             "Initial Catalog=curs";
        public static DataSet Dst
        {
            get { return dst; }
            set { dst = value; }
        }

        protected Table(int id)
        {
            Id = id;
        }
        public virtual SqlDataAdapter ShowTable()
        {
            return new SqlDataAdapter();
        }

        public virtual void UpdateTable(SqlDataAdapter sqlAdapterName)
        {

        }

        public virtual void SearchTable(SqlDataAdapter adapterName, TextBox textBoxName, string selectedColBox, string selectedOpBox)
        {
            
        }

        public virtual void RemoveTable(TextBox textBox)
        {
            
        }
    }
}
