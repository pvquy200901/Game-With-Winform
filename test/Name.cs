using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.DataModel;

namespace test
{
    public partial class Name : Form
    {
        public static string nameNe = "";
        DataProfile context = new DataProfile();
        public Name()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {

                    bool check = context.Profiles.Any(p => p.Name == textBox1.Text);
                    if (!check)
                    {
                        Profile s = new Profile()
                        {
                            Name = textBox1.Text,
                        };
                        context.Profiles.Add(s);
                        context.SaveChanges();
                    }
                    nameNe = textBox1.Text;

                    Form1 frm = new Form1();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start frm = new Start();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        public string getName()
        {
            return nameNe;
        }
    }
}
