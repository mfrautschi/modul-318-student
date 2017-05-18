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
        DateTime lastSelect;
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

        public DateTime LastSelect
        {
            get { return lastSelect; }
            set { lastSelect = value; }
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
            DateTime currTime;
            if (TimeUtils.checkTime(lastSelect, out currTime))
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
            setlastSelect(currTime);
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
            ValueToTextBox();
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                lstSearch.Focus();
            }  
        }

        private void lstSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                ValueToTextBox();
                CloseListBox();
            }
        }

        private void ValueToTextBox() {
            txtSearch.Text = lstSearch.SelectedItem.ToString();
            CloseListBox();
        }

        /// <summary>
        /// Sezt die lastTime variabel, die zur Zeitberechnung
        /// </summary>
        /// <param name="value"></param>
        public void setlastSelect(DateTime value) {
            lastSelect = value;
        }
    }
}
