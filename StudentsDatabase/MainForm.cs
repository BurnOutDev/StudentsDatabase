using MetroFramework;
using MetroFramework.Controls;
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
        public StudentsDatabase.Database.StudentsDbContext StudentsDb { get; set; }
        public MainForm()
        {
            InitializeComponent();
            ChangeControlTheme(Properties.Settings.Default.MainTheme, menuStrip);
            mGridCities.Theme =
                mGridStudents.Theme =
                metroTextBox1.Theme =
                Properties.Settings.Default.MainTheme;
            mTileAbout.Style =
                mTileSettings.Style =
                metroTextBox1.Style =
                Properties.Settings.Default.DefaultStyle;

            foreach (DataGridViewColumn column in mGridCities.Columns)
            {
                column.DefaultCellStyle.Font = MetroFonts.Default(Properties.Settings.Default.CitiesRowsTextSize);
                column.HeaderCell.Style.Font = MetroFonts.Default(Properties.Settings.Default.CitiesHeaderTextSize);
                //column.HeaderCell.Style.BackColor = MetroColors.Green;
            }

            foreach (DataGridViewColumn column in mGridStudents.Columns)
            {
                column.DefaultCellStyle.Font = MetroFonts.Default(Properties.Settings.Default.StudentsRowsTextSize);
                column.HeaderCell.Style.Font = MetroFonts.Default(Properties.Settings.Default.StudentsHeaderTextSize);
                //column.HeaderCell.Style.BackColor = MetroColors.Lime;
            }

            #region Creating Database

            StudentsDb = new Database.StudentsDbContext();

            #endregion

            ReFillDatagridviews();
        }

        private void ReFillDatagridviews()
        {
            mGridCities.Rows.Clear();
            mGridStudents.Rows.Clear();

            mGridCities.Rows.Add("ყველა");

            var cities = from city in StudentsDb.Cities
                         select city;

            foreach (var city in cities)
            {
                mGridCities.Rows.Add(city.CityName);
            }

            var students = from student in StudentsDb.Students
                           select student;

            foreach (var student in students)
            {
                mGridStudents.Rows.Add(student.FirstName, student.LastName, student.PersonalID, student.Email, student.PhoneNumber);
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

        private void დამატებაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCityForm addCityForm = new AddCityForm(StudentsDb);
            if (addCityForm.ShowDialog() == DialogResult.OK)
            {
                ReFillDatagridviews();
            }
        }

        private void დამატებაToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm(StudentsDb);
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                ReFillDatagridviews();
            }
        }

        private void რედაქტირებაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editCityForm = new EditCityForm(5);
            if (editCityForm.ShowDialog() == DialogResult.OK)
            {
                ReFillDatagridviews();
            }
        }

        private void რედაქტირებაToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (mGridStudents.SelectedRows.Count != 0)
            {
                string personalId = mGridStudents.SelectedRows[0].Cells[2].Value.ToString();

                var st = (from student in StudentsDb.Students
                              where student.PersonalID == personalId
                              select student).FirstOrDefault();

                var editStudentForm = new EditStudentForm(st.Student_id, StudentsDb);
                if (editStudentForm.ShowDialog() == DialogResult.OK)
                {
                    ReFillDatagridviews();
                }
            }
        }

        private void წაშლაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "ნამდვლად გსურთ ამ ქალაქის წაშლა?", "წაშლის ოპერაცია", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                throw new NotImplementedException("მეთოდი ცარიელია");
            }
        }

        private void წაშლაToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "ნამდვლად გსურთ ამ სტუდენტის წაშლა?", "წაშლის ოპერაცია", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                throw new NotImplementedException("მეთოდი ცარიელია");
            }
        }

        private void mGridCities_SelectionChanged(object sender, EventArgs e)
        {
            if (mGridCities.SelectedRows.Count == 0)
            {
                bool forSkip = true;
                foreach (ToolStripMenuItem item in (menuStrip.Items[0] as ToolStripMenuItem).DropDownItems)
                {
                    if (forSkip)
                    {
                        forSkip = false;
                        continue;
                    }

                    item.Enabled = false;
                }
            }
            else
            {
                bool forSkip = true;
                foreach (ToolStripMenuItem item in (menuStrip.Items[0] as ToolStripMenuItem).DropDownItems)
                {
                    if (forSkip)
                    {
                        forSkip = false;
                        continue;
                    }

                    item.Enabled = true;
                }
            }
        }

        private void mGridStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (mGridStudents.SelectedRows.Count == 0)
            {
                bool forSkip = true;
                foreach (ToolStripMenuItem item in (menuStrip.Items[1] as ToolStripMenuItem).DropDownItems)
                {
                    if (forSkip)
                    {
                        forSkip = false;
                        continue;
                    }

                    item.Enabled = false;
                }
            }
            else
            {
                bool forSkip = true;
                foreach (ToolStripMenuItem item in (menuStrip.Items[0] as ToolStripMenuItem).DropDownItems)
                {
                    if (forSkip)
                    {
                        forSkip = false;
                        continue;
                    }

                    item.Enabled = true;
                }
            }
        }

        private void mTileAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
