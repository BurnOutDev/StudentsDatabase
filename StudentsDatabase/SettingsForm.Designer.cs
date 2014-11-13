namespace StudentsDatabase
{
    partial class SettingsForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mTabCities = new MetroFramework.Controls.MetroTabPage();
            this.mTabStudents = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroPanel1.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.mTabCities.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mTabControl);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(396, 280);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "შავი",
            "თეთრი"});
            this.metroComboBox1.Location = new System.Drawing.Point(3, 24);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "თემა";
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.mTabCities);
            this.mTabControl.Controls.Add(this.mTabStudents);
            this.mTabControl.Location = new System.Drawing.Point(3, 59);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(390, 218);
            this.mTabControl.TabIndex = 4;
            this.mTabControl.UseSelectable = true;
            // 
            // mTabCities
            // 
            this.mTabCities.Controls.Add(this.metroTrackBar1);
            this.mTabCities.Controls.Add(this.metroLabel3);
            this.mTabCities.Controls.Add(this.metroComboBox2);
            this.mTabCities.Controls.Add(this.metroLabel2);
            this.mTabCities.HorizontalScrollbarBarColor = true;
            this.mTabCities.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabCities.HorizontalScrollbarSize = 10;
            this.mTabCities.Location = new System.Drawing.Point(4, 38);
            this.mTabCities.Name = "mTabCities";
            this.mTabCities.Size = new System.Drawing.Size(382, 176);
            this.mTabCities.TabIndex = 0;
            this.mTabCities.Text = "ქალაქები";
            this.mTabCities.VerticalScrollbarBarColor = true;
            this.mTabCities.VerticalScrollbarHighlightOnWheel = false;
            this.mTabCities.VerticalScrollbarSize = 10;
            // 
            // mTabStudents
            // 
            this.mTabStudents.HorizontalScrollbarBarColor = true;
            this.mTabStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabStudents.HorizontalScrollbarSize = 10;
            this.mTabStudents.Location = new System.Drawing.Point(4, 38);
            this.mTabStudents.Name = "mTabStudents";
            this.mTabStudents.Size = new System.Drawing.Size(382, 176);
            this.mTabStudents.TabIndex = 1;
            this.mTabStudents.Text = "სტუდენტები";
            this.mTabStudents.VerticalScrollbarBarColor = true;
            this.mTabStudents.VerticalScrollbarHighlightOnWheel = false;
            this.mTabStudents.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "სათაურის ფერი";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(127, 3);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(175, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(183, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "სათაურის შრიფტის ზომა";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(192, 52);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(187, 23);
            this.metroTrackBar1.TabIndex = 5;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 360);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SettingsForm";
            this.Text = "პარამეტრები";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mTabControl.ResumeLayout(false);
            this.mTabCities.ResumeLayout(false);
            this.mTabCities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl mTabControl;
        private MetroFramework.Controls.MetroTabPage mTabCities;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage mTabStudents;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}