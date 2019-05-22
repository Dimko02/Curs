using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CProj
{
    class TableSuppliers: Table
    {
        DataGridView dataGridView;

        public TableSuppliers(int id, DataGridView dataGridView)
            : base(id)
        {
            this.dataGridView = dataGridView;
        }

        public override SqlDataAdapter ShowTable()
        {
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Suppliers", connectionString);
            sqlAdapterName.Fill( Dst,"Suppliers");
            this.dataGridView.DataSource = Dst.Tables["Suppliers"];
            return sqlAdapterName;
        }

        public override void UpdateTable(SqlDataAdapter sqlAdapterName)
        {
            new SqlCommandBuilder(sqlAdapterName);
            sqlAdapterName.Update(Dst, "Suppliers");
        }

        public override void SearchTable(SqlDataAdapter adapterName, TextBox textBoxName, string selectedColBox, string selectedOpBox)
        {
            adapterName = new SqlDataAdapter(@"SELECT * FROM Suppliers Where " + selectedColBox + selectedOpBox + "\'" + textBoxName.Text + "\'", connectionString);
            adapterName.Fill(Dst, "Suppliers");
            this.dataGridView.DataSource = Dst.Tables["Suppliers"];
        }

        public override void RemoveTable(TextBox textBox)
        {
            Table.Dst.Clear();
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Suppliers", connectionString);
            sqlAdapterName.Fill(Table.Dst, "Suppliers");
            dataGridView.DataSource = Table.Dst.Tables["Suppliers"];
            dataGridView.Rows.RemoveAt(Convert.ToInt32(textBox.Text) - 1);
        }
    }
}
