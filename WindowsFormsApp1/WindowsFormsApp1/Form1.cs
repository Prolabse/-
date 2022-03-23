using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        Country[] countries = new Country[5];
        string[] ImageList = { "im1.jpg", "im2.jpg", "im3.jpg", "im4.jpg", "im5.jpg", "im6.jpg" };





        int index = 0;



        public Form1()
        {
            InitializeComponent();

            Country country = new Country();
            
     
            country.set("BR", "Brazil");
            countries[0] = country;
            
            country.set("CA", "Canada");
            countries[1] = country;

            country.set("US", "America");
            countries[2] = country;

            country.set("FR", "France");
            countries[3] = country;

            country.set("NGA", "Nigeria");
            countries[4] = country;

        }




        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 3) index = 0;

            pictureBox1.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index > 1) index = 0;

            pictureBox1.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/Александра/source/repos/WindowsFormsApp1/WindowsFormsApp1/aa/" + ImageList[index + 2]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form2 newform = new Form2();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newform = new Form3();
            newform.Show();
        }

    }

    class player
    {







    }

}



