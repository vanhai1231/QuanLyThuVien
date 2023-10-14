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
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnOutQLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {

        }

       
    }
}
