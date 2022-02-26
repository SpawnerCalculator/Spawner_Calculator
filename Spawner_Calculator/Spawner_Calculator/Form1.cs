using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spawner_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal decPrice1, decPrice2, decPrice3;
            decimal decAmount1, decAmount2, decAmount3;
            decimal decSell1, decSell2, decSell3;
            decimal decMpd1, decMpd2, decMpd3;

            decPrice1 = Convert.ToDecimal(txtPrice1.Text);
            decPrice2 = Convert.ToDecimal(txtPrice2.Text);
            decPrice3 = Convert.ToDecimal(txtPrice3.Text);
            
            decAmount1 = Convert.ToDecimal(txtAmount1.Text);
            decAmount2 = Convert.ToDecimal(txtAmount2.Text);
            decAmount3 = Convert.ToDecimal(txtAmount3.Text);

            decSell1 = Convert.ToDecimal(txtSell1.Text);
            decSell2 = Convert.ToDecimal(txtSell2.Text);
            decSell3 = Convert.ToDecimal(txtSell3.Text);

            decMpd1 = decSell1 * decAmount1;
            decMpd2 = decSell2 * decAmount2;
            decMpd3 = decSell3 * decAmount3;

            lblMps1.Text = Convert.ToString(decMpd1 * 1000);
            lblMps2.Text = Convert.ToString(decMpd2 * 1000);
            lblMps3.Text = Convert.ToString(decMpd3 * 1000);

            lblSps1.Text = Convert.ToString(decPrice1 / decMpd1);
            lblSps2.Text = Convert.ToString(decPrice2 / decMpd2);
            lblSps3.Text = Convert.ToString(decPrice3 / decMpd3);
        }
    }
}
