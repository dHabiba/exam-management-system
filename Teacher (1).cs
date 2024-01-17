using examination_system.teacher_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examination_system
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            label3.Text = Form1.Username;
            pictureBox2.ImageLocation = Form1.imgPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_AddNewClasses11.Visible = false;
            uc_marks1.Visible = false;
            updatemarks1.Visible = false;
            reports1.Visible = false;
        }

        private void btnaddnewsubject_Click(object sender, EventArgs e)
        {
            uC_AddNewClasses11.Visible = true;
            uC_AddNewClasses11.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            uc_marks1.Visible = true; 
            uc_marks1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatemarks1.Visible = true;
            updatemarks1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reports1.Visible = true;
            reports1.BringToFront();    

        }
    }
}
