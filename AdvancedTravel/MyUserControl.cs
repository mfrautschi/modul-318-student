using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedTravel
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value;  }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                listBox1.Visible = true;
                listBox1.Items.Add("eins");
                listBox1.Items.Add("zwei");
                listBox1.Items.Add("drei");
            }

        }
    }
}
