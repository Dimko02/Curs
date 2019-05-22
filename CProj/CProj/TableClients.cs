using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CProj
{
    class TableClients : Table
    {
        DataGridView dataGridView;

        public TableClients(int id, DataGridView dataGridView)
            : base(id)
        {
            this.dataGridView = dataGridView;
        }

        public override SqlDataAdapter ShowTable()
        {
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Clients", connectionString);
            sqlAdapterName.Fill(Dst, "Clients");
            this.dataGridView.DataSource = Dst.Tables["Clients"];
            return sqlAdapterName;
        }

        public override void UpdateTable(SqlDataAdapter sqlAdapterName)
        {
            new SqlCommandBuilder(sqlAdapterName);
            sqlAdapterName.Update(Dst, "Clients");
        }

        public override void SearchTable(SqlDataAdapter adapterName, TextBox textBoxName, string selectedColBox, string selectedOpBox)
        {
            adapterName = new SqlDataAdapter(@"SELECT * FROM Clients Where " + selectedColBox + selectedOpBox + "\'" + textBoxName.Text + "\'", connectionString);
            adapterName.Fill(Dst, "Clients");
            this.dataGridView.DataSource = Dst.Tables["Clients"];
        }

        public override void RemoveTable(TextBox textBox)
        {
            Table.Dst.Clear();
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Clients", connectionString);
            sqlAdapterName.Fill(Table.Dst, "Clients");
            dataGridView.DataSource = Table.Dst.Tables["Clients"];
            dataGridView.Rows.RemoveAt(Convert.ToInt32(textBox.Text) - 1);
        }
    }
}
