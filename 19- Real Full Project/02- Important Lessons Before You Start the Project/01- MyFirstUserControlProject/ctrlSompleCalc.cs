using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstUserControlProject
{
    public partial class ctrlSompleCalc : UserControl
    {
        public ctrlSompleCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResults.Text = (int.Parse( textBox2.Text) + int.Parse(textBox2.Text)).ToString();

        }
    }
}
