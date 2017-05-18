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
    public partial class MySearchField : UserControl
    {
        public MySearchField()
        {
            InitializeComponent();
        }

        //ListBox
        public void ListBoxVisible(Boolean value)
        {
                lstSearch.Visible = value;
        }

        //Label
        public string LabelText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        public Point LabelLocation {
            get { return lblText.Location; }
            set { lblText.Location = value; }
        }

        //TextField
        public string TextFieldText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public Point TextFieldLocation
        {
            get{ return txtSearch.Location; }
            set{ txtSearch.Location = value; }  
        }

        public int TextFieldWidth
        {
            get { return txtSearch.Width; }
            set { txtSearch.Width = value; }
        }
        /// <summary>
        /// Mit dieser Funktion setzt man die Länge von Textfield, ListBox und dem UserControll.
        /// </summary>
        public void  AllWidth(int value)
        {
                this.Width = value;
                txtSearch.Width = value;
                lstSearch.Width = value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
                fillListBox();
            }
        }

        private void fillListBox()
        {
            lstSearch.Items.Clear();
            SwissTransport.Transport tp = new SwissTransport.Transport();
            SwissTransport.Stations stations = tp.GetStations(txtSearch.Text);
            foreach (SwissTransport.Station station in stations.StationList)
            {
                lstSearch.Items.Add(station.Name);
            }
            this.Height = 149;
            lstSearch.Visible = true;
        }

        private void MySearchField_Leave(object sender, EventArgs e)
        {
            CloseListBox();
        }

        public void CloseListBox()
        {
                this.Height = 65;
            lstSearch.Visible = false;
        }

        private void lstSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = lstSearch.SelectedItem.ToString();
            CloseListBox();
        }
    }
}
