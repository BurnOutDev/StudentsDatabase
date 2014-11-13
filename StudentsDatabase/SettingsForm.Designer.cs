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
            this.mBtnCancel = new MetroFramework.Controls.MetroButton();
            this.mTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mTabCities = new MetroFramework.Controls.MetroTabPage();
            this.mLblRowTextSizeValue = new MetroFramework.Controls.MetroLabel();
            this.mLblHeaderTextSizeValue = new MetroFramework.Controls.MetroLabel();
            this.mScrollRowTexeSize = new MetroFramework.Controls.MetroTrackBar();
            this.mLblCitiesRowTextSize = new MetroFramework.Controls.MetroLabel();
            this.mScrollHeaderTextSize = new MetroFramework.Controls.MetroTrackBar();
            this.mLblCitiesHeaderTextSize = new MetroFramework.Controls.MetroLabel();
            this.mCbxCitiesColors = new MetroFramework.Controls.MetroComboBox();
            this.mLblCitiesHeaderColor = new MetroFramework.Controls.MetroLabel();
            this.mTabStudents = new MetroFramework.Controls.MetroTabPage();
            this.mLblStudentsRowTextSizeValue = new MetroFramework.Controls.MetroLabel();
            this.mLblStudentsHeaderTextSizeValue = new MetroFramework.Controls.MetroLabel();
            this.mScrollStudentsRowTexeSize = new MetroFramework.Controls.MetroTrackBar();
            this.mLblStudentsRowTextSize = new MetroFramework.Controls.MetroLabel();
            this.mScrollStudentsHeaderTextSize = new MetroFramework.Controls.MetroTrackBar();
            this.mLblStudentsHeaderTextSize = new MetroFramework.Controls.MetroLabel();
            this.mCbxStudentsColors = new MetroFramework.Controls.MetroComboBox();
            this.mStudentsHeaderColor = new MetroFramework.Controls.MetroLabel();
            this.mBtnSave = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroPanel1.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.mTabCities.SuspendLayout();
            this.mTabStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mBtnCancel);
            this.metroPanel1.Controls.Add(this.mTabControl);
            this.metroPanel1.Controls.Add(this.mBtnSave);
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
            this.metroPanel1.Theme = global::StudentsDatabase.Properties.Settings.Default.MainTheme;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Location = new System.Drawing.Point(314, 249);
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mBtnCancel.TabIndex = 9;
            this.mBtnCancel.Text = "გაუქმება";
            this.mBtnCancel.UseSelectable = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.mTabCities);
            this.mTabControl.Controls.Add(this.mTabStudents);
            this.mTabControl.Location = new System.Drawing.Point(3, 59);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(390, 184);
            this.mTabControl.TabIndex = 4;
            this.mTabControl.UseSelectable = true;
            // 
            // mTabCities
            // 
            this.mTabCities.Controls.Add(this.mLblRowTextSizeValue);
            this.mTabCities.Controls.Add(this.mLblHeaderTextSizeValue);
            this.mTabCities.Controls.Add(this.mScrollRowTexeSize);
            this.mTabCities.Controls.Add(this.mLblCitiesRowTextSize);
            this.mTabCities.Controls.Add(this.mScrollHeaderTextSize);
            this.mTabCities.Controls.Add(this.mLblCitiesHeaderTextSize);
            this.mTabCities.Controls.Add(this.mCbxCitiesColors);
            this.mTabCities.Controls.Add(this.mLblCitiesHeaderColor);
            this.mTabCities.HorizontalScrollbarBarColor = true;
            this.mTabCities.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabCities.HorizontalScrollbarSize = 10;
            this.mTabCities.Location = new System.Drawing.Point(4, 38);
            this.mTabCities.Name = "mTabCities";
            this.mTabCities.Size = new System.Drawing.Size(382, 142);
            this.mTabCities.TabIndex = 0;
            this.mTabCities.Text = "ქალაქები";
            this.mTabCities.VerticalScrollbarBarColor = true;
            this.mTabCities.VerticalScrollbarHighlightOnWheel = false;
            this.mTabCities.VerticalScrollbarSize = 10;
            // 
            // mLblRowTextSizeValue
            // 
            this.mLblRowTextSizeValue.AutoSize = true;
            this.mLblRowTextSizeValue.Location = new System.Drawing.Point(196, 126);
            this.mLblRowTextSizeValue.Name = "mLblRowTextSizeValue";
            this.mLblRowTextSizeValue.Size = new System.Drawing.Size(23, 19);
            this.mLblRowTextSizeValue.TabIndex = 8;
            this.mLblRowTextSizeValue.Text = "30";
            // 
            // mLblHeaderTextSizeValue
            // 
            this.mLblHeaderTextSizeValue.AutoSize = true;
            this.mLblHeaderTextSizeValue.Location = new System.Drawing.Point(196, 74);
            this.mLblHeaderTextSizeValue.Name = "mLblHeaderTextSizeValue";
            this.mLblHeaderTextSizeValue.Size = new System.Drawing.Size(23, 19);
            this.mLblHeaderTextSizeValue.TabIndex = 8;
            this.mLblHeaderTextSizeValue.Text = "30";
            // 
            // mScrollRowTexeSize
            // 
            this.mScrollRowTexeSize.BackColor = System.Drawing.Color.Transparent;
            this.mScrollRowTexeSize.Location = new System.Drawing.Point(3, 122);
            this.mScrollRowTexeSize.Maximum = 30;
            this.mScrollRowTexeSize.Minimum = 5;
            this.mScrollRowTexeSize.Name = "mScrollRowTexeSize";
            this.mScrollRowTexeSize.Size = new System.Drawing.Size(187, 23);
            this.mScrollRowTexeSize.TabIndex = 7;
            this.mScrollRowTexeSize.Text = "metroTrackBar2";
            this.mScrollRowTexeSize.Value = 5;
            this.mScrollRowTexeSize.ValueChanged += new System.EventHandler(this.mScrollRowTexeSize_ValueChanged);
            // 
            // mLblCitiesRowTextSize
            // 
            this.mLblCitiesRowTextSize.AutoSize = true;
            this.mLblCitiesRowTextSize.Location = new System.Drawing.Point(3, 100);
            this.mLblCitiesRowTextSize.Name = "mLblCitiesRowTextSize";
            this.mLblCitiesRowTextSize.Size = new System.Drawing.Size(196, 19);
            this.mLblCitiesRowTextSize.TabIndex = 6;
            this.mLblCitiesRowTextSize.Text = "მონაცემების ტექსტის ზომა";
            // 
            // mScrollHeaderTextSize
            // 
            this.mScrollHeaderTextSize.BackColor = System.Drawing.Color.Transparent;
            this.mScrollHeaderTextSize.Location = new System.Drawing.Point(3, 74);
            this.mScrollHeaderTextSize.Maximum = 30;
            this.mScrollHeaderTextSize.Minimum = 5;
            this.mScrollHeaderTextSize.Name = "mScrollHeaderTextSize";
            this.mScrollHeaderTextSize.Size = new System.Drawing.Size(187, 23);
            this.mScrollHeaderTextSize.TabIndex = 5;
            this.mScrollHeaderTextSize.Text = "metroTrackBar1";
            this.mScrollHeaderTextSize.Value = 5;
            this.mScrollHeaderTextSize.ValueChanged += new System.EventHandler(this.mScrollHeaderTextSize_ValueChanged);
            // 
            // mLblCitiesHeaderTextSize
            // 
            this.mLblCitiesHeaderTextSize.AutoSize = true;
            this.mLblCitiesHeaderTextSize.Location = new System.Drawing.Point(3, 52);
            this.mLblCitiesHeaderTextSize.Name = "mLblCitiesHeaderTextSize";
            this.mLblCitiesHeaderTextSize.Size = new System.Drawing.Size(177, 19);
            this.mLblCitiesHeaderTextSize.TabIndex = 4;
            this.mLblCitiesHeaderTextSize.Text = "სათაურის ტექსტის ზომა";
            // 
            // mCbxCitiesColors
            // 
            this.mCbxCitiesColors.FormattingEnabled = true;
            this.mCbxCitiesColors.ItemHeight = 23;
            this.mCbxCitiesColors.Items.AddRange(new object[] {
            "თავდაპირველი",
            "შავი",
            "თეთრი",
            "ნაცრისფერი",
            "ლურჯი",
            "მწვანე",
            "ლაიმი",
            "ცისფერი",
            "ფორთოხლისფერი",
            "ყავისფერი",
            "ვარდისფერი",
            "მეწამული",
            "იისფერი",
            "წითელი",
            "ყვითელი"});
            this.mCbxCitiesColors.Location = new System.Drawing.Point(127, 3);
            this.mCbxCitiesColors.Name = "mCbxCitiesColors";
            this.mCbxCitiesColors.Size = new System.Drawing.Size(175, 29);
            this.mCbxCitiesColors.TabIndex = 3;
            this.mCbxCitiesColors.UseSelectable = true;
            // 
            // mLblCitiesHeaderColor
            // 
            this.mLblCitiesHeaderColor.AutoSize = true;
            this.mLblCitiesHeaderColor.Location = new System.Drawing.Point(3, 6);
            this.mLblCitiesHeaderColor.Name = "mLblCitiesHeaderColor";
            this.mLblCitiesHeaderColor.Size = new System.Drawing.Size(118, 19);
            this.mLblCitiesHeaderColor.TabIndex = 2;
            this.mLblCitiesHeaderColor.Text = "სათაურის ფერი";
            // 
            // mTabStudents
            // 
            this.mTabStudents.Controls.Add(this.mLblStudentsRowTextSizeValue);
            this.mTabStudents.Controls.Add(this.mLblStudentsHeaderTextSizeValue);
            this.mTabStudents.Controls.Add(this.mScrollStudentsRowTexeSize);
            this.mTabStudents.Controls.Add(this.mLblStudentsRowTextSize);
            this.mTabStudents.Controls.Add(this.mScrollStudentsHeaderTextSize);
            this.mTabStudents.Controls.Add(this.mLblStudentsHeaderTextSize);
            this.mTabStudents.Controls.Add(this.mCbxStudentsColors);
            this.mTabStudents.Controls.Add(this.mStudentsHeaderColor);
            this.mTabStudents.HorizontalScrollbarBarColor = true;
            this.mTabStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabStudents.HorizontalScrollbarSize = 10;
            this.mTabStudents.Location = new System.Drawing.Point(4, 38);
            this.mTabStudents.Name = "mTabStudents";
            this.mTabStudents.Size = new System.Drawing.Size(382, 142);
            this.mTabStudents.TabIndex = 1;
            this.mTabStudents.Text = "სტუდენტები";
            this.mTabStudents.VerticalScrollbarBarColor = true;
            this.mTabStudents.VerticalScrollbarHighlightOnWheel = false;
            this.mTabStudents.VerticalScrollbarSize = 10;
            // 
            // mLblStudentsRowTextSizeValue
            // 
            this.mLblStudentsRowTextSizeValue.AutoSize = true;
            this.mLblStudentsRowTextSizeValue.Location = new System.Drawing.Point(196, 126);
            this.mLblStudentsRowTextSizeValue.Name = "mLblStudentsRowTextSizeValue";
            this.mLblStudentsRowTextSizeValue.Size = new System.Drawing.Size(23, 19);
            this.mLblStudentsRowTextSizeValue.TabIndex = 8;
            this.mLblStudentsRowTextSizeValue.Text = "30";
            // 
            // mLblStudentsHeaderTextSizeValue
            // 
            this.mLblStudentsHeaderTextSizeValue.AutoSize = true;
            this.mLblStudentsHeaderTextSizeValue.Location = new System.Drawing.Point(196, 74);
            this.mLblStudentsHeaderTextSizeValue.Name = "mLblStudentsHeaderTextSizeValue";
            this.mLblStudentsHeaderTextSizeValue.Size = new System.Drawing.Size(23, 19);
            this.mLblStudentsHeaderTextSizeValue.TabIndex = 8;
            this.mLblStudentsHeaderTextSizeValue.Text = "30";
            // 
            // mScrollStudentsRowTexeSize
            // 
            this.mScrollStudentsRowTexeSize.BackColor = System.Drawing.Color.Transparent;
            this.mScrollStudentsRowTexeSize.Location = new System.Drawing.Point(3, 122);
            this.mScrollStudentsRowTexeSize.Maximum = 30;
            this.mScrollStudentsRowTexeSize.Minimum = 5;
            this.mScrollStudentsRowTexeSize.Name = "mScrollStudentsRowTexeSize";
            this.mScrollStudentsRowTexeSize.Size = new System.Drawing.Size(187, 23);
            this.mScrollStudentsRowTexeSize.TabIndex = 7;
            this.mScrollStudentsRowTexeSize.Text = "metroTrackBar2";
            this.mScrollStudentsRowTexeSize.Value = 5;
            this.mScrollStudentsRowTexeSize.ValueChanged += new System.EventHandler(this.mScrollStudentsRowTexeSize_ValueChanged);
            // 
            // mLblStudentsRowTextSize
            // 
            this.mLblStudentsRowTextSize.AutoSize = true;
            this.mLblStudentsRowTextSize.Location = new System.Drawing.Point(3, 100);
            this.mLblStudentsRowTextSize.Name = "mLblStudentsRowTextSize";
            this.mLblStudentsRowTextSize.Size = new System.Drawing.Size(196, 19);
            this.mLblStudentsRowTextSize.TabIndex = 6;
            this.mLblStudentsRowTextSize.Text = "მონაცემების ტექსტის ზომა";
            // 
            // mScrollStudentsHeaderTextSize
            // 
            this.mScrollStudentsHeaderTextSize.BackColor = System.Drawing.Color.Transparent;
            this.mScrollStudentsHeaderTextSize.Location = new System.Drawing.Point(3, 74);
            this.mScrollStudentsHeaderTextSize.Maximum = 30;
            this.mScrollStudentsHeaderTextSize.Minimum = 5;
            this.mScrollStudentsHeaderTextSize.Name = "mScrollStudentsHeaderTextSize";
            this.mScrollStudentsHeaderTextSize.Size = new System.Drawing.Size(187, 23);
            this.mScrollStudentsHeaderTextSize.TabIndex = 5;
            this.mScrollStudentsHeaderTextSize.Text = "metroTrackBar1";
            this.mScrollStudentsHeaderTextSize.Value = 5;
            this.mScrollStudentsHeaderTextSize.ValueChanged += new System.EventHandler(this.mScrollStudentsHeaderTextSize_ValueChanged);
            // 
            // mLblStudentsHeaderTextSize
            // 
            this.mLblStudentsHeaderTextSize.AutoSize = true;
            this.mLblStudentsHeaderTextSize.Location = new System.Drawing.Point(3, 52);
            this.mLblStudentsHeaderTextSize.Name = "mLblStudentsHeaderTextSize";
            this.mLblStudentsHeaderTextSize.Size = new System.Drawing.Size(177, 19);
            this.mLblStudentsHeaderTextSize.TabIndex = 4;
            this.mLblStudentsHeaderTextSize.Text = "სათაურის ტექსტის ზომა";
            // 
            // mCbxStudentsColors
            // 
            this.mCbxStudentsColors.FormattingEnabled = true;
            this.mCbxStudentsColors.ItemHeight = 23;
            this.mCbxStudentsColors.Items.AddRange(new object[] {
            "თავდაპირველი",
            "შავი",
            "თეთრი",
            "ნაცრისფერი",
            "ლურჯი",
            "მწვანე",
            "ლაიმი",
            "ცისფერი",
            "ფორთოხლისფერი",
            "ყავისფერი",
            "ვარდისფერი",
            "მეწამული",
            "იისფერი",
            "წითელი",
            "ყვითელი"});
            this.mCbxStudentsColors.Location = new System.Drawing.Point(127, 3);
            this.mCbxStudentsColors.Name = "mCbxStudentsColors";
            this.mCbxStudentsColors.Size = new System.Drawing.Size(175, 29);
            this.mCbxStudentsColors.TabIndex = 3;
            this.mCbxStudentsColors.UseSelectable = true;
            // 
            // mStudentsHeaderColor
            // 
            this.mStudentsHeaderColor.AutoSize = true;
            this.mStudentsHeaderColor.Location = new System.Drawing.Point(3, 6);
            this.mStudentsHeaderColor.Name = "mStudentsHeaderColor";
            this.mStudentsHeaderColor.Size = new System.Drawing.Size(118, 19);
            this.mStudentsHeaderColor.TabIndex = 2;
            this.mStudentsHeaderColor.Text = "სათაურის ფერი";
            // 
            // mBtnSave
            // 
            this.mBtnSave.Location = new System.Drawing.Point(233, 249);
            this.mBtnSave.Name = "mBtnSave";
            this.mBtnSave.Size = new System.Drawing.Size(75, 23);
            this.mBtnSave.TabIndex = 9;
            this.mBtnSave.Text = "შენახვა";
            this.mBtnSave.UseSelectable = true;
            this.mBtnSave.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "თეთრი",
            "შავი"});
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
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.mTabStudents.ResumeLayout(false);
            this.mTabStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl mTabControl;
        private MetroFramework.Controls.MetroTabPage mTabCities;
        private MetroFramework.Controls.MetroComboBox mCbxCitiesColors;
        private MetroFramework.Controls.MetroLabel mLblCitiesHeaderColor;
        private MetroFramework.Controls.MetroTrackBar mScrollHeaderTextSize;
        private MetroFramework.Controls.MetroLabel mLblCitiesHeaderTextSize;
        private MetroFramework.Controls.MetroTrackBar mScrollRowTexeSize;
        private MetroFramework.Controls.MetroLabel mLblCitiesRowTextSize;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel mLblRowTextSizeValue;
        private MetroFramework.Controls.MetroLabel mLblHeaderTextSizeValue;
        private MetroFramework.Controls.MetroTabPage mTabStudents;
        private MetroFramework.Controls.MetroLabel mLblStudentsRowTextSizeValue;
        private MetroFramework.Controls.MetroLabel mLblStudentsHeaderTextSizeValue;
        private MetroFramework.Controls.MetroTrackBar mScrollStudentsRowTexeSize;
        private MetroFramework.Controls.MetroLabel mLblStudentsRowTextSize;
        private MetroFramework.Controls.MetroTrackBar mScrollStudentsHeaderTextSize;
        private MetroFramework.Controls.MetroLabel mLblStudentsHeaderTextSize;
        private MetroFramework.Controls.MetroComboBox mCbxStudentsColors;
        private MetroFramework.Controls.MetroLabel mStudentsHeaderColor;
        private MetroFramework.Controls.MetroButton mBtnSave;
        private MetroFramework.Controls.MetroButton mBtnCancel;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}