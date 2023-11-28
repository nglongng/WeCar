using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCar.Controller;

namespace WeCar.User_Control
{
    public partial class carManagement : UserControl
    {
        private RadioButton r = null;
        private WeCarDbContext _weCarContext = new WeCarDbContext();
        private int currRow = -1;
        public carManagement()
        {
            InitializeComponent();
            loadCar();
            loadType();
        }

        private void loadCar()
        {
            using (var context = new WeCarDbContext())
            {
                // Example: Querying Users and displaying names in a MessageBox
                var users = context.Cars.Take(20)
                    .Select(car => new
                    {
                        Id = car.Id,
                        Name = car.Name,
                        Brand = car.Brand,
                        Status = car.Status,
                        Price = car.Price,
                        Fuel = car.Fuel.Name,
                        CarType = car.CarType.Id
                    })

                    .ToList();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Name", "Tên xe");
                dataGridView1.Columns.Add("Brand", "Hãng xe");
                dataGridView1.Columns.Add("Status", "Trạng thái");
                dataGridView1.Columns.Add("Price", "Giá thuê/Giờ");
                dataGridView1.Columns.Add("Fuel", "Loại nhiên liệu");
                dataGridView1.Columns.Add("CarType", "Loại xe");

                dataGridView1.Columns["Id"].DataPropertyName = "Id";
                dataGridView1.Columns["Name"].DataPropertyName = "Name";
                dataGridView1.Columns["Brand"].DataPropertyName = "Brand";
                dataGridView1.Columns["Status"].DataPropertyName = "Status";
                dataGridView1.Columns["Price"].DataPropertyName = "Price";
                dataGridView1.Columns["Fuel"].DataPropertyName = "Fuel";
                dataGridView1.Columns["CarType"].DataPropertyName = "CarType";
                dataGridView1.DataSource = users;



            }
        }


        private void loadType()
        {
            using (var context = new WeCarDbContext())
            {
                // Example: Querying Users and displaying names in a MessageBox
                var users = context.CarTypes.ToList();
                selectType.DataSource = users;
                selectType.ValueMember = "Id";
                selectType.DisplayMember = "Name";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void addBtn_click(object sender, EventArgs e)
        {
            using (var context = new WeCarDbContext())

            {
                var fuelId = getSelectedData();
                if (fuelId == "")
                {
                    MessageBox.Show("Choose type of fuel!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CarTypes ct = selectType.SelectedItem as CarTypes;
                    if (ct != null)
                    {
                        var carType = context.CarTypes.Find(ct.Id);
                        if (carType != null)
                        {
                            var fuel = context.Fuels.Find(fuelId);
                            var newCar = new Car()
                            {
                                Id = inputCarId.Text,
                                Name = inputCarName.Text,
                                Brand = inputBrand.Text,
                                Status = "Avalable",
                                Price = int.Parse(inputPrice.Text),
                                Fuel = fuel,
                                CarType = carType,
                            };

                            context.Cars.Add(newCar);
                            context.SaveChanges();
                            clearInput();
                        }
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearInput()
        {
            inputCarName.Clear();
            inputBrand.Clear();
            inputCarId.Clear();
            inputPrice.Clear();
            if (r != null)
            {
                r.Checked = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var f = getSelectedData();
            var searchValue = inputBox.Text;
            CarTypes ct = selectType.SelectedItem as CarTypes;
            using (var context = new WeCarDbContext())
            {

                var cars = context.Cars
                    .Where(car => car.Name.Contains(searchValue) || car.Brand.Contains(searchValue)).Where(car => car.Fuel.Id.Contains(f)).Where(car => car.CarType.Id == ct.Id)
                    .Take(20)
                    .Select(car => new
                    {
                        Id = car.Id,
                        Name = car.Name,
                        Brand = car.Brand,
                        Status = car.Status,
                        Price = car.Price,
                        Fuel = car.Fuel.Name,
                        CarType = car.CarType.Id
                    })

                    .ToList();
                dataGridView1.DataSource = cars;



            }

        }

        private string getSelectedData()
        {
            foreach (RadioButton radio in fuelGroup.Controls)
            {
                if (radio != null)
                {
                    if (radio.Checked)
                    {
                        r = radio;
                        break;
                    }
                }
            }
            if (r == null)
            {

                return "";
            }
            return r.Name;
        }

        private void selectType_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void handleDelCar(object sender, EventArgs e)
        {
            if (currRow == -1)
            {
                MessageBox.Show("Enter car's id to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var id = dataGridView1.Rows[currRow].Cells[0].Value.ToString();
                var car = _weCarContext.Cars.Find(id);
                if (car != null)
                {
                    _weCarContext.Cars.Remove(car);
                    _weCarContext.SaveChanges();
                    loadCar();
                    clearInput();
                    currRow = -1;
                }
                else
                {
                    MessageBox.Show("Car not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currRow = e.RowIndex;
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            var brand = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            var status = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            var price = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            inputBrand.Text = brand;
            inputCarId.Text = id;
            inputCarName.Text = name;
            inputPrice.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fuelId = getSelectedData();
            if (fuelId == "")
            {
                MessageBox.Show("Choose type of fuel!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CarTypes ct = selectType.SelectedItem as CarTypes;
                if (ct != null)
                {
                    var carType = _weCarContext.CarTypes.Find(ct.Id);
                    if (carType != null)
                    {
                        var fuel = _weCarContext.Fuels.Find(fuelId);
                        var newCar = new Car()
                        {
                            Id = inputCarId.Text,
                            Name = inputCarName.Text,
                            Brand = inputBrand.Text,
                            Status = "Avalable",
                            Price = int.Parse(inputPrice.Text),
                            Fuel = fuel,
                            CarType = carType,
                        };
                        _weCarContext.Cars.Update(newCar);
                        _weCarContext.SaveChanges();
                        clearInput();
                    }
                }
            }
        }

        private void selectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
