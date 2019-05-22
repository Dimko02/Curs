using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CProj
{
    class TableGoods : Table
    {
        DataGridView dataGridView;

        public TableGoods(int id,DataGridView dataGridView)
            :base(id)
        {
            this.dataGridView = dataGridView;
        }

        public override SqlDataAdapter ShowTable()
        {
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Goods", connectionString);
            sqlAdapterName.Fill(Dst, "Goods");
            this.dataGridView.DataSource = Dst.Tables["Goods"];
            return sqlAdapterName;
        }

        public override void UpdateTable(SqlDataAdapter sqlAdapterName)
        {
            new SqlCommandBuilder(sqlAdapterName);
            sqlAdapterName.Update(Dst, "Goods");
        }

        public override void SearchTable(SqlDataAdapter adapterName,TextBox textBoxName,string selectedColBox, string selectedOpBox)
        {
            adapterName = new SqlDataAdapter(@"SELECT * FROM Goods Where " + selectedColBox + selectedOpBox + "\'" + textBoxName.Text + "\'", connectionString);
            adapterName.Fill(Dst, "Goods");
            this.dataGridView.DataSource = Dst.Tables["Goods"];
        }

        public override void RemoveTable(TextBox textBox)
        {
            Table.Dst.Clear();
            SqlDataAdapter sqlAdapterName = new SqlDataAdapter("SELECT * FROM Goods", connectionString);
            sqlAdapterName.Fill(Table.Dst, "Goods");
            dataGridView.DataSource = Table.Dst.Tables["Goods"];
            dataGridView.Rows.RemoveAt(Convert.ToInt32(textBox.Text) - 1);
        }
    }
}
