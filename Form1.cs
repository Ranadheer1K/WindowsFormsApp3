using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        static int attempt = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string username = textBox1.Text;
            string password = textBox2.Text;*/   //Not required

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
            {
                attempt = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\ranad\Downloads\MicrosoftTeams-image (1).png");
                MessageBox.Show("you are granted with access");


            }
            else if ((attempt == 3) && (attempt > 0))
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\ranad\Downloads\MicrosoftTeams-image (2).png");
                label3.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                //--attempt;
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\ranad\Downloads\MicrosoftTeams-image.png");
                MessageBox.Show("you are not granted with access");
                attempt++;
            }
        }
    }
}
