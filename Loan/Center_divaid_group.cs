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
    public partial class Center_divaid_group : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
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
        public Center_divaid_group()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Center_divaid_group_Load(object sender, EventArgs e)
        {
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
                else
                {
                    MessageBox.Show("Plece Add a center frit ...Go To <Add Centers Form>", "Warning !", MessageBoxButtons.OK);
                    //this.Close();
                }
            }

        }

        private void cmbCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConnection.open_connection();
            MySqlDataAdapter adpt2 = new MySqlDataAdapter("SELECT `group_name` FROM `centers_groups` WHERE `center_id`='" + cmbCenter.SelectedValue+"' ", clsConnection.con);
            DataTable table2 = new DataTable();
            adpt2.Fill(table2);
            if (table2.Rows.Count > 0)
            {
                dataGridView1.DataSource = table2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCenter.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Center !", "", MessageBoxButtons.OK);
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter Group Name !", "", MessageBoxButtons.OK);
            }
           else
            {
                clsConnection.open_connection();
                using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO centers_groups(center_id,center_name,group_name)VALUES(@center_id,@center_name,@group_name)", clsConnection.con))
                {
                    sqlcomd.Parameters.Clear();
                    sqlcomd.Parameters.AddWithValue("@center_id", cmbCenter.SelectedValue);
                    sqlcomd.Parameters.AddWithValue("@center_name", cmbCenter.Text);
                    sqlcomd.Parameters.AddWithValue("@group_name", textBox1.Text);
                    sqlcomd.ExecuteNonQuery();
                }
                MessageBox.Show("Aded Sucsesfuly !", "", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            cmbCenter.SelectedIndex = -1;
            textBox1.Clear();
        }
    }
}
