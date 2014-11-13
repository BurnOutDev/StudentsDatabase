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
            ChangeControlTheme(Properties.Settings.Default.MainTheme, menuStrip);
            metroGrid1.Theme =
                metroGrid4.Theme =
                Properties.Settings.Default.MainTheme;
            mTileAbout.Style =
                mTileSettings.Style =
                Properties.Settings.Default.DefaultStyle;

            foreach (DataGridViewColumn column in metroGrid1.Columns)
            {
                column.HeaderCell.Style.Font = MetroFonts.Default(Properties.Settings.Default.CitiesHeaderTextSize);
                column.DefaultCellStyle.Font = MetroFonts.Default(Properties.Settings.Default.CitiesRowsTextSize);
            }

            foreach (DataGridViewColumn column in metroGrid4.Columns)
            {
                column.HeaderCell.Style.Font = MetroFonts.Default(Properties.Settings.Default.StudentsHeaderTextSize);
                column.DefaultCellStyle.Font = MetroFonts.Default(Properties.Settings.Default.StudentsRowsTextSize);
            }
        }

        private void mTileSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void ChangeControlTheme(MetroThemeStyle style, Control control)
        {
            switch (style)
            {
                case MetroThemeStyle.Dark:
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                    break;
                case MetroThemeStyle.Light:
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                    break;
                case MetroThemeStyle.Default:
                    break;
                default:
                    break;
            }

            if (control.GetType() == typeof(MenuStrip))
            {
                foreach (ToolStripMenuItem item in (control as MenuStrip).Items)
                {
                    switch (style)
                    {
                        case MetroThemeStyle.Dark:
                            item.BackColor = Color.Black;
                            item.ForeColor = Color.White;
                            break;
                        case MetroThemeStyle.Light:
                            item.BackColor = Color.White;
                            item.ForeColor = Color.Black;
                            break;
                        case MetroThemeStyle.Default:
                            break;
                        default:
                            break;
                    }
                }
            }
        }

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsMaximized)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.Size = Properties.Settings.Default.WindowSize;
                this.Location = Properties.Settings.Default.WindowLocation;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.IsMaximized = this.WindowState == FormWindowState.Maximized;

            Properties.Settings.Default.Save();
        }

        private void metroTextBox1_Enter(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "ძებნა...")
            {
                metroTextBox1.Clear();
            }
            metroTextBox1.ForeColor = MetroColors.Silver;
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                metroTextBox1.Text = "ძებნა...";
                metroTextBox1.ForeColor = MetroColors.Black;
            }
        }
    }
}
