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
    public partial class Relese_Loan : Form
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

        public Relese_Loan()
        {
            InitializeComponent();
        }

        private void Relese_Loan_Load(object sender, EventArgs e)
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
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Plase Select a Group ! ", "Warning !", MessageBoxButtons.OK);
            }
            else
            {
                clsConnection.open_connection();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM members WHERE `name` LIKE '%" + textBox1.Text + "%' AND `center_id`='"+cmbCenter.SelectedValue+"' AND `Group_id`='"+cmbGroup.SelectedValue+"'", clsConnection.con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        double polimudala;
        double fullPayment;
        double sathiwarikamudala;
        double poliMudala;
        double poliyaSahaLoan;

        private void txtLoneAmount_TextChanged(object sender, EventArgs e)
        {

            if (txtLoneAmount.TextLength > 1)
            {
                //sathiwarikamudala = (((Convert.ToDouble(txtLoneAmount.Text) / 100) * Convert.ToDouble(txtPoliAnupathaya.Text)) + Convert.ToDouble(txtLoneAmount.Text)) / Convert.ToDouble(txtWarikaGanan.Text);
                //txtSathiyatWarikaya.Text = sathiwarikamudala.ToString();
                //poliMudala = (Convert.ToDouble(txtSathiyatWarikaya.Text) * Convert.ToDouble(txtWarikaGanan.Text)) - Convert.ToDouble(txtLoneAmount.Text);
                //lblPoli_muda.Text = poliMudala.ToString();
                //poliyaSahaLoan = Convert.ToDouble(lblPoli_muda.Text) + Convert.ToDouble(txtLoneAmount.Text);
                //txtpoliyaSahaLoan.Text = poliyaSahaLoan.ToString();

                polimudala = (Convert.ToDouble(txtLoneAmount.Text) / 100 * Convert.ToDouble(txtPoliAnupathaya.Text))* Convert.ToDouble(txtWarikaGanan.Text);
                lblfulpament.Text = polimudala.ToString();
                //fullPayment = polimudala + Convert.ToDouble(txtLoneAmount.Text);
                fullPayment = Convert.ToDouble(lblfulpament.Text);
                sathiwarikamudala = fullPayment / Convert.ToDouble(txtWarikaGanan.Text);
                txtSathiyatWarikaya.Text = sathiwarikamudala.ToString();
                txtpoliyaSahaLoan.Text = fullPayment.ToString();


            }

        }

        int lastLoanNumber;
        int nowLoanNumber;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string memberid;
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    memberid = row.Cells[0].Value.ToString();
                    lblMemId.Text = row.Cells[0].Value.ToString();
                    lblname.Text = row.Cells[1].Value.ToString();
                    lbladdres.Text = row.Cells[2].Value.ToString();
                    lblNic.Text = row.Cells[3].Value.ToString();

                }
                
                clsConnection.open_connection();
                MySqlDataAdapter adpt1 = new MySqlDataAdapter("SELECT `loan_id` FROM `reles_loan` ORDER BY `loan_id` DESC LIMIT 1", clsConnection.con);
                DataTable table1 = new DataTable();
                adpt1.Fill(table1);

                int lastLoanNumber;
                if (table1.Rows.Count > 0)
                {
                    lastLoanNumber =table1.Rows[0].Field<int>(0);
                    nowLoanNumber = lastLoanNumber + 1;
                    txtLoanNumber.Text = nowLoanNumber.ToString();
                    //MessageBox.Show(lastLoanNumber.ToString());
                }
                else
                {
                    txtLoanNumber.Text = "1";
                }


                clsConnection.open_connection();
                MySqlDataAdapter adpt2 = new MySqlDataAdapter("SELECT `loan_id` AS LOAN_ID,`memeber_name`AS MEMBER_NAME,`loan_amount` AS LOAN_AMOUNT,`sathi_warikaya`AS WEEK_INS,`date_A`AS LOAN_DATE FROM `reles_loan` WHERE `member_id`='" + lblMemId.Text + "'  AND `statuse`= 'active'", clsConnection.con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    dataGridView2.DataSource = table2;
                }
                else
                {
                    MessageBox.Show("This member's first loan", "", MessageBoxButtons.OK);
                    //txtLoanNumber.Text = "1";
                }

                
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLoanNumber.Text == string.Empty)
            {
                MessageBox.Show("Enter Loan Number !", "", MessageBoxButtons.OK);
            }
            else if (txtDocument.Text == string.Empty)
            {
                MessageBox.Show("Enter Document Number !", "", MessageBoxButtons.OK);
            }
            else if (txtLoneAmount.Text == string.Empty)
            {
                MessageBox.Show("Enter Loan Amount !", "", MessageBoxButtons.OK);
            }
            else if (txtPoliAnupathaya.Text == string.Empty)
            {
                MessageBox.Show("Enter Interest Rate !", "", MessageBoxButtons.OK);
            }
            else if (txtWarikaGanan.Text == string.Empty)
            {
                MessageBox.Show("Enter Number of installments !", "", MessageBoxButtons.OK);
            }
            else if (txtSathiyatWarikaya.Text == string.Empty)
            {
                MessageBox.Show("Enter Weekly installment !", "", MessageBoxButtons.OK);
            }
            else
            {
                clsConnection.open_connection();
                using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO reles_loan(loan_id,center_id,center_name,group_id,group_name,member_id,memeber_name,member_nic,doc_pepar_no,num_of_warika,poli_anupathaya,loan_amount,sathi_warikaya,statuse,date_A ,mulu_mudala) VALUES (@loan_id,@center_id,@center_name,@group_id,@group_name,@member_id,@memeber_name,@member_nic,@doc_pepar_no,@num_of_warika,@poli_anupathaya,@loan_amount,@sathi_warikaya,@statuse,CURDATE(),@mulu_mudala)", clsConnection.con))
                {
                    sqlcomd.Parameters.Clear();
                    sqlcomd.Parameters.AddWithValue("@loan_id", txtLoanNumber.Text);
                    sqlcomd.Parameters.AddWithValue("@center_id", cmbCenter.SelectedValue);
                    sqlcomd.Parameters.AddWithValue("@center_name", cmbCenter.Text);
                    sqlcomd.Parameters.AddWithValue("@group_id", cmbGroup.SelectedValue);
                    sqlcomd.Parameters.AddWithValue("@group_name", cmbGroup.Text);
                    sqlcomd.Parameters.AddWithValue("@member_id", lblMemId.Text);
                    sqlcomd.Parameters.AddWithValue("@memeber_name", lblname.Text);
                    sqlcomd.Parameters.AddWithValue("@member_nic", lblNic.Text);
                    sqlcomd.Parameters.AddWithValue("@doc_pepar_no", txtDocument.Text);
                    sqlcomd.Parameters.AddWithValue("@num_of_warika", txtWarikaGanan.Text);
                    sqlcomd.Parameters.AddWithValue("@poli_anupathaya", txtPoliAnupathaya.Text);
                    sqlcomd.Parameters.AddWithValue("@loan_amount", txtLoneAmount.Text);
                    sqlcomd.Parameters.AddWithValue("@sathi_warikaya", txtSathiyatWarikaya.Text);
                    sqlcomd.Parameters.AddWithValue("@statuse", "active");
                    sqlcomd.Parameters.AddWithValue("@mulu_mudala", txtpoliyaSahaLoan.Text);
                    sqlcomd.ExecuteNonQuery();
                }
                MessageBox.Show("Issue of loans was successful !", "", MessageBoxButtons.OK);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCenter.SelectedIndex == -1)
            {
                MessageBox.Show("Plase Select Center !", "", MessageBoxButtons.OK);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //clsConnection.open_connection();
            //MySqlDataAdapter adpt2 = new MySqlDataAdapter("", clsConnection.con);
            //DataTable table2 = new DataTable();
            //adpt2.Fill(table2);
            //if (table2.Rows.Count > 0)
            //{
            //    dataGridView2.DataSource = table2;
            //}
            //else
            //{
            //    MessageBox.Show("This member's first loan", "", MessageBoxButtons.OK);
            //}
        }

        private void cmbCenter_Leave(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT group_id,group_name FROM centers_groups WHERE center_id='" + cmbCenter.SelectedValue + "'", clsConnection.con))
            {
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    cmbGroup.DisplayMember = "group_name";
                    cmbGroup.ValueMember = "group_id";
                    cmbGroup.DataSource = dt1;
                    cmbGroup.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("There are no groups for this ! ", "Warning !", MessageBoxButtons.OK);

                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = -1;
            cmbCenter.SelectedIndex = -1;
            textBox1.Clear();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            lblMemId.Text = "";
            lblname.Text = "N/A";
            lbladdres.Text = "N/A";
            lblNic.Text = "N/A";
            txtLoanNumber.Clear();
            txtDocument.Clear();
            txtLoanNumber.Clear();
            txtLoneAmount.Clear();
            txtWarikaGanan.Clear();
            txtPoliAnupathaya.Clear();
            txtSathiyatWarikaya.Clear();
            cmbCenter.Focus();
        }

        private void txtWarikaGanan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPoliAnupathaya_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLoneAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSathiyatWarikaya_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLoneAmount_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPoliAnupathaya_TextChanged(object sender, EventArgs e)
        {
            if (txtWarikaGanan.TextLength > 0 && txtPoliAnupathaya.TextLength > 0)
            {
                txtLoneAmount.Enabled = true ;
            }

            else
            {
                txtLoneAmount.Enabled = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
