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
    public partial class Loan_colect : Form
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

        public Loan_colect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,name FROM members WHERE center_id='"+cmbCenter.SelectedValue+"' AND Group_id='"+cmbGroup.SelectedValue+"'", clsConnection.con))
            {
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    cmbCenter.DisplayMember = "name";
                    cmbCenter.ValueMember = "id";
                    cmbCenter.DataSource = dt1;
                    cmbCenter.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("There are no members in this group", "Warning !", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void Loan_colect_Load(object sender, EventArgs e)
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
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT group_id,group_name FROM centers_groups WHERE center_id='"+cmbCenter.SelectedValue+"'", clsConnection.con))
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
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clsConnection.open_connection();
            //MySqlDataAdapter adpt2 = new MySqlDataAdapter("SELECT loan_id,name,date,installment,deue FROM loan_recolect WHERE mem_id='"+cmbName.SelectedValue+"' AND states='active' ", clsConnection.con);
            //DataTable table2 = new DataTable();
            //adpt2.Fill(table2);
            //if (table2.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = table2;

            //    using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT loan_id,id,date,installment,deue FROM loan_recolect WHERE mem_id='" + cmbName.SelectedValue + "' AND states='active'" + cmbCenter.SelectedValue + "'", clsConnection.con))
            //    {
            //        DataTable dt1 = new DataTable();
            //        da.Fill(dt1);
            //        if (dt1.Rows.Count > 0)
            //        {
            //            cmbLoanNumber.DisplayMember = "group_name";
            //            cmbLoanNumber.ValueMember = "id";
            //            cmbLoanNumber.DataSource = dt1;
            //            cmbLoanNumber.SelectedIndex = -1;

            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This member's first loan", "", MessageBoxButtons.OK);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbCenter.SelectedIndex == -1)
            {
                MessageBox.Show("Plase select center", "", MessageBoxButtons.OK);
            }
            else if (cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Plase select Group", "", MessageBoxButtons.OK);
            }
            else if (cmbName.SelectedIndex == -1)
            {
                MessageBox.Show("Plase select Name", "", MessageBoxButtons.OK);
            }
            
            else
            {
                clsConnection.open_connection();
                MySqlDataAdapter adpt2 = new MySqlDataAdapter("SELECT loan_id AS LOAN_ID,`date_A` AS LOAN_DATE,`memeber_name`AS MEMBER_NAME,`loan_amount`AS LOAN_AMOUNT,`member_nic`AS MEMBER_NIC,`statuse` AS STATUSE FROM reles_loan WHERE member_id ='" + cmbName.SelectedValue + "' AND `statuse`= 'active' ORDER BY loan_id DESC", clsConnection.con);
                DataTable table2 = new DataTable();
                adpt2.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table2;
                    using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT loan_id,id FROM reles_loan WHERE member_id ='" + cmbName.SelectedValue + "' AND `statuse`= 'active' ORDER BY loan_id DESC", clsConnection.con))
                    {
                        DataTable dt1 = new DataTable();
                        da.Fill(dt1);
                        if (dt1.Rows.Count > 0)
                        {
                            cmbLoanNumber.DisplayMember = "loan_id";
                            cmbLoanNumber.ValueMember = "id";
                            cmbLoanNumber.DataSource = dt1;
                            cmbLoanNumber.SelectedIndex = -1;

                        }

                    }

                }
                else
                {
                    MessageBox.Show("This member's first loan and first installment", "", MessageBoxButtons.OK);
                }
            }
           
            



        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtpaid_amount.TextLength >= 1)
            {

                double sathiWarikaya_aduGana;
                sathiWarikaya_aduGana = Convert.ToDouble(lblNext_instalment.Text) - Convert.ToDouble(txtpaid_amount.Text);
                lbl_now_due.Text = sathiWarikaya_aduGana.ToString("N2");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpaid_amount.Text == string.Empty)
            {
                MessageBox.Show("Plase Ener Paid Amount", "", MessageBoxButtons.OK);
            }
            //else
            //{
            //    clsConnection.open_connection();
            //    MySqlDataAdapter adpt1 = new MySqlDataAdapter("SELECT DATEDIFF(CURDATE(),`date_tody`)AS dated FROM `loan_recolect` WHERE  `loan_id`='"+cmbLoanNumber.Text+ "' AND `mem_name`='"+cmbName.Text+"' ORDER BY `date_tody` DESC LIMIT 1", clsConnection.con);
            //    DataTable table1 = new DataTable();
            //    adpt1.Fill(table1);
                
            //    //label7.Text = (table1.Rows[0].Field<string>(0));
                
            //    if ((table1.Rows[0].Field<Int32>(0))>= 8)
            //    {
            //        clsConnection.open_connection();
            //        using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO loan_recolect (loan_id,mem_id,mem_name,caenter_id,date_tody,installment,deue,marks) VALUES (@loan_id,@mem_id,@mem_name,@caenter_id,CURDATE(),@installment,@deue,@marks)", clsConnection.con))
            //        {
            //            sqlcomd.Parameters.Clear();
            //            sqlcomd.Parameters.AddWithValue("@loan_id", cmbLoanNumber.SelectedValue);
            //            sqlcomd.Parameters.AddWithValue("@mem_id", cmbName.SelectedValue);
            //            sqlcomd.Parameters.AddWithValue("@mem_name", cmbName.Text);
            //            sqlcomd.Parameters.AddWithValue("@caenter_id", cmbCenter.SelectedValue);
            //            sqlcomd.Parameters.AddWithValue("@installment", txtpaid_amount.Text);
            //            sqlcomd.Parameters.AddWithValue("@deue", lbl_now_due.Text);
            //            sqlcomd.Parameters.AddWithValue("@marks", "bad");
            //            sqlcomd.ExecuteNonQuery();
            //        }



            //        if (Convert.ToInt32(lblSum_installment.Text) >= Convert.ToInt32(lblLoneAmount.Text))
            //        {
            //            clsConnection.open_connection();
            //            using (MySqlCommand sqlcomd = new MySqlCommand("UPDATE (statuse,over_date) VALUE (@statuse,CURSOR()) FROM reles_loan  WHERE loan_id ='" + cmbLoanNumber.Text + "' ", clsConnection.con))
            //            {
            //                sqlcomd.Parameters.Clear();
            //                sqlcomd.Parameters.AddWithValue("@statuse", "inactive");
            //                sqlcomd.ExecuteNonQuery();

            //                MessageBox.Show("All payments complete!", "", MessageBoxButtons.OK);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show(" Installment Colect was successful !", "", MessageBoxButtons.OK);
            //        }
            //    }

                else
                {
                    clsConnection.open_connection();
                    using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO loan_recolect (loan_id,mem_id,mem_name,caenter_id,date_tody,installment,deue) VALUES (@loan_id,@mem_id,@mem_name,@caenter_id,CURDATE(),@installment,@deue)", clsConnection.con))
                    {
                        sqlcomd.Parameters.Clear();
                        sqlcomd.Parameters.AddWithValue("@loan_id", cmbLoanNumber.SelectedValue);
                        sqlcomd.Parameters.AddWithValue("@mem_id", cmbName.SelectedValue);
                        sqlcomd.Parameters.AddWithValue("@mem_name", cmbName.Text);
                        sqlcomd.Parameters.AddWithValue("@caenter_id", cmbCenter.SelectedValue);
                        sqlcomd.Parameters.AddWithValue("@installment", txtpaid_amount.Text);
                        sqlcomd.Parameters.AddWithValue("@deue", lbl_now_due.Text);
                            sqlcomd.ExecuteNonQuery();
                    }



                    if (Convert.ToInt32(lblSum_installment.Text) >= Convert.ToInt32(lblLoneAmount.Text))
                    {
                        clsConnection.open_connection();
                        using (MySqlCommand sqlcomd = new MySqlCommand("UPDATE (statuse,over_date) VALUE (@statuse,CURSOR()) FROM reles_loan  WHERE loan_id ='" + cmbLoanNumber.Text + "' ", clsConnection.con))
                        {
                            sqlcomd.Parameters.Clear();
                            sqlcomd.Parameters.AddWithValue("@statuse", "inactive");
                            sqlcomd.ExecuteNonQuery();

                            MessageBox.Show("All payments complete!", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Installment Colect was successful !", "", MessageBoxButtons.OK);
                    }
                }


            cmbLoanNumber.SelectedIndex = -1;
            txtpaid_amount.Text = "0.00";
            cmbName.SelectedIndex = -1;
            
            dataGridView1.Refresh();
            
            dataGridView2.Refresh();
            cmbLoanNumber.SelectedIndex = -1;
            cmbName.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCenter_SelectedIndexChanged_1(object sender, EventArgs e)
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
                //else
                //{
                //    MessageBox.Show("There are no groups for this ! ", "Warning !", MessageBoxButtons.OK);
                    
                //}
            }
        }

        private void cmbGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,name FROM members WHERE center_id='" + cmbCenter.SelectedValue + "' AND Group_id='" + cmbGroup.SelectedValue + "'", clsConnection.con))
            {
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    cmbName.DisplayMember = "name";
                    cmbName.ValueMember = "id";
                    cmbName.DataSource = dt1;
                    cmbName.SelectedIndex = -1;

                }
                //else
                //{
                //    MessageBox.Show("There are no Members for this ! ", "Warning !", MessageBoxButtons.OK);
                    
                //}
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoanNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbLoanNumber_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbLoanNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (cmbLoanNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Plese Select Loan Number ! ", "Warning !", MessageBoxButtons.OK);
            }
            else
            {
                int installSum;
                int NewloanAmount;
                double meparaGevima;


                clsConnection.open_connection();
                MySqlDataAdapter adpt4 = new MySqlDataAdapter("SELECT `num_of_warika`,`mulu_mudala`,`sathi_warikaya` FROM `reles_loan` WHERE `loan_id`='" + cmbLoanNumber.Text + "' AND memeber_name ='"+ cmbName .Text+ "' AND center_name ='"+ cmbCenter .Text+ "' ", clsConnection.con);
                DataTable table4 = new DataTable();
                adpt4.Fill(table4);
                if (table4.Rows.Count > 0)
                {
                    lblLoneAmount.Text = table4.Rows[0]["mulu_mudala"].ToString();
                    lblSathiWarikaya.Text = table4.Rows[0]["sathi_warikaya"].ToString();



                }

                clsConnection.open_connection();
                MySqlDataAdapter adpt31 = new MySqlDataAdapter("SELECT IFNULL( SUM(installment),0) AS muluGewima FROM loan_recolect WHERE loan_id='" + cmbLoanNumber.Text + "' ", clsConnection.con);
                DataTable table31 = new DataTable();
                adpt31.Fill(table31);
                if (table31.Rows.Count > 0)
                {
                    installSum = Convert.ToInt32(table31.Rows[0]["muluGewima"].ToString());
                    lblSum_installment.Text = installSum.ToString();
                    NewloanAmount = Convert.ToInt32(lblLoneAmount.Text) - Convert.ToInt32(lblSum_installment.Text);
                    lblNewLoan_Amount.Text = NewloanAmount.ToString("N2");
                }

                clsConnection.open_connection();
                MySqlDataAdapter adpt3 = new MySqlDataAdapter("SELECT `mem_id` AS MEMBER_ID,`mem_name`AS MEMBER_NAME,`date_tody`AS INST_DATE,`installment`AS INSTALLMENT,`deue`AS DEUE FROM `loan_recolect` WHERE `loan_id`='" + cmbLoanNumber.Text + "'  ORDER BY `date_tody` DESC ", clsConnection.con);
                DataTable table3 = new DataTable();
                adpt3.Fill(table3);
                if (table3.Rows.Count > 0)
                {
                    dataGridView2.DataSource = table3;

                    clsConnection.open_connection();
                    MySqlDataAdapter adpt8 = new MySqlDataAdapter("SELECT `deue` FROM `loan_recolect` WHERE `loan_id`='" + cmbLoanNumber.Text + "'  ORDER BY `id` DESC LIMIT 1 ", clsConnection.con);
                    DataTable table8 = new DataTable();
                    adpt8.Fill(table8);
                    if (table8.Rows.Count > 0)

                        lblLast_ins_DUE.Text = table8.Rows[0]["deue"].ToString();




                }
                meparaGevima = Convert.ToDouble(lblLast_ins_DUE.Text) + Convert.ToDouble(lblSathiWarikaya.Text);
                lblNext_instalment.Text = meparaGevima.ToString("N2");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

    }

