using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormBamGio
{
    public partial class DongHoBamGio : UserControl
    {
        public DongHoBamGio()
        {
            InitializeComponent();
        }

        private DateTime StartTime;
        private void DongHoBamGio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan elapsed = DateTime.Now - StartTime;

            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds;

            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00");

            txtHourMinSec.Text = text;
            txtMiliSec.Text = tenths.ToString("000");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnStart.Text = timer1.Enabled ? "Stop" : "Start";
            StartTime = DateTime.Now;
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //ghi dữ liệu vào file
            using (StreamWriter sw = new StreamWriter(@"F:\DongHoBamGio\GhiDuLieu.txt", true))
            {
                sw.WriteLine(txtHourMinSec.Text, txtMiliSec.Text);

                //xóa tất cả các textBox.Text sau khi Save 
                txtHourMinSec.Text = "00:00:00";
                txtMiliSec.Text = "000";

                // đóng SWriter ko sẽ gặp lỗi
                sw.Close();
            }//sử dụng using sẽ tự dọn dẹp rác sau khi hoàn thành chương trình

        }
    }
}
