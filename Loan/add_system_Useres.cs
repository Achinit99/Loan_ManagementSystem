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
using Tulpep.NotificationWindow;

namespace Loan
{
    public partial class add_system_Useres : Form
    {
        public add_system_Useres()
        {
            InitializeComponent();
        }
        WebCam webcam;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void add_system_Useres_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void bntCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsConnection.open_connection();
            using (MySqlCommand sqlcomd = new MySqlCommand("INSERT INTO centers(location)VALUES(@location)", clsConnection.con))
            {
                //sqlcomd.Parameters.Clear();
                //sqlcomd.Parameters.AddWithValue("@location", txtCenter.Text);
                //sqlcomd.ExecuteNonQuery();
            }
            MessageBox.Show("Aded Sucsesfuly !", "", MessageBoxButtons.OK);
        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            if(txtpassword1.Text == txtpassword2.Text  )
            {
                txtpassword2.ForeColor = Color.Green;
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;
                popup.TitleText = "Sucsesfuly";
                popup.ContentText = "Password maching Complite !";
                popup.Popup();
            }
            else if (txtpassword1.TextLength == txtpassword2.TextLength && txtpassword1.Text != txtpassword2.Text)
            {
                txtpassword2.ForeColor = Color.Red;
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;
                popup.TitleText = "Sucsesfuly";
                popup.ContentText = "Password not maching !";
                popup.Popup();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cmb_item_name_TextChanged(object sender, EventArgs e)
        {
            //if (cmb_item_name.Text != "" && cmb_item_name.Text.Length > 1)
            //{
            //    lst_items.Show();
            //    lst_items.Width = 605;
            //    using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT index_no,skt_id,SERIAL,grn_no FROM item_serials WHERE  SERIAL LIKE @ser", cls_Connection.con))
            //    {
            //        da.SelectCommand.Parameters.Clear();
            //        da.SelectCommand.Parameters.AddWithValue("@ser", "%" + cmb_item_name.Text + "%");
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            lst_items.data
            //            _dgv_serials.DataSource = null;
            //            _dgv_serials.DataSource = dt;
            //            _dgv_serials.AutoGenerateColumns = false;
            //        }

            //    }
            //}
            //else if (cmb_item_name.Text.Length == 0)
            //{
            //    lst_items.Items.Clear();
            //    cmb_item_name.Text = string.Empty;
            //    lst_items.Hide();
            //}

        }
    }
}
