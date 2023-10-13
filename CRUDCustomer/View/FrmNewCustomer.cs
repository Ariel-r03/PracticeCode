using CRUDCustomer.Controller;
using CRUDCustomer.Model;
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
    public partial class FrmNewCustomer : Form
    {

        private string? id;
        CustomerController customerController = new CustomerController();
        Customer customer = new Customer();
        public FrmNewCustomer(string? id = null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (customer.CustomerID == null)
            {
                customer.CustomerID = txtIdCustomer.Text;
                customer.CompanyName = txtCompanyName.Text;
                customer.ContactName = txtContactName.Text;
                customer.ContactTitle = TxtContactTitle.Text;
                customer.Address = TxtAddress.Text;
                customer.City = TxtCity.Text;
                customer.Region = TxtRegion.Text;
                customer.PostalCode = TxtPostalCode.Text;
                customer.Country = TxtCountry.Text;
                customer.Phone = TxtPhone.Text;
                customer.Fax = txtFax.Text;
                customerController.Add(customer);
            }
            else
            {
                customer.CustomerID = txtIdCustomer.Text;
                customer.CompanyName = txtCompanyName.Text;
                customer.ContactName = txtContactName.Text;
                customer.ContactTitle = TxtContactTitle.Text;
                customer.Address = TxtAddress.Text;
                customer.City = TxtCity.Text;
                customer.Region = TxtRegion.Text;
                customer.PostalCode = TxtPostalCode.Text;
                customer.Country = TxtCountry.Text;
                customer.Phone = TxtPhone.Text;
                customer.Fax = txtFax.Text;
                customerController.Update(customer);
            }
                /*customer.AddCustomer(txtIdCustomer.Text, txtCompanyName.Text, txtContactName.Text, TxtContactTitle.Text,
                TxtAddress.Text, TxtCity.Text, TxtRegion.Text, TxtPostalCode.Text, TxtCountry.Text, TxtPhone.Text,txtFax.Text);*/
                   
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                MessageBox.Show("toy");
                customer = customerController.GetCustomer(id);
                txtIdCustomer.Text = customer.CustomerID;
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                TxtContactTitle.Text = customer.ContactTitle;
                TxtAddress.Text = customer.Address;
                TxtCity.Text = customer.City;
                TxtRegion.Text = customer.Region;
                TxtPostalCode.Text = customer.PostalCode;
                TxtCountry.Text = customer.Country;
                TxtPhone.Text = customer.Phone;
                txtFax.Text = customer.Fax;
            }
        }
    }
}
