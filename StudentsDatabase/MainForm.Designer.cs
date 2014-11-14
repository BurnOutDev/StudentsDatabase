using System.Drawing;
namespace StudentsDatabase.Design
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mPanelCities = new MetroFramework.Controls.MetroPanel();
            this.mGridCities = new MetroFramework.Controls.MetroGrid();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPanelStudents = new MetroFramework.Controls.MetroPanel();
            this.mGridStudents = new MetroFramework.Controls.MetroGrid();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mContextMenuCitiesGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.დამატებაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mContextMenuStudentsGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.დამატებაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.დამატებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.დამატებაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.mTileSettings = new MetroFramework.Controls.MetroTile();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.mPanelCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridCities)).BeginInit();
            this.mPanelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridStudents)).BeginInit();
            this.mContextMenuCitiesGrid.SuspendLayout();
            this.mContextMenuStudentsGrid.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(20, 88);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.mPanelCities);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.mPanelStudents);
            this.splitContainer.Size = new System.Drawing.Size(805, 350);
            this.splitContainer.SplitterDistance = 184;
            this.splitContainer.TabIndex = 0;
            // 
            // mPanelCities
            // 
            this.mPanelCities.Controls.Add(this.mGridCities);
            this.mPanelCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelCities.HorizontalScrollbarBarColor = true;
            this.mPanelCities.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelCities.HorizontalScrollbarSize = 10;
            this.mPanelCities.Location = new System.Drawing.Point(0, 0);
            this.mPanelCities.Name = "mPanelCities";
            this.mPanelCities.Size = new System.Drawing.Size(184, 350);
            this.mPanelCities.TabIndex = 0;
            this.mPanelCities.VerticalScrollbarBarColor = true;
            this.mPanelCities.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelCities.VerticalScrollbarSize = 10;
            // 
            // mGridCities
            // 
            this.mGridCities.AllowUserToAddRows = false;
            this.mGridCities.AllowUserToDeleteRows = false;
            this.mGridCities.AllowUserToResizeColumns = false;
            this.mGridCities.AllowUserToResizeRows = false;
            this.mGridCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridCities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridCities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridCities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridCities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridCities.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGridCities.EnableHeadersVisualStyles = false;
            this.mGridCities.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridCities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridCities.Location = new System.Drawing.Point(0, 0);
            this.mGridCities.MultiSelect = false;
            this.mGridCities.Name = "mGridCities";
            this.mGridCities.ReadOnly = true;
            this.mGridCities.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridCities.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridCities.RowHeadersVisible = false;
            this.mGridCities.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridCities.Size = new System.Drawing.Size(184, 350);
            this.mGridCities.Style = global::StudentsDatabase.Properties.Settings.Default.CitiesGridStyle;
            this.mGridCities.TabIndex = 2;
            this.mGridCities.SelectionChanged += new System.EventHandler(this.mGridCities_SelectionChanged);
            // 
            // CityName
            // 
            this.CityName.HeaderText = "ქალაქი";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // mPanelStudents
            // 
            this.mPanelStudents.Controls.Add(this.mGridStudents);
            this.mPanelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelStudents.HorizontalScrollbarBarColor = true;
            this.mPanelStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelStudents.HorizontalScrollbarSize = 10;
            this.mPanelStudents.Location = new System.Drawing.Point(0, 0);
            this.mPanelStudents.Name = "mPanelStudents";
            this.mPanelStudents.Size = new System.Drawing.Size(617, 350);
            this.mPanelStudents.TabIndex = 0;
            this.mPanelStudents.VerticalScrollbarBarColor = true;
            this.mPanelStudents.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelStudents.VerticalScrollbarSize = 10;
            // 
            // mGridStudents
            // 
            this.mGridStudents.AllowUserToAddRows = false;
            this.mGridStudents.AllowUserToDeleteRows = false;
            this.mGridStudents.AllowUserToResizeColumns = false;
            this.mGridStudents.AllowUserToResizeRows = false;
            this.mGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.PersonalID,
            this.Email,
            this.PhoneNumber});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridStudents.DefaultCellStyle = dataGridViewCellStyle5;
            this.mGridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGridStudents.EnableHeadersVisualStyles = false;
            this.mGridStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridStudents.Location = new System.Drawing.Point(0, 0);
            this.mGridStudents.Name = "mGridStudents";
            this.mGridStudents.ReadOnly = true;
            this.mGridStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mGridStudents.RowHeadersVisible = false;
            this.mGridStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridStudents.Size = new System.Drawing.Size(617, 350);
            this.mGridStudents.Style = global::StudentsDatabase.Properties.Settings.Default.StudentsGridStyle;
            this.mGridStudents.TabIndex = 4;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "სახელი გვარი";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PersonalID
            // 
            this.PersonalID.HeaderText = "პირადი ნომერი";
            this.PersonalID.Name = "PersonalID";
            this.PersonalID.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "ელ-ფოსტა";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "ტელ. ნომერი";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // mContextMenuCitiesGrid
            // 
            this.mContextMenuCitiesGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.დამატებაToolStripMenuItem2,
            this.რედაქტირებაToolStripMenuItem2,
            this.წაშლაToolStripMenuItem2});
            this.mContextMenuCitiesGrid.Name = "mContextMenu";
            this.mContextMenuCitiesGrid.Size = new System.Drawing.Size(166, 70);
            // 
            // დამატებაToolStripMenuItem2
            // 
            this.დამატებაToolStripMenuItem2.Name = "დამატებაToolStripMenuItem2";
            this.დამატებაToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.დამატებაToolStripMenuItem2.Text = "დამატება...";
            // 
            // რედაქტირებაToolStripMenuItem2
            // 
            this.რედაქტირებაToolStripMenuItem2.Name = "რედაქტირებაToolStripMenuItem2";
            this.რედაქტირებაToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.რედაქტირებაToolStripMenuItem2.Text = "რედაქტირება...";
            // 
            // წაშლაToolStripMenuItem2
            // 
            this.წაშლაToolStripMenuItem2.Name = "წაშლაToolStripMenuItem2";
            this.წაშლაToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.წაშლაToolStripMenuItem2.Text = "წაშლა...";
            // 
            // mContextMenuStudentsGrid
            // 
            this.mContextMenuStudentsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.დამატებაToolStripMenuItem3,
            this.რედაქტირებაToolStripMenuItem3,
            this.წაშლაToolStripMenuItem3});
            this.mContextMenuStudentsGrid.Name = "mContextMenuStudentsGrid";
            this.mContextMenuStudentsGrid.Size = new System.Drawing.Size(166, 70);
            // 
            // დამატებაToolStripMenuItem3
            // 
            this.დამატებაToolStripMenuItem3.Name = "დამატებაToolStripMenuItem3";
            this.დამატებაToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.დამატებაToolStripMenuItem3.Text = "დამატება...";
            // 
            // რედაქტირებაToolStripMenuItem3
            // 
            this.რედაქტირებაToolStripMenuItem3.Name = "რედაქტირებაToolStripMenuItem3";
            this.რედაქტირებაToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.რედაქტირებაToolStripMenuItem3.Text = "რედაქტირება...";
            // 
            // წაშლაToolStripMenuItem3
            // 
            this.წაშლაToolStripMenuItem3.Name = "წაშლაToolStripMenuItem3";
            this.წაშლაToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.წაშლაToolStripMenuItem3.Text = "წაშლა...";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.დამატებაToolStripMenuItem,
            this.რედაქტირებაToolStripMenuItem,
            this.წაშლაToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.fileToolStripMenuItem.Text = "ქალაქი";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened);
            // 
            // დამატებაToolStripMenuItem
            // 
            this.დამატებაToolStripMenuItem.Name = "დამატებაToolStripMenuItem";
            this.დამატებაToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.დამატებაToolStripMenuItem.Text = "დამატება...";
            this.დამატებაToolStripMenuItem.Click += new System.EventHandler(this.დამატებაToolStripMenuItem_Click);
            // 
            // რედაქტირებაToolStripMenuItem
            // 
            this.რედაქტირებაToolStripMenuItem.Name = "რედაქტირებაToolStripMenuItem";
            this.რედაქტირებაToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.რედაქტირებაToolStripMenuItem.Text = "რედაქტირება...";
            this.რედაქტირებაToolStripMenuItem.Click += new System.EventHandler(this.რედაქტირებაToolStripMenuItem_Click);
            // 
            // წაშლაToolStripMenuItem
            // 
            this.წაშლაToolStripMenuItem.Name = "წაშლაToolStripMenuItem";
            this.წაშლაToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.წაშლაToolStripMenuItem.Text = "წაშლა...";
            this.წაშლაToolStripMenuItem.Click += new System.EventHandler(this.წაშლაToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.დამატებაToolStripMenuItem1,
            this.რედაქტირებაToolStripMenuItem1,
            this.წაშლაToolStripMenuItem1});
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.openToolStripMenuItem.Text = "სტუდენტი";
            this.openToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.openToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            this.openToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened);
            // 
            // დამატებაToolStripMenuItem1
            // 
            this.დამატებაToolStripMenuItem1.Name = "დამატებაToolStripMenuItem1";
            this.დამატებაToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.დამატებაToolStripMenuItem1.Text = "დამატება...";
            this.დამატებაToolStripMenuItem1.Click += new System.EventHandler(this.დამატებაToolStripMenuItem1_Click);
            // 
            // რედაქტირებაToolStripMenuItem1
            // 
            this.რედაქტირებაToolStripMenuItem1.Name = "რედაქტირებაToolStripMenuItem1";
            this.რედაქტირებაToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.რედაქტირებაToolStripMenuItem1.Text = "რედაქტირება...";
            this.რედაქტირებაToolStripMenuItem1.Click += new System.EventHandler(this.რედაქტირებაToolStripMenuItem1_Click);
            // 
            // წაშლაToolStripMenuItem1
            // 
            this.წაშლაToolStripMenuItem1.Name = "წაშლაToolStripMenuItem1";
            this.წაშლაToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.წაშლაToolStripMenuItem1.Text = "წაშლა...";
            this.წაშლაToolStripMenuItem1.Click += new System.EventHandler(this.წაშლაToolStripMenuItem1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(805, 28);
            this.menuStrip.TabIndex = 1;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.metroTextBox1.Lines = new string[] {
        "ძებნა..."};
            this.metroTextBox1.Location = new System.Drawing.Point(208, 62);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(509, 23);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Text = "ძებნა...";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Enter += new System.EventHandler(this.metroTextBox1_Enter);
            this.metroTextBox1.Leave += new System.EventHandler(this.metroTextBox1_Leave);
            // 
            // mTileSettings
            // 
            this.mTileSettings.ActiveControl = null;
            this.mTileSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTileSettings.Location = new System.Drawing.Point(777, 34);
            this.mTileSettings.Name = "mTileSettings";
            this.mTileSettings.Size = new System.Drawing.Size(48, 48);
            this.mTileSettings.Style = global::StudentsDatabase.Properties.Settings.Default.DefaultStyle;
            this.mTileSettings.TabIndex = 4;
            this.mTileSettings.TileImage = global::StudentsDatabase.Properties.Resources.GearGreenS;
            this.mTileSettings.UseSelectable = true;
            this.mTileSettings.UseTileImage = true;
            this.mTileSettings.Click += new System.EventHandler(this.mTileSettings_Click);
            // 
            // mTileAbout
            // 
            this.mTileAbout.ActiveControl = null;
            this.mTileAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTileAbout.Location = new System.Drawing.Point(723, 34);
            this.mTileAbout.Name = "mTileAbout";
            this.mTileAbout.Size = new System.Drawing.Size(48, 48);
            this.mTileAbout.Style = global::StudentsDatabase.Properties.Settings.Default.DefaultStyle;
            this.mTileAbout.TabIndex = 5;
            this.mTileAbout.TileImage = global::StudentsDatabase.Properties.Resources.InfoBoldL1;
            this.mTileAbout.UseSelectable = true;
            this.mTileAbout.UseTileImage = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 458);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mTileSettings);
            this.Controls.Add(this.mTileAbout);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Location = global::StudentsDatabase.Properties.Settings.Default.WindowLocation;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "სტუდენტების სია";
            this.Theme = global::StudentsDatabase.Properties.Settings.Default.MainTheme;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.mPanelCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridCities)).EndInit();
            this.mPanelStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridStudents)).EndInit();
            this.mContextMenuCitiesGrid.ResumeLayout(false);
            this.mContextMenuStudentsGrid.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroPanel mPanelCities;
        private MetroFramework.Controls.MetroGrid mGridCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private MetroFramework.Controls.MetroPanel mPanelStudents;
        private MetroFramework.Controls.MetroContextMenu mContextMenuCitiesGrid;
        private System.Windows.Forms.ToolStripMenuItem დამატებაToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem რედაქტირებაToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem წაშლაToolStripMenuItem2;
        private MetroFramework.Controls.MetroContextMenu mContextMenuStudentsGrid;
        private System.Windows.Forms.ToolStripMenuItem დამატებაToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem რედაქტირებაToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem წაშლაToolStripMenuItem3;
        private MetroFramework.Controls.MetroTile mTileSettings;
        private MetroFramework.Controls.MetroTile mTileAbout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem დამატებაToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem რედაქტირებაToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem წაშლაToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem დამატებაToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem რედაქტირებაToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem წაშლაToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid mGridStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

