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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Add_centers))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Add_centers();
            form.MdiParent = this;
            form.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Center_divaid_group))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Center_divaid_group();
            form.MdiParent = this;
            form.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(members_add))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new members_add();
            form.MdiParent = this;
            form.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Relese_Loan))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Relese_Loan();
            form.MdiParent = this;
            form.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Loan_colect))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Loan_colect();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Add_centers))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Add_centers();
            form.MdiParent = this;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Center_divaid_group))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Center_divaid_group();
            form.MdiParent = this;
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(members_add))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new members_add();
            form.MdiParent = this;
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Relese_Loan))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Relese_Loan();
            form.MdiParent = this;
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Loan_colect))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Loan_colect();
            form.MdiParent = this;
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            button2.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Loan_colect))
                {
                    f.Activate();
                    return;
                }
            }
        }

        private void createNewCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Add_centers))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Add_centers();
            form.MdiParent = this;
            form.Show();
        }

        private void createNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Center_divaid_group))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Center_divaid_group();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(members_add))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new members_add();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Relese_Loan))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Relese_Loan();
            form.MdiParent = this;
            form.Show();
        }

        private void addLoanInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Loan_colect))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new Loan_colect();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allMembersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loanDetailsByLoanNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void centerLoanDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(remainder))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new remainder();
            form.MdiParent = this;
            form.Show();
            //form.Location = new Point(917, 567);
            //Rectangle wa = Screen.GetWorkingArea(form);
            //form.Location = new Point(wa.Right - Size.Width, wa.Bottom - Size.Height);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
