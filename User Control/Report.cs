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
    public partial class Report : UserControl
    {
        private WeCarDbContext _wecarDbContext = new WeCarDbContext();
        public Report()
        {
            InitializeComponent();
            loadReport();
        }

        private void loadReport()
        {
            var result = _wecarDbContext.Bills.GroupBy(b => b.Car.CarType.Id).Select(b => new
            {
                carId = b.Key,
                totalPrice = b.Sum(va => va.TotalPrice),
                totalHours = b.Sum(va => va.Period)
            })
                .Select(rs => new
                {
                    carName = _wecarDbContext.Cars
                    .Where(c => c.CarType.Id == rs.carId)
                    .Select(r => r.CarType.Name).FirstOrDefault(),
                    totalPrice = rs.totalPrice,
                    totalHours = rs.totalHours

                })

                .ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("carName", "Loại xe");
            dataGridView1.Columns.Add("totalPrice", "Tổng doanh thu");
            dataGridView1.Columns.Add("totalHours", "Tổng số ngày đã thuê");
            dataGridView1.Columns["carName"].DataPropertyName = "carName";
            dataGridView1.Columns["totalPrice"].DataPropertyName = "totalPrice";
            dataGridView1.Columns["totalHours"].DataPropertyName = "totalHours";
            dataGridView1.DataSource = result;


            var result2 = _wecarDbContext.Bills.GroupBy(b => b.Car.Brand).Select(b => new
            {
                carBrand = b.Key,
                totalPrice = b.Sum(va => va.TotalPrice),
                totalHours = b.Sum(va => va.Period)
            }).ToList();

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("carBrand", "Hãng xe");
            dataGridView2.Columns.Add("totalPrice", "Tổng doanh thu");
            dataGridView2.Columns.Add("totalHours", "Tổng số ngày đã thuê");
            dataGridView2.Columns["carBrand"].DataPropertyName = "carBrand";
            dataGridView2.Columns["totalPrice"].DataPropertyName = "totalPrice";
            dataGridView2.Columns["totalHours"].DataPropertyName = "totalHours";
            dataGridView2.DataSource = result2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
