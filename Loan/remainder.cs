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
    public partial class remainder : Form
    {
        public remainder()
        {
            InitializeComponent();
        }

        private void remainder_Load(object sender, EventArgs e)
        {
            //Rectangle wa = Screen.GetWorkingArea(this);
            //this.Location = new Point(wa.Right - Size.Width, wa.Bottom - Size.Height);

            clsConnection.open_connection();
            MySqlDataAdapter adpt3 = new MySqlDataAdapter("SELECT`loan_recolect`.`loan_id`AS LOAN_NUMBER,`loan_recolect`.`mem_name`AS MEMBER_NAME ,`reles_loan`.`center_name`AS CENTER_NAME,`loan_recolect`.`date_tody`AS LAST_ISTALL_DATE,`loan_recolect`.`installment`AS LAST_PAY_AMOUNT , DATEDIFF(CURDATE(),MAX(`loan_recolect`.`date_tody`)) AS DATE_DIFER,`reles_loan`.`date_A`AS LOAN_REL_DATE,`loan_recolect`.`deue` AS DEUE ,`reles_loan`.`statuse`AS STATUS  FROM `loan`.`reles_loan`INNER JOIN `loan`.`loan_recolect`ON (`reles_loan`.`loan_id` = `loan_recolect`.`loan_id`) GROUP BY `loan_recolect`.`loan_id` HAVING DATEDIFF(CURDATE(),MAX(`loan_recolect`.`date_tody`)) >='7' AND `reles_loan`.`statuse`= 'active'", clsConnection.con);
            DataTable table3 = new DataTable();
            adpt3.Fill(table3);
            if (table3.Rows.Count > 0)
            {
                dataGridView1.DataSource = table3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
