using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic
{
    public partial class Form2 : Form
    {
        TimeSpan st;
        TimeSpan en;
        int[,] matr;
        Form1 main;
        int count_r = 0;
        void zap_pc(int x, int y)
        {
            count_r++;
            Bitmap image1 = new Bitmap("2.png");
            if (x == 0)
            {
                if (y == 0)
                {
                    pictureBox4.Image = image1;
                    pictureBox4.Enabled = false;
                }
                if (y == 1)
                {
                    pictureBox3.Image = image1;
                    pictureBox3.Enabled = false;
                }
                if (y == 2)
                {
                    pictureBox2.Image = image1;
                    pictureBox2.Enabled = false;
                }
            }
            if (x == 1)
            {
                if (y == 0)
                {
                    pictureBox7.Image = image1;
                    pictureBox7.Enabled = false;
                }
                if (y == 1)
                {
                    pictureBox5.Image = image1;
                    pictureBox5.Enabled = false;
                }
                if (y == 2)
                {
                    pictureBox6.Image = image1;
                    pictureBox6.Enabled = false;
                }
            }
            if (x == 2)
            {
                if (y == 0)
                {
                    pictureBox8.Image = image1;
                    pictureBox8.Enabled = false;
                }
                if (y == 1)
                {
                    pictureBox9.Image = image1;
                    pictureBox9.Enabled = false;
                }
                if (y == 2)
                {
                    pictureBox10.Image = image1;
                    pictureBox10.Enabled = false;
                }
            }
            vin();
        }

        int pc()
        {

            //ход для победы
            //по горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (matr[i, 0] == 2 && matr[i, 1] == 2 && matr[i, 2] == 0)
                {
                    matr[i, 2] = 2;
                    zap_pc(i, 2);
                    return 0;
                }

                if (matr[i, 0] == 2 && matr[i, 2] == 2 && matr[i, 1] == 0)
                {
                    matr[i, 1] = 2;
                    zap_pc(i, 1);
                    return 0;
                }

                if (matr[i, 2] == 2 && matr[i, 1] == 2 && matr[i, 0] == 0)
                {
                    matr[i, 0] = 2;
                    zap_pc(i, 0);
                    return 0;
                }

            }
            //по вертикали
            for (int i = 0; i < 3; i++)
            {
                if (matr[0, i] == 2 && matr[1, i] == 2 && matr[2, i] == 0)
                {
                    matr[2, i] = 2;
                    zap_pc(2, i);
                    return 0;
                }

                if (matr[0, i] == 2 && matr[0, 2] == 2 && matr[1, i] == 0)
                {
                    matr[1, i] = 2;
                    zap_pc(1, i);
                    return 0;
                }

                if (matr[2, i] == 2 && matr[1, i] == 2 && matr[0, i] == 0)
                {
                    matr[0, i] = 2;
                    zap_pc(0, i);
                    return 0;
                }

            }
            //по диагонали
            if (matr[0, 0] == 2 && matr[1, 1] == 2 && matr[2, 2] == 0)
            {
                matr[2, 2] = 2;
                zap_pc(2, 2);
                return 0;
            }
            if (matr[0, 0] == 2 && matr[2, 2] == 2 && matr[1, 1] == 0)
            {
                matr[1, 1] = 2;
                zap_pc(1, 1);
                return 0;
            }
            if (matr[1, 1] == 2 && matr[2, 2] == 2 && matr[0, 0] == 0)
            {
                matr[0, 0] = 2;
                zap_pc(0, 0);
                return 0;
            }
            //----------------------------------------------
            if (matr[0, 2] == 2 && matr[1, 1] == 2 && matr[2, 0] == 0)
            {
                matr[2, 0] = 2;
                zap_pc(2, 0);
                return 0;
            }
            if (matr[0, 2] == 2 && matr[2, 0] == 2 && matr[1, 1] == 0)
            {
                matr[1, 1] = 2;
                zap_pc(1, 1);
                return 0;
            }
            if (matr[1, 1] == 2 && matr[2, 0] == 2 && matr[0, 2] == 0)
            {
                matr[0, 2] = 2;
                zap_pc(0, 2);
                return 0;
            }

            //проверка на опастность по горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (matr[i, 0] == 1 && matr[i, 1] == 1 && matr[i, 2] == 0)
                {
                    matr[i, 2] = 2;
                    zap_pc(i, 2);
                    return 0;
                }

                if (matr[i, 0] == 1 && matr[i, 2] == 1 && matr[i, 1] == 0)
                {
                    matr[i, 1] = 2;
                    zap_pc(i, 1);
                    return 0;
                }

                if (matr[i, 2] == 1 && matr[i, 1] == 1 && matr[i, 0] == 0)
                {
                    matr[i, 0] = 2;
                    zap_pc(i, 0);
                    return 0;
                }

            }
            //проверка на опастность по вертикали
            for (int i = 0; i < 3; i++)
            {
                if (matr[0, i] == 1 && matr[1, i] == 1 && matr[2, i] == 0)
                {
                    matr[2, i] = 2;
                    zap_pc(2, i);
                    return 0;
                }

                if (matr[0, i] == 1 && matr[0, 2] == 1 && matr[1, i] == 0)
                {
                    matr[1, i] = 2;
                    zap_pc(1, i);
                    return 0;
                }

                if (matr[2, i] == 1 && matr[1, i] == 1 && matr[0, i] == 0)
                {
                    matr[0, i] = 2;
                    zap_pc(0, i);
                    return 0;
                }

            }
            //проверка на опастность по диагонали
            if (matr[0, 0] == 1 && matr[1, 1] == 1 && matr[2, 2] == 0)
            {
                matr[2, 2] = 2;
                zap_pc(2, 2);
                return 0;
            }
            if (matr[0, 0] == 1 && matr[2, 2] == 1 && matr[1, 1] == 0)
            {
                matr[1, 1] = 2;
                zap_pc(1, 1);
                return 0;
            }
            if (matr[1, 1] == 1 && matr[2, 2] == 1 && matr[0, 0] == 0)
            {
                matr[0, 0] = 2;
                zap_pc(0, 0);
                return 0;
            }
            //----------------------------------------------
            if (matr[0, 2] == 1 && matr[1, 1] == 1 && matr[2, 0] == 0)
            {
                matr[2, 0] = 2;
                zap_pc(2, 0);
                return 0;
            }
            if (matr[0, 2] == 1 && matr[2, 0] == 1 && matr[1, 1] == 0)
            {
                matr[1, 1] = 2;
                zap_pc(1, 1);
                return 0;
            }
            if (matr[1, 1] == 1 && matr[2, 0] == 1 && matr[0, 2] == 0)
            {
                matr[0, 2] = 2;
                zap_pc(0, 2);
                return 0;
            }

            //рандомный ход
            int g = 0;
            Random r = new Random();
            int x = r.Next(0, 3);
            int y = r.Next(0, 3);
            while (g!=1)
            {
                x = r.Next(0, 3);
                y = r.Next(0, 3);
                if (matr[x, y] == 0)
                {
                    g = 1;
                }
            }
            if (g == 1)
            {
                matr[x, y] = 2;
                zap_pc(x, y);
                return 0;
            }
            return 0;
            
        }

        void zap(int x, int y)
        {
            if (matr[x, y] != 1 || matr[x, y] != 2)
            {
                matr[x, y] = 1;
                Bitmap image1 = new Bitmap("1.png");
                if (x == 0)
                {
                    if (y == 0)
                    {
                        pictureBox4.Image = image1;
                    }
                    if (y == 1)
                    {
                        pictureBox3.Image = image1;
                    }
                    if (y == 2)
                    {
                        pictureBox2.Image = image1;
                    }
                }
                if (x == 1)
                {
                    if (y == 0)
                    {
                        pictureBox7.Image = image1;
                    }
                    if (y == 1)
                    {
                        pictureBox5.Image = image1;
                    }
                    if (y == 2)
                    {
                        pictureBox6.Image = image1;
                    }
                }
                if (x == 2)
                {
                    if (y == 0)
                    {
                        pictureBox8.Image = image1;
                    }
                    if (y == 1)
                    {
                        pictureBox9.Image = image1;
                    }
                    if (y == 2)
                    {
                        pictureBox10.Image = image1;
                    }
                }
            }
        }

        int check()
        {
            //пользователь
            //диагонали
            if (matr[0,0]==1 && matr[1, 1] == 1 && matr[2, 2] == 1)
            {
                return 1;
            }
            if (matr[0, 2] == 1 && matr[1, 1] == 1 && matr[2, 0] == 1)
            {
                return 1;
            }
            //горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (matr[i, 0] == 1 && matr[i, 1] == 1 && matr[i, 2] == 1)
                {
                    return 1;
                }
            }
            //вертикали
            for (int i = 0; i < 3; i++)
            {
                if (matr[0, i] == 1 && matr[1, i] == 1 && matr[2, i] == 1)
                {
                    return 1;
                }
            }

                //пк
                if (matr[0, 0] == 2 && matr[1, 1] == 2 && matr[2, 2] == 2)
                {
                    return 2;
                }
                if (matr[0, 2] == 2 && matr[1, 1] == 2 && matr[2, 0] == 2)
                {
                    return 2;
                }
                //горизонтали
                for (int i = 0; i < 3; i++)
                {
                    if (matr[i, 0] == 2 && matr[i, 1] == 2 && matr[i, 2] == 2)
                    {
                        return 2;
                    }
                }
                //вертикали
                for (int i = 0; i < 3; i++)
                {
                if (matr[0, i] == 2 && matr[1, i] == 2 && matr[2, i] == 2)
                {
                    return 2;
                }
                
            }
            //ничья
            if (count_r == 9)
            {
                return 3;
            }
            return 0;

        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            main = f;
             matr = new int[3, 3];
           label4.Text = DateTime.Now.TimeOfDay.ToString().Substring(0,8) ;
            st = DateTime.Now.TimeOfDay;
        }

        void vin()
        {
            if (check() == 1)
            {
                label2.Visible = true;
                label1.Visible = true;
                textBox1.Visible = true;
                button3.Visible = true;
                button3.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                label5.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
                en = DateTime.Now.TimeOfDay;
            }
            if (check() == 2)
            {
                label2.Text = "Вы проиграли";
                label2.Visible = true;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                label5.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
                en = DateTime.Now.TimeOfDay;
            }
            if (check() == 3)
            {
                label2.Text = "Ничья";
                label2.Visible = true;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                label5.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
                en = DateTime.Now.TimeOfDay;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            main.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(2, 2);
            pictureBox10.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(1, 2);
            pictureBox6.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(0, 2);
            pictureBox2.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            zap(0, 1);
            pictureBox3.Enabled = false;
            count_r++;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(1, 1);
            pictureBox5.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(2, 1);

            pictureBox9.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            zap(0, 0);
            pictureBox4.Enabled = false;
            count_r++;
            vin();
            if (count_r < 9)
            {
                pc();
            }
            }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(1, 0);
            pictureBox7.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            count_r++;
            zap(2, 0);
            pictureBox8.Enabled = false;
            vin();
            if (count_r < 9)
            {
                pc();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(main);
            Close();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //сохранение в бд
            TimeSpan res = en - st; 
            string query = "INSERT INTO rating ( [user], score ) VALUES ('" + textBox1.Text + "', '" + res.ToString().Substring(0, 8) + "');";
            OleDbCommand command = new OleDbCommand(query, main.myConnection);
            command.ExecuteNonQuery();
            Form2 f2 = new Form2(main);
            Close();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
