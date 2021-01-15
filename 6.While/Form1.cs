using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _6.While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            while (MessageBox.Show("Valitse Yes jatkaaksesi tai No lopettaaksesi","Huom!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              
            }
            Close();
            
        }

        private void While(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
