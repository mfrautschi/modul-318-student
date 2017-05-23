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
    public partial class mySearchField : UserControl
    {
        DateTime lastSelect;
        public mySearchField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setzt ie ListBox auf Sichtbar oder Unsichtbar.
        /// </summary>
        /// <param name="value"></param>
        public void ListBoxVisible(Boolean value)
        {
                lstSearch.Visible = value;
        }

        /// <summary>
        /// Setzt den LabelText.
        /// </summary>
        public string LabelText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        /// <summary>
        /// Gibt den Wert des Textfeldes zurück. Setzt den Wert des Textfeldes.
        /// </summary>
        public string TextFieldText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        /// <summary>
        /// Gibt die LastSelect Variable zurück. (Wird zur Requestzeitberechnung verwendet)
        /// </summary>
        public DateTime LastSelect
        {
            get { return lastSelect; }
            set { lastSelect = value; }
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

        /// <summary>
        /// Schliesst die ListBox
        /// </summary>
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
        /// Setzt die Zeit, für die Request berechnung. (Nicht mehr als 3 Requests pro Sekunde)
        /// </summary>
        /// <param name="value"></param>
        public void setlastSelect(DateTime value) {
            lastSelect = value;
        }
    }
}
