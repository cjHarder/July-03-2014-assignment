using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ1_HARDER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            inputfrm callMe = new inputfrm();
            callMe.ShowDialog();

            int b = Convert.ToInt16(callMe.txtIn.Text) + Convert.ToInt16(btnView.Text);
            btnView.Text = b.ToString();

         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnView.Text = "0";
            
        }
    }
}
