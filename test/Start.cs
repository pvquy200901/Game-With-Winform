using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Name frm = new Name();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khong ?", "YES / No", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rank frm = new Rank();
            frm.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
