using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startNum;
        int endNum;

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                startNum = Convert.ToInt16(startNumInput.Text);
                endNum = Convert.ToInt16(endNumInput.Text);

                outputLabel.Text = "";

                for (int num = startNum; num <= endNum; num++)
                {
                    outputLabel.Text += " " + num;
                }
            }
            catch
            {
                outputLabel.Text = "Invalid number entered";
            }
        }
    }
}
