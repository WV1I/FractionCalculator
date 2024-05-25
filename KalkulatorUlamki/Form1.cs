using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorUlamki
{
    public partial class Form1 : Form
    {
        /* Curtask list
        1 - Dodawanie 
        2 - Odejmowanie
        3 - Mnożenie
        4 - Dzielenie

        */


        public bool isMInputted { get; set; } = false;
        Ulamek u1 { get; set; }
        Ulamek u2 { get; set; }
        int curtask { get; set; }
        Ulamek utemp { get; set; }
        Kalkulator procesor;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            procesor = new Kalkulator(label1);

            
        }

        void input(int number)
        {
            if (isMInputted == false)
            {
                textBox3.Text = number.ToString();
                
                isMInputted = true;
            }
            else
            {
                
                textBox2.Text = number.ToString();
                utemp = new Ulamek(Convert.ToInt32(textBox3.Text), number);
                isMInputted = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            input(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Dodawanie
            selectTask(1, "+");
        }

        void selectTask(int task, string znak)
        {
            if (u1 == null && utemp != null)
            {
                u1 = utemp;
                label1.Text += u1.ToString() + $" {znak} ";
            }
            else if (u2 == null && utemp != null)
            {
                u2 = utemp;
                label1.Text += u2.ToString();
                curtask = task;
            }
            Clearinput();
        }
        void Clearinput()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            isMInputted = false;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if(u1 != null && u2 != null && curtask != 0)
            procesor.Calculate(u1, u2, curtask);
            Clearinput();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Odejmowanie
            selectTask(2, "-");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Dzielenie
            selectTask(4, "/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectTask(3, "*");
        }
    }
}
