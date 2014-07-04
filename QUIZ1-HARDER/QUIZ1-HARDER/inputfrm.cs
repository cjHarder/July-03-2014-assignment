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
    public partial class inputfrm : Form
    {
        public inputfrm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIn.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dli pde mag.add"+ ex);
            }

            

        }

        
    }
}
