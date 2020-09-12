using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WooTable
{
    public partial class Form_Math_Sum : Form
    {
        public Form_Math_Sum()
        {
            InitializeComponent();
        }

        private void Form_Sum_but_Create_Click(object sender, EventArgs e)
        {
            try
            {

            }
            finally
            {
                this.Close();
            }
        }

        private void Form_Sum_but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
