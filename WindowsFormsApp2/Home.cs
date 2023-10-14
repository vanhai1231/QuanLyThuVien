using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        // biến nhạc nền 
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Home()
        {
            InitializeComponent();
            CenterToScreen();
            wplayer.URL = "LMT.mp3";
            wplayer.settings.autoStart = true;
            wplayer.settings.setMode("loop", true);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // cập nhật ngày tháng
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach formQuanLySach = new QuanLySach();
            formQuanLySach.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia formQuanLyDocGia = new QuanLyDocGia();
            formQuanLyDocGia.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien formQuanLyNhanVien = new QuanLyNhanVien();
            formQuanLyNhanVien.ShowDialog();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemSach formTimKiemSach = new timKiemSach();
            formTimKiemSach.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
