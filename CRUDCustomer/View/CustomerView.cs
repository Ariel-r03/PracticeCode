using CRUDCustomer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCustomer.View
{
    public partial class CustomerView : Form
    {
        CustomerController customerController = new CustomerController();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Refresh();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthWindDB northWindDB = new NorthWindDB();
            if (northWindDB.Ok())
            {
                MessageBox.Show("Nos hemos conectado a " + northWindDB.getConnection());
            }
            else
            {
                MessageBox.Show("No nos hemos conectado");
            }

        }

        private void Refresh()
        {

            dataGridView1.DataSource = customerController.Customers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.ShowDialog();
            Refresh();
        }

        private string findID()
        {
            return dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["CustomerID"].Value.ToString();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string id = findID();
            customerController.Delete(id);
            Refresh();
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer= new FrmNewCustomer(findID());
            frmNewCustomer.ShowDialog();
            Refresh();
        }
    }
}
