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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeCar.User_Control
{
    public partial class DataManagement : UserControl
    {
        private WeCarDbContext _wecarDbContext = new WeCarDbContext();
        public DataManagement()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string fileName = "data.csv";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, fileName);
            var data = _wecarDbContext.Customers.ToList();
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header (column names)
                sw.WriteLine("Số CCCD,Họ Tên,Số điện thoại,Email,Địa chỉ");

                // Write each data item to the file
                foreach (var item in data)
                {
                    sw.WriteLine($"{item.Id},{item.Name},{item.Phone}, {item.Email}, {item.Address}");
                }
                MessageBox.Show("exported", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
