using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.DataModel;

namespace test
{
    
    public partial class Form1 : Form
    {
        DataProfile context = new DataProfile();
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            i++;
            label3.Text = i.ToString();

        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            starTime();
            linemove(carspeed);
            speedUp();
            totalscore();
            gameover();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            DialogResult go = MessageBox.Show("Do you want to quit?", "QUIT GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            switch (go)
            {
                case System.Windows.Forms.DialogResult.No:
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    this.Close();

                    break;
            }
        
        }
       
        void save()
        {
            DataProfile context = new DataProfile();
            Name name = new Name();
            string name2 = name.getName();
            Profile profile = context.Profiles.SingleOrDefault(p => p.Name == name2);
            if(profile != null)
            {
               profile.Score = int.Parse(label3.Text);
            };
            context.Profiles.AddOrUpdate(profile);
            context.SaveChanges();
        }
        void speedUp()
        {
            if (score == 25)
            {
                carspeed = 5;
            }
            if (score == 40)
            {
                carspeed = 7;
            }
            if (score == 60)
            {
                carspeed = 10;
            }
            
        }
        Random pos = new Random();
        void linemove(int speed)
        {
          
            if (pictureBox1.Top > 500) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;
            if (pictureBox2.Top > 500) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;
            if (pictureBox3.Top > 500) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;
            if (enemy1.Top > 500)
            {
                score++;
                enemy1.Left = pos.Next(0, 100);
                enemy1.Top = pos.Next(0, 40);
                //enemy1.Top = 0;
            }
            else enemy1.Top += speed;
            if (enemy2.Top > 500)
            {
                score++;
                enemy2.Left = pos.Next(100, 200);
                enemy2.Top = pos.Next(0, 40);
                //enemy2.Top = 0;
            }
            else enemy2.Top += speed;
            if (enemy3.Top > 500)
            {
                score++;
                enemy3.Left = pos.Next(200, 300);
                enemy3.Top = pos.Next(0, 40);
                //enemy3.Top = 0;
            }
            else enemy3.Top += speed;
            if (enemy4.Top > 500)
            {
                score++;
                enemy4.Left = pos.Next(300, 400);
                enemy4.Top = pos.Next(0, 40);
                //enemy4.Top = 0;
            }
            else enemy4.Top += speed;
        }
        int carspeed = 3;
     
        int score;
        void callForm()
        {
            Rank frm = new Rank();
            frm.Show();
            this.Hide();
        }
       void totalscore()
        {
             label4.Text = score.ToString();
        }
        void starTime()
        {
            timer2.Start();
        }
       
        void gameover()
        {
            if (mycar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play agian?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 100);
                        enemy1.Top = pos.Next(0, 100);

                        enemy2.Left = pos.Next(100, 200);
                        enemy2.Top = pos.Next(100, 200);

                        enemy3.Left = pos.Next(200, 300);
                        enemy3.Top = pos.Next(0, 100);

                        enemy4.Left = pos.Next(300, 400);
                        enemy4.Top = pos.Next(100, 200);
                        carspeed = 3;
                        score = 0;
                        i = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        save();
                        callForm();


                        break;
                }
            }
            if (mycar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play agian?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 100);
                        enemy1.Top = pos.Next(0, 100);

                        enemy2.Left = pos.Next(100, 200);
                        enemy2.Top = pos.Next(100, 200);

                        enemy3.Left = pos.Next(200, 300);
                        enemy3.Top = pos.Next(0, 100);

                        enemy4.Left = pos.Next(300, 400);
                        enemy4.Top = pos.Next(100, 200);
                        carspeed = 3;
                        i = 0;
                        score = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        save();
                        callForm();

                        break;
                }
            }
            if (mycar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play agian?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 100);
                        enemy1.Top = pos.Next(0, 100);

                        enemy2.Left = pos.Next(100, 200);
                        enemy2.Top = pos.Next(100, 200);

                        enemy3.Left = pos.Next(200, 300);
                        enemy3.Top = pos.Next(0, 100);

                        enemy4.Left = pos.Next(300, 400);
                        enemy4.Top = pos.Next(100, 200);
                        carspeed = 3;
                        i = 0;
                        score = 0; 
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        save();
                        callForm();

                        break;
                }
            }
            if (mycar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play agian?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 100);
                        enemy1.Top = pos.Next(0, 100);

                        enemy2.Left = pos.Next(100, 200);
                        enemy2.Top = pos.Next(100, 200);

                        enemy3.Left = pos.Next(200, 300);
                        enemy3.Top = pos.Next(0, 100);

                        enemy4.Left = pos.Next(300, 400);
                        enemy4.Top = pos.Next(100, 200);
                        carspeed = 3;
                        i = 0;
                        score = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        save();
                        callForm();

                        break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && mycar.Left > 0)
            {
                mycar.Left -= 15;
            }
            if (e.KeyCode == Keys.X && mycar.Left < 390)
            {
                mycar.Left += 15;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            DialogResult stop = MessageBox.Show("Bấm OK để tiếp tục","Bạn đã tạm dừng");
            switch (stop)
            {
               
                case DialogResult.OK:
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    
                    break;
               
                default:
                    break;
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
