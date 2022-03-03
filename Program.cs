using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{ 
    public partial class Form1 : Form
    {
        string[] ImageList = new string[] { "namePhoto1.jpg", "namePhoto2.jpg", "namePhoto3.jpg", "namePhoto4.jpg", "namePhoto5.jpg", "namePhoto6.jpg" };

      
        int index = 0;
        public Form1()
        {

            InitializeComponent();
            pictureBox1.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[0]);
            pictureBox2.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[1]);
            pictureBox3.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();
        }

       


        private void button4_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 3) index = 0;
            pictureBox1.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 2]);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 2) index = 0;
            pictureBox1.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/Student/Desktop/b/-/ph/" + ImageList[index + 2]);
        }



    }

    



}
