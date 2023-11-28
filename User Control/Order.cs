using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCar.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WeCar.User_Control
{
    public partial class Order : UserControl
    {

        private List<String> services = new List<String>();
        private int size = 0;
        private int currRow = -1;

        private WeCarDbContext _wecarDbContext = new WeCarDbContext();
        public Order()
        {
            InitializeComponent();
            loadBill();
            var list = new List<Taskk>();
            list.Add(new Taskk()
            {
                Name = "",
                Value = "empty"
            });
            list.Add(new Taskk()
            {
                Name = "Đã Thanh Toán",
                Value = "Done"
            });
            list.Add(new Taskk()
            {
                Name = "Đang thuê",
                Value = "Process"
            });

            inputStatus.DisplayMember = "Name";
            inputStatus.ValueMember = "Value";
            inputStatus.DataSource = list;

        }

        private void handleCheck(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox.Checked)
            {
                services.Add(checkBox.Name);
            }
            else
            {
                services.Remove(checkBox.Name);
            }
        }

        private void clearInput()
        {
            inputCarId.Clear();
            inputCustomerId.Clear();
            inputPeriod.Clear();
            inputStart.Clear();
            inputDestination.Clear();
            inputStatus.SelectedValue = "empty";
            var services = _wecarDbContext.Services.Select(s=>s.Id).ToList();
            foreach (string checkboxName in services)
            {
                Control[] matches = this.Controls.Find(checkboxName, true);

                if (matches.Length > 0 && matches[0] is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)matches[0];
                    checkbox.Checked = false;
                }
            }
        }


        private void loadBill()
        {
            var bills = _wecarDbContext.Bills.Select(bill => new
            {
                Id = bill.Id,
                TimeStart = bill.TimeStart,
                Status = bill.Status,
                Period = bill.Period,
                CarName = bill.Car.Name,
                Customer = bill.Customer.Name,
                Employee = bill.Employee.Name,
                Total = bill.TotalPrice
            }).ToList();
            size = bills.Count;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("TimeStart", "Thời điểm thuê");
            dataGridView1.Columns.Add("Status", "Trạng thái hóa đơn");
            dataGridView1.Columns.Add("CarName", "Tên xe");
            dataGridView1.Columns.Add("Period", "Số ngày");
            dataGridView1.Columns.Add("Customer", "Khách hàng");
            dataGridView1.Columns.Add("Employee", "Người lập");
            dataGridView1.Columns.Add("Total", "Tổng hóa đơn");

            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["TimeStart"].DataPropertyName = "TimeStart";
            dataGridView1.Columns["Status"].DataPropertyName = "Status";
            dataGridView1.Columns["CarName"].DataPropertyName = "CarName";
            dataGridView1.Columns["Period"].DataPropertyName = "Period";
            dataGridView1.Columns["Customer"].DataPropertyName = "Customer";
            dataGridView1.Columns["Employee"].DataPropertyName = "Employee";
            dataGridView1.Columns["Total"].DataPropertyName = "Total";
            dataGridView1.DataSource = bills;

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inputPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var userId = inputCustomerId.Text;
            var carId = inputCarId.Text;
            var date = inputDate.Text;
            var period = inputPeriod.Text;
            var from = inputStart.Text;
            var Des = inputDestination.Text;
            var car = _wecarDbContext.Cars.Find(carId);
            if(car.Status == "Hiring")
            {
                MessageBox.Show("Car ("+car.Name+") is not available", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var customer = _wecarDbContext.Customers.Find(userId);
            Taskk ct = inputStatus.SelectedItem as Taskk;
            var status = ct.Value;
            if(status == "Process")
            {
                car.Status = "Hiring";
                _wecarDbContext.Cars.Update(car);
            }else
            {
                car.Status = "Available";
                _wecarDbContext.Cars.Update(car);
            }
            ICollection<Service> col = new List<Service>();
            int total = 0;
            total += car.Price * int.Parse(period);
            foreach (var service in services)
            {
                var newService = _wecarDbContext.Services.Find(service);
                if (newService != null)
                {
                    total += newService.Price;
                    col.Add(newService);
                }
            }

            string username = Properties.Settings.Default.username;

            var emp = _wecarDbContext.Employees.Where(e => e.Username == username).FirstOrDefault();
            if (emp == null)
            {
                MessageBox.Show("Employee not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            

            _wecarDbContext.Bills.Add(new Bill
            {
                Id = userId+""+ date+size,
                TimeStart = date,
                Status = status,
                Period = int.Parse(period),
                TotalPrice = total,
                Car = car,
                Customer = customer,
                Schedule = new Schedules()
                {
                    Id = userId + "" + date,
                    From = from,
                    To = Des
                },
                Employee = emp,
                Services = col
            });
            _wecarDbContext.SaveChanges();
            loadBill();
            clearInput();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clearInput();
            currRow = e.RowIndex;
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var time = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            var staus = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            var period = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            var carName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            var customerName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            var employeeName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            var total = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
         
            var bill = _wecarDbContext.Bills.Where(b => b.Id == id).Select(b => new
            {
                customerId = b.Customer.Id,
                carId = b.Car.Id,
                period = b.Period,
                date = b.TimeStart,
                status = b.Status,
                start = b.Schedule.From,
                to = b.Schedule.To,
            }).FirstOrDefault();
            
            inputCarId.Text = bill.carId;
            inputCustomerId.Text = bill.customerId;
            inputStart.Text = bill.start;
            inputDestination.Text = bill.to;
            inputPeriod.Text = period;
            inputStatus.SelectedValue = staus;
            services.Clear();
            var mservices = _wecarDbContext.Bills.Where(bill => bill.Id == id).SelectMany(b => b.Services.Select(s => s.Id)).ToList();

           if (mservices.Count>0)
            {
                foreach (string checkboxName in mservices)
                {
                    services.Add(checkboxName);

                    Control[] matches = this.Controls.Find(checkboxName, true);

                    if (matches.Length > 0 && matches[0] is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)matches[0];
                        checkbox.Checked = true;
                    }
                }
            }
            DateTime selectedDate;
            if (DateTime.TryParseExact(bill.date, "yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture, DateTimeStyles.None, out selectedDate))
            {
                inputDate.Value = selectedDate;
            }


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (currRow != -1)
            {
                var currBillId = dataGridView1.Rows[currRow].Cells[0].Value.ToString();
                var prevCarId = _wecarDbContext.Bills.Where(b=> b.Id == currBillId).Select(b=> b.Car.Id).FirstOrDefault();
                var userId = inputCustomerId.Text;
                var carId = inputCarId.Text;
                var date = inputDate.Text;
                var period = inputPeriod.Text;
                var from = inputStart.Text;
                var Des = inputDestination.Text;
                var car = _wecarDbContext.Cars.Find(carId);
                var customer = _wecarDbContext.Customers.Find(userId);
                Taskk ct = inputStatus.SelectedItem as Taskk;
                var status = ct.Value;
                if (car.Status == "Hiring" && prevCarId != carId)
                {
                    MessageBox.Show("Car (" + car.Name + ") is not available", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (status == "Process")
                {
                    car.Status = "Hiring";
                    _wecarDbContext.Cars.Update(car);
                }
                else
                {
                    car.Status = "Available";
                    _wecarDbContext.Cars.Update(car);
                }
                ICollection<Service> col = new List<Service>();
                int total = 0;
                total += car.Price * int.Parse(period);
                foreach (var service in services)
                {
                    var newService = _wecarDbContext.Services.Find(service);
                    if (newService != null)
                    {
                        total += newService.Price;
                        col.Add(newService);
                    }
                }

                string username = Properties.Settings.Default.username;

                var emp = _wecarDbContext.Employees.Where(e => e.Username == username).FirstOrDefault();
                if (emp == null)
                {
                    MessageBox.Show("Employee not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var id = dataGridView1.Rows[currRow].Cells[0].Value.ToString();
                var l = _wecarDbContext.Schedules.ToList().Count;

                var schedule = new Schedules()
                {
                    Id = "" + l,
                    From = from,
                    To = Des

                };

                if (id != null)
                {
                            var bill = _wecarDbContext.Bills.Find(id);
                            if (bill != null)
                            {
                                _wecarDbContext.Bills.Remove(bill);
                                _wecarDbContext.SaveChanges();
                                bill.Customer = customer;
                                bill.Car = car;
                                bill.Services = col;
                                bill.Status = status;
                                bill.TotalPrice = total;
                                bill.Employee = emp;
                                bill.Period = int.Parse(period);
                                bill.TimeStart = date;
                                bill.Schedule = schedule;
                                _wecarDbContext.Bills.Add(bill);
                                _wecarDbContext.SaveChanges();
                                loadBill();
                                clearInput();
                                currRow = -1;
                            }
                        }
                    


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(currRow!=-1)
            {
                var bill = _wecarDbContext.Bills.Find(dataGridView1.Rows[currRow].Cells[0].Value.ToString());
                if (bill != null)
                {
                    _wecarDbContext.Bills.Remove(bill);
                    _wecarDbContext.SaveChanges(true);
                    currRow = -1;
                    loadBill();
                    clearInput();
                }
            }
        }
    }
}
