using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace examination_system
{
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;
        public static string Username;
        public static string imgPath;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Server=DESKTOP-ROH2RC0; Database=examnation system; user=sa; password=Bb606@ali");
            sqlConnection.Open();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false; 
            panel2.Visible = false; 
            wronglabel.Visible = false; 
        }

        private void txtSelectuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectuser.SelectedIndex == 0)
            { 
                panel1.Visible=true;
                panel2.Visible=false;
            
            }
            else if(txtSelectuser.SelectedIndex == 1)
            {
                panel2.Visible=true;
                panel1.Visible=false;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowHide.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtpassword.PasswordChar = '*';
                checkBoxShowHide.Text = "show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = "", p="";
            sqlCommand = new SqlCommand("SELECT * FROM login where username='"+ txtUsername.Text + "' and password='"+ txtpassword.Text + "'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.HasRows)
            {
                Username = txtUsername.Text;
                sqlDataReader.Read();
                imgPath = (string)sqlDataReader["imgPath"];
                wronglabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();

            }
            else
            {
                wronglabel.Visible = true; 
            }
            
        }
    }
}
