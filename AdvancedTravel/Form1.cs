using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AdvancedTravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            String textvalue = txtFrom.Text;
            txtFrom.Text = txtTo.Text;
            txtTo.Text = textvalue;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.BackColor = SystemColors.MenuHighlight;
            btnOff.BackColor = SystemColors.Window;
        }
        
        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOff.BackColor = SystemColors.MenuHighlight;
            btnOn.BackColor = SystemColors.Window;
        }
    }
}
