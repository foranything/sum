using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            int num1 = 10;
            int num2 = 2;
            int sum = num1 + num2;
            label1.Text = sum.ToString();
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            if (String.IsNullOrWhiteSpace(sum1.Text) || String.IsNullOrWhiteSpace(sum2.Text) || !int.TryParse(sum1.Text, out num1) || !int.TryParse(sum2.Text, out num2))
            {
                MessageBox.Show("숫자를 입력해 주세요");
            }
            else
            {
                sumResult.Text = Add(num1, num2).ToString();
            }

        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}
