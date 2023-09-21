using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMmaytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string phepTinh;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienThi.Text = hienThi.Text + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienThi.Clear();
            hienThi2.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (phepTinh == "cong")
            {
                data2 = data1 + float.Parse(hienThi.Text);
                hienThi.Text = data2.ToString();
            }
            if (phepTinh == "tru")
            {
                data2 = data1 - float.Parse(hienThi.Text);
                hienThi.Text = data2.ToString();
            }
            if (phepTinh == "nhan")
            {
                data2 = data1 * float.Parse(hienThi.Text);
                hienThi.Text = data2.ToString();
            }
            if (phepTinh == "chia")
            {
                if (float.Parse(hienThi.Text)==0)
                {
                    hienThi.Text = "khong chia duoc";
                }
                else
                {
                    data2 = data1 / float.Parse(hienThi.Text);
                    hienThi.Text = data2.ToString();
                }
            
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            phepTinh = "tru";
            data1 = float.Parse(hienThi.Text);
            hienThi2.Text = data1.ToString() + "-";
            hienThi.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            phepTinh = "nhan";
            data1 = float.Parse(hienThi.Text);
            hienThi2.Text = data1.ToString() + "*";
            hienThi.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            phepTinh = "chia";
            data1 = float.Parse(hienThi.Text);
            hienThi2.Text = data1.ToString() + "/";
            hienThi.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            phepTinh = "cong";
            data1 = float.Parse(hienThi.Text);
            hienThi2.Text = data1.ToString() + "+";
            hienThi.Clear();
        }
    }
}
