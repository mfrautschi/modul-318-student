namespace AdvancedTravel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.myUserControl1 = new AdvancedTravel.MyUserControl();
            this.mySearchField1 = new AdvancedTravel.MySearchField();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // myUserControl1
            // 
            this.myUserControl1.LabelText = "Endort";
            this.myUserControl1.Location = new System.Drawing.Point(46, 77);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(226, 143);
            this.myUserControl1.TabIndex = 1;
            // 
            // mySearchField1
            // 
            this.mySearchField1.FieldText = "";
            this.mySearchField1.Location = new System.Drawing.Point(73, 169);
            this.mySearchField1.Name = "mySearchField1";
            this.mySearchField1.Size = new System.Drawing.Size(542, 382);
            this.mySearchField1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 393);
            this.Controls.Add(this.mySearchField1);
            this.Controls.Add(this.myUserControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MyUserControl myUserControl1;
        private MySearchField mySearchField1;
    }
}