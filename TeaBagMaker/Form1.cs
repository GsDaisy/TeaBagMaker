using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        private int CountOrgNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("홍차");
            comboBox1.Items.Add("녹차");
            comboBox1.Items.Add("루이보스차");
            comboBox1.Items.Add("국화차");

            comboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String sel = comboBox1.SelectedItem.ToString();

            if (sel.Equals("홍차"))
            {

                this.CountOrgNum = 120;
                this.timer1.Enabled = true;
            }
            else if (sel.Equals("녹차"))
            {

                this.CountOrgNum = 180;
                this.timer1.Enabled = true;
            }
            else if (sel.Equals("루이보스차"))
            {

                this.CountOrgNum = 300;
                this.timer1.Enabled = true;
            }
            else 
            {

                this.CountOrgNum = 120;
                this.timer1.Enabled = true;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.CountOrgNum < 1)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCountDown.Text = "";

                this.comboBox1.Focus();
            }
            else
            {
                this.CountOrgNum = this.CountOrgNum - 1;
                int mi = CountOrgNum / 60;
                int se = CountOrgNum - (mi*60);

                if (mi == 0)
                {
                    this.txtCountDown.Text = se + "초 남았습니다.";
                }
                else
                {
                    //this.txtCountDown.Text = Convert.ToString(this.CountOrgNum);
                    this.txtCountDown.Text = mi + "분 " + se + "초 남았습니다.";
                }
            }
        }
    }
}
