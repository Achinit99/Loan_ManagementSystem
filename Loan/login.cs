using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Plese Enter User Name", "", MessageBoxButtons.OK);
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Plese Enter Password", "", MessageBoxButtons.OK);
            }
            else
            {
                clsConnection.open_connection();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT user_name,Password FROM users WHERE user_name='"+textBox1.Text+"' AND Password='"+textBox2.Text+"' ", clsConnection.con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    main myForm = new main();
                    myForm.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("User Name Or Password is Incorrect..","", MessageBoxButtons.OK);
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
