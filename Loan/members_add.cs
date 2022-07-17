
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    public partial class members_add : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private int childFormNumber = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public members_add()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            clsConnection.open_connection();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT id FROM members ORDER BY id DESC LIMIT 1", clsConnection.con);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>(0);
                int last = id + 1;
                txt_id.Text = last.ToString();
            }
            else
            {
                txt_id.Text = "1";
            }

            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,location FROM centers", clsConnection.con))
            {
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    cmbCenter.DisplayMember = "location";
                    cmbCenter.ValueMember = "id";
                    cmbCenter.DataSource = dt1;
                    cmbCenter.SelectedIndex = -1;

                }
                //else
                //{
                //    MessageBox.Show("Plece Add a center frit ...Go To <Add Centers Form>", "Warning !", MessageBoxButtons.OK);
                //   // this.Close();
                //}

               
            }
        }
        public void clean_all()
        {
            txt_name.Clear();
            txt_addres.Clear();
            txt_nic.Clear();
            txt_job.Clear();
            txt_mob.Clear();
            txt_home.Clear();
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == string.Empty)
            {
                MessageBox.Show("Plece Enter Name", "Warning !", MessageBoxButtons.OK);
            }
            else if (txt_addres.Text == string.Empty)
            {
                MessageBox.Show("Plece Enter Addres", "Warning !", MessageBoxButtons.OK);
            }
            else if (txt_nic.Text == string.Empty)
            {
                MessageBox.Show("Plece Enter NIC Number", "Warning !", MessageBoxButtons.OK);
            }
            else if (txt_mob.Text == string.Empty)
            {
                MessageBox.Show("Plece Enter Mobile Number", "Warning !", MessageBoxButtons.OK);
            }
            else
           {
                clsConnection.open_connection();
                using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO members(name,addres,nic,job,mobile,home_number,center_id,Group_id)VALUES( @name,@addres,@nic,@job,@mobile,@home_number,@center_id,@Group_id)", clsConnection.con))
                {
                    sqlcomd.Parameters.Clear();
                    sqlcomd.Parameters.AddWithValue("@name", txt_name.Text);
                    sqlcomd.Parameters.AddWithValue("@addres", txt_addres.Text);
                    sqlcomd.Parameters.AddWithValue("@nic", txt_nic.Text);
                    sqlcomd.Parameters.AddWithValue("@job", txt_job.Text);
                    sqlcomd.Parameters.AddWithValue("@mobile", txt_mob.Text);
                    sqlcomd.Parameters.AddWithValue("@home_number", txt_home.Text);
                    sqlcomd.Parameters.AddWithValue("@center_id", cmbCenter.SelectedValue);
                    sqlcomd.Parameters.AddWithValue("@Group_id", cmbGroup.SelectedValue);
                    sqlcomd.ExecuteNonQuery();

                    MessageBox.Show("New Member Aded Sucsesfully !", "Sucses!", MessageBoxButtons.OK);
                    clean_all();
                    this.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean_all();
            this.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT group_id,group_name FROM centers_groups WHERE center_name = '"+cmbCenter.Text+"'", clsConnection.con))
            {
                DataTable dt2 = new DataTable();
                da1.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    cmbGroup.DisplayMember = "group_name";
                    cmbGroup.ValueMember = "group_id";
                    cmbGroup.DataSource = dt2;
                    cmbGroup.SelectedIndex = -1;

                }
                else
                {
                    //MessageBox.Show("Plece Divaid to Group this Center ...Go To <Center Divaid Form>", "Warning !", MessageBoxButtons.OK);
                    //this.Close();
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
