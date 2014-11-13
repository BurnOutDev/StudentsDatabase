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

namespace StudentsDatabase.Design
{
    public partial class MainForm : MetroForm
    {
        public Color BColor
        {
            get
            {
                return Properties.Settings.Default.MainTheme == MetroThemeStyle.Dark ? Color.Black : Color.White;
            }
        }
        public Color FColor
        {
            get
            {
                return Properties.Settings.Default.MainTheme == MetroThemeStyle.Dark ? Color.White : Color.Black;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void mTileSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        //private void ChangeControlTheme(MetroThemeStyle style, Control control)
        //{
        //    switch (style)
        //    {
        //        case MetroThemeStyle.Dark:
        //            control.BackColor = Color.Black;
        //            control.ForeColor = Color.White;
        //            break;
        //        case MetroThemeStyle.Light:
        //            control.BackColor = Color.White;
        //            control.ForeColor = Color.Black;
        //            break;
        //        case MetroThemeStyle.Default:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            if (this.Theme == MetroThemeStyle.Dark)
            {
                (sender as ToolStripMenuItem).ForeColor = Color.White; 
            }
        }
    }
}
