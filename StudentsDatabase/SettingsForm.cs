using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDatabase
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            this.Theme =
                this.metroPanel1.Theme =
                this.metroComboBox1.Theme =

                this.mCbxCitiesColors.Theme =
                this.metroLabel1.Theme =
                this.mLblCitiesHeaderColor.Theme =
                this.mLblCitiesHeaderTextSize.Theme =
                this.mLblCitiesRowTextSize.Theme =
                this.mScrollHeaderTextSize.Theme =
                mScrollRowTexeSize.Theme =
                this.mTabControl.Theme =
                this.mTabCities.Theme =
                this.mTabStudents.Theme =
                this.mCbxStudentsColors.Theme =
                this.mLblStudentsHeaderTextSize.Theme =
                this.mLblStudentsHeaderTextSizeValue.Theme =
                this.mLblStudentsRowTextSize.Theme =
                this.mLblStudentsRowTextSizeValue.Theme =
                this.mScrollStudentsHeaderTextSize.Theme =
                this.mScrollStudentsRowTexeSize.Theme =
                this.mLblHeaderTextSizeValue.Theme =
                this.mLblRowTextSizeValue.Theme =
                this.mStudentsHeaderColor.Theme =
                Properties.Settings.Default.MainTheme;

            metroComboBox1.SelectedIndex = (int)(Properties.Settings.Default.MainTheme) - 1;
            mCbxStudentsColors.SelectedIndex = (int)(Properties.Settings.Default.StudentsGridStyle);
            mCbxCitiesColors.SelectedIndex = (int)(Properties.Settings.Default.CitiesGridStyle);
            mScrollHeaderTextSize.Value = (int)(Properties.Settings.Default.CitiesHeaderTextSize);
            mScrollRowTexeSize.Value = Properties.Settings.Default.CitiesRowsTextSize;
            mScrollStudentsHeaderTextSize.Value = Properties.Settings.Default.StudentsHeaderTextSize;
            mScrollStudentsRowTexeSize.Value = Properties.Settings.Default.StudentsRowsTextSize;

        }

        private void mScrollHeaderTextSize_ValueChanged(object sender, EventArgs e)
        {
            mLblHeaderTextSizeValue.Text = mScrollHeaderTextSize.Value.ToString();
        }

        private void mScrollRowTexeSize_ValueChanged(object sender, EventArgs e)
        {
            mLblRowTextSizeValue.Text = mScrollRowTexeSize.Value.ToString();
        }

        private void mScrollStudentsHeaderTextSize_ValueChanged(object sender, EventArgs e)
        {
            mLblStudentsHeaderTextSizeValue.Text = mScrollStudentsHeaderTextSize.Value.ToString();
        }

        private void mScrollStudentsRowTexeSize_ValueChanged(object sender, EventArgs e)
        {
            mLblStudentsRowTextSizeValue.Text = mScrollStudentsRowTexeSize.Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "ცვლილებების შესანახად აუცილებელია გაითიშოს პროგრამა. \n\nნამდვილად გსურთ შენახვა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.MainTheme = (MetroFramework.MetroThemeStyle)(metroComboBox1.SelectedIndex + 1);
                Properties.Settings.Default.CitiesGridStyle = (MetroFramework.MetroColorStyle)mCbxCitiesColors.SelectedIndex;
                Properties.Settings.Default.StudentsGridStyle = (MetroFramework.MetroColorStyle)mCbxStudentsColors.SelectedIndex;
                Properties.Settings.Default.CitiesHeaderTextSize = mScrollHeaderTextSize.Value;
                Properties.Settings.Default.StudentsHeaderTextSize = mScrollStudentsHeaderTextSize.Value;
                Properties.Settings.Default.CitiesRowsTextSize = mScrollRowTexeSize.Value;
                Properties.Settings.Default.StudentsRowsTextSize = mScrollStudentsRowTexeSize.Value;

                if (Properties.Settings.Default.MainTheme == MetroThemeStyle.Dark)
                    Properties.Settings.Default.DefaultStyle = MetroColorStyle.Black;
                else if (Properties.Settings.Default.MainTheme == MetroThemeStyle.Light)
                    Properties.Settings.Default.DefaultStyle = MetroColorStyle.White;

                Properties.Settings.Default.Save();
                MetroMessageBox.Show(this, "\nგთხოვთ თავიდან ჩართოთ პროგრამა.", "ცვლილებები შენახულია!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Application.Exit();
            }
        }

        private void mBtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
