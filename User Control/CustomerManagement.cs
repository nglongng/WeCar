using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCar.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WeCar.User_Control
{

    public partial class CustomerManagement : UserControl
    {
        private int currRow = -1;

        private WeCarDbContext _wecardbContext = new WeCarDbContext();
        public CustomerManagement()
        {
            InitializeComponent();

            loadCustomer();
        }

        private void loadCustomer()
        {
            var cts = _wecardbContext.Customers.ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "CCCD");
            dataGridView1.Columns.Add("Name", "Họ Tên");
            dataGridView1.Columns.Add("Phone", "Số điện thoại");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Address", "Địa chỉ");
            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Phone"].DataPropertyName = "Phone";
            dataGridView1.Columns["Email"].DataPropertyName = "Email";
            dataGridView1.Columns["Address"].DataPropertyName = "Address";
            dataGridView1.DataSource = cts;
        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = inputId.Text;
            var name = inputName.Text;
            var mail = inputMail.Text;
            var address = inputAddress.Text;
            var phone = inputPhone.Text;
            var customer = new Customer()
            {
                Id = id,
                Name = name,
                Phone = phone,
                Email = mail,
                Address = address,
            };

            var cs = _wecardbContext.Customers.Find(id);
            if (cs != null)
            {
                MessageBox.Show("Customer id is existed", "Alert");
            }
            else
            {
                _wecardbContext.Customers.Add(customer);
                _wecardbContext.SaveChanges();
                loadCustomer();
            }

        }

        private void handleClearInput()
        {
            inputId.Clear();
            inputName.Clear();
            inputMail.Clear();
            inputAddress.Clear();
            inputPhone.Clear();
            inputId.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var searchValue = inputSearch.Text;
            var customers = _wecardbContext.Customers.Where(cs => cs.Name.Contains(searchValue) || cs.Phone.Contains(searchValue)).ToList();
            dataGridView1.DataSource = customers;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currRow ==-1)
            {
            }
            else
            {
                var id = dataGridView1.Rows[currRow].Cells[0].Value.ToString();
                var customer = _wecardbContext.Customers.Find(id);
                if (customer == null)
                {
                    MessageBox.Show("Customer not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _wecardbContext.Customers.Remove(customer);
                    _wecardbContext.SaveChanges();
                    loadCustomer();
                    handleClearInput();
                    currRow = -1;


                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currRow = e.RowIndex;
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            var phone = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            var mail = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            var address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            inputId.Text = id;
            inputName.Text = name;
            inputPhone.Text = phone;
            inputAddress.Text = address;
            inputMail.Text = mail;

        }

        private void a(object sender, DataGridViewCellEventArgs e)
        {

            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            var phone = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            var mail = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            var address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            var cs = new Customer()
            {
                Id = id,
                Name = name,
                Phone = phone,
                Email = mail,
                Address = address,
            };

            _wecardbContext.Customers.Update(cs);
            _wecardbContext.SaveChanges();
            loadCustomer();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var id = inputId.Text;
            var name = inputName.Text;
            var mail = inputMail.Text;
            var address = inputAddress.Text;
            var phone = inputPhone.Text;

            var customer = _wecardbContext.Customers.Find(id);
            if(customer != null)
            {
                customer.Name = name;
                customer.Phone = phone;
                customer.Email = mail;
                customer.Address = address;
                _wecardbContext.Customers.Update(customer);
                _wecardbContext.SaveChanges();
                handleClearInput();
            }
            else
            {
                MessageBox.Show("Customer update not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            loadCustomer();

        }
    }

}
