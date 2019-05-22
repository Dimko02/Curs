using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProj
{
    public partial class MainForm : Form
    {
         
        public void FillColumnComboBox(ComboBox comboBoxName, string nameTable)
        {
            comboBoxName.Items.Clear();
            for (int i = 0; i < Table.Dst.Tables[nameTable].Columns.Count; i++)
            {
                comboBoxName.Items.Add(Table.Dst.Tables[nameTable].Columns[i].ToString());
            }
        }

        public void FillOperationComboBox(ComboBox comboBoxName)
        {
            comboBoxName.Items.AddRange(new string[] { ">", "<", "=" });
        }

        SqlDataAdapter adapterGoods;
        SqlDataAdapter adapterSuppliers;
        SqlDataAdapter adapterClients;
        SqlDataAdapter adapterOrders;

        TableGoods tableGoods;
        TableSuppliers tableSuppliers;
        TableClients tableClients;

        string selectedOpBox;
        string selectedColBox; 

        public string connectionString = @"Data Source=DESKTOP-ELCV2UO\MSSQLSERVER1;" +
                                             "Integrated Security=SSPI;" +
                                             "Initial Catalog=curs";
        public MainForm()
        {
            InitializeComponent();

            tableGoods = new TableGoods(1, goodsTable);
            tableSuppliers = new TableSuppliers(1, suppliersTable);
            tableClients = new TableClients(1, clientsTable);

            adapterGoods = tableGoods.ShowTable();

            tabPage1.Text = "Goods";
            tabPage2.Text = "Suppliers";
            tabPage3.Text = "Clients";
            tabPage4.Text = "Orders";

            FillColumnComboBox(columnBox, "Goods");
            FillOperationComboBox(operationBox);
            FillOperationComboBox(comboBox2);
            FillOperationComboBox(operationBoxClients);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:

                    Table.Dst.Clear();
                    adapterGoods = tableGoods.ShowTable();
                    break;

                case 1:

                    Table.Dst.Clear();
                    adapterGoods = tableSuppliers.ShowTable();
                    FillColumnComboBox(comboBox1, "Suppliers");
                    break;

                case 2:

                    Table.Dst.Clear();
                    adapterSuppliers = tableClients.ShowTable();
                    FillColumnComboBox(columnBoxClients, "Clients");
                    break;

                case 3:

                    Table.Dst.Clear();
                    adapterOrders = new SqlDataAdapter("SELECT Orders.CodeOrders, Clients.Title AS TitleClient, Goods.Mark,Goods.Price, Suppliers.Title AS TitleSupplier"+
                                                       " FROM Clients INNER JOIN"+
                                                       " Orders ON Clients.CodeClient = Orders.CodeClient INNER JOIN"+
                                                       " Goods ON Orders.CodeGoods = Goods.CodeGoods INNER JOIN"+
                                                       " dbo.Suppliers ON Orders.CodeSuppliers = Suppliers.CodeSuppliers", connectionString);
                    adapterOrders.Fill(Table.Dst, "Orders");
                    ordersTable.DataSource = Table.Dst.Tables["Orders"];
                    break;
            }
        }

        //TableGoods
        private void ConfirmGoods_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tableGoods.UpdateTable(adapterGoods);
            }
            else MessageBox.Show("You should tick");
        }

        private void RefreshGoods_Click(object sender, EventArgs e)
        {
            Table.Dst.Clear();
            adapterGoods = tableGoods.ShowTable();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColBox = columnBox.SelectedItem.ToString();
        }
        private void OperationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOpBox = operationBox.SelectedItem.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Table.Dst.Clear();
                tableGoods.SearchTable(adapterGoods, textBox1, selectedColBox, selectedOpBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                tableGoods.RemoveTable(textRemGoods);
            }
            catch
            {
                MessageBox.Show("Wrong CodeGoods!!!");
            }
        }

        //TableSuppliers
        private void ConfirmSuppliers_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tableSuppliers.UpdateTable(adapterSuppliers);
            }
            else MessageBox.Show("You should tick");
        }

        private void RefreshSuppliers_Click(object sender, EventArgs e)
        {
            Table.Dst.Clear();
            adapterSuppliers = tableSuppliers.ShowTable();
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedColBox = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOpBox = comboBox2.SelectedItem.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Table.Dst.Clear();
                tableSuppliers.SearchTable(adapterSuppliers, textBox2, selectedColBox, selectedOpBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRemSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                tableSuppliers.RemoveTable(textRemSuppliers);
            }
            catch
            {
                MessageBox.Show("Wrong CodeSuppliers!!!");
            }
        }

        //TableClients
        private void ConfirmClients_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                tableClients.UpdateTable(adapterClients);
            }
            else MessageBox.Show("You should tick");
        }

        private void RefreshClients_Click(object sender, EventArgs e)
        {
            Table.Dst.Clear();
            adapterClients = tableClients.ShowTable();
        }      

        private void ColumnBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColBox = columnBoxClients.SelectedItem.ToString();
        }

        private void OperationBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOpBox = operationBoxClients.SelectedItem.ToString();
        }

        private void SearchClients_Click(object sender, EventArgs e)
        {
            try
            {
                Table.Dst.Clear();
                tableClients.SearchTable(adapterClients, textBox3, selectedColBox, selectedOpBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRemClients_Click(object sender, EventArgs e)
        {
            try
            {
                tableClients.RemoveTable(textRemClients);
            }
            catch
            {
                MessageBox.Show("Wrong CodeClients!!!");
            }
        }
    }
}
