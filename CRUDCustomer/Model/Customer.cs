using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCustomer.Model
{
    class Customer
    {
        public string? CustomerID { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get;set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; } 
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }


        public Customer(string CustomerID, string CompanyName, string ContactName, string ContactTitle, string Address,
         string City,string Region, string PostalCode,string Country,string Phone,string Fax)
        {
            this.CustomerID = CustomerID;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.ContactTitle = ContactTitle;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Phone = Phone;
            this.Fax = Fax;
        }

        public Customer()
        {

        }

        public List<Customer> getCustomer()
        {
            NorthWindDB northWindDB = new NorthWindDB();
            string connectionString = northWindDB.getConnection();
            List<Customer> customers = new List<Customer>();
            string query = "select * from Customers where IsDeleted=0";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
              
                SqlCommand cmd = new SqlCommand(query, cn);

                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = reader.IsDBNull(0)? null: reader.GetString(0);
                        customer.CompanyName = reader.IsDBNull(1) ? null : reader.GetString(1);
                        customer.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                        customer.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                        customer.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                        customer.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                        customer.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                        customer.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                        customer.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                        customer.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                        customer.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                        customers.Add(customer);
                    }
                    reader.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    
                    MessageBox.Show(ex.ToString());
                }
       
            }
            return customers;
        }

        public Customer getOneCustomer(string id)
        {
            NorthWindDB northWindDB = new NorthWindDB();
            string connectionString = northWindDB.getConnection();
            string query = "select * from Customers where IsDeleted=0 AND CustomerID=@id";

            using(SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd= new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                Customer customer = new Customer();

                try
                {
                    cn.Open();
                    SqlDataReader reader= cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customer.CustomerID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        customer.CompanyName = reader.IsDBNull(1) ? null : reader.GetString(1);
                        customer.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                        customer.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                        customer.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                        customer.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                        customer.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                        customer.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                        customer.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                        customer.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                        customer.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    }
                    reader.Close();
                    cn.Close();
                    return customer;
                } catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }

            }
        }

        public void AddCustomer(Customer c)
        {
            NorthWindDB northWindDB = new NorthWindDB();
            string connectionString = northWindDB.getConnection();
            string query = "insert into Customers(CustomerID,CompanyName,ContactName,ContactTitle," +
                "Address,City,Region,PostalCode,Country,Phone,Fax) " +
                " values (@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region," +
                "@PostalCode,@Country,@Phone,@Fax)";

            using(SqlConnection cn= new SqlConnection(connectionString))
            {
                SqlCommand cmd= new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@CustomerID",c.CustomerID);
                cmd.Parameters.AddWithValue("@CompanyName",c.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName",c.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle",c.ContactTitle);
                cmd.Parameters.AddWithValue("@Address",c.Address);
                cmd.Parameters.AddWithValue("@City",c.City);
                cmd.Parameters.AddWithValue("@Region",c.Region);
                cmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);
                cmd.Parameters.AddWithValue("@Country",c.Country);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Fax",c.Fax);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show(c.CompanyName + " se ha agregado correctamente");

            }
        }

        public void DeleteCustomer(string customerID)
        {
            NorthWindDB northWindDB = new NorthWindDB();
            string connectionString = northWindDB.getConnection();
            string query = "update Customers set IsDeleted=1 where CustomerID=@id";

            using(SqlConnection cn= new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", customerID);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado correctamente");
                }catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }

        public void UpdateCustomer(Customer c)
        {
            NorthWindDB northWindDB= new NorthWindDB();
            string connectionString= northWindDB.getConnection();
            string query = "UPDATE Customers SET CompanyName = @CompanyName," +
                "ContactName = @ContactName,ContactTitle = @ContactTitle," +
                "Address = @Address,City = @City, Region = @Region," +
                "PostalCode = @PostalCode,Country = @Country, Phone = @Phone," +
                "Fax =@Fax WHERE CustomerID = @CustomerID";

            using( SqlConnection cn= new SqlConnection(connectionString))
            {
                SqlCommand cmd= new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);
                cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName", c.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle", c.ContactTitle);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@City", c.City);
                cmd.Parameters.AddWithValue("@Region", c.Region);
                cmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);
                cmd.Parameters.AddWithValue("@Country", c.Country);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Fax", c.Fax);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(c.CompanyName+" Se ha actualizado satisfactoriamente");
                }catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                cn.Close();
            }
        }
    }
}
