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
    public partial class Rank : Form
    {
        DataProfile context = new DataProfile();
        public Rank()
        {
            InitializeComponent();
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            try
            {
                List<Profile> listProfile = context.Profiles.ToList();
               
                BindGrid(listProfile);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Profile> listProfile)
        {
            dataGridView1.Rows.Clear();   
            foreach (var item in listProfile)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.Name;
                dataGridView1.Rows[index].Cells[1].Value = item.Score;
  
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start frm = new Start();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}
