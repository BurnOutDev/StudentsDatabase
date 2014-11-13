﻿using System.Drawing;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mPanelCities = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPanelStudents = new MetroFramework.Controls.MetroPanel();
            this.metroGrid4 = new MetroFramework.Controls.MetroGrid();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.mContextMenuCitiesGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.დამატებაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mContextMenuStudentsGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.დამატებაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            this.mTileSettings = new MetroFramework.Controls.MetroTile();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.დამატებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.დამატებაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.mPanelCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.mPanelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
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
            this.splitContainer.SplitterDistance = 210;
            this.splitContainer.TabIndex = 0;
            // 
            // mPanelCities
            // 
            this.mPanelCities.Controls.Add(this.metroGrid1);
            this.mPanelCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelCities.HorizontalScrollbarBarColor = true;
            this.mPanelCities.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelCities.HorizontalScrollbarSize = 10;
            this.mPanelCities.Location = new System.Drawing.Point(0, 0);
            this.mPanelCities.Name = "mPanelCities";
            this.mPanelCities.Size = new System.Drawing.Size(210, 350);
            this.mPanelCities.TabIndex = 0;
            this.mPanelCities.VerticalScrollbarBarColor = true;
            this.mPanelCities.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelCities.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(210, 350);
            this.metroGrid1.Style = global::StudentsDatabase.Properties.Settings.Default.CitiesGridStyle;
            this.metroGrid1.TabIndex = 2;
            // 
            // CityName
            // 
            this.CityName.HeaderText = "ქალაქი";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // mPanelStudents
            // 
            this.mPanelStudents.Controls.Add(this.metroGrid4);
            this.mPanelStudents.Controls.Add(this.metroGrid3);
            this.mPanelStudents.Controls.Add(this.metroGrid2);
            this.mPanelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelStudents.HorizontalScrollbarBarColor = true;
            this.mPanelStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelStudents.HorizontalScrollbarSize = 10;
            this.mPanelStudents.Location = new System.Drawing.Point(0, 0);
            this.mPanelStudents.Name = "mPanelStudents";
            this.mPanelStudents.Size = new System.Drawing.Size(591, 350);
            this.mPanelStudents.TabIndex = 0;
            this.mPanelStudents.VerticalScrollbarBarColor = true;
            this.mPanelStudents.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelStudents.VerticalScrollbarSize = 10;
            // 
            // metroGrid4
            // 
            this.metroGrid4.AllowUserToAddRows = false;
            this.metroGrid4.AllowUserToDeleteRows = false;
            this.metroGrid4.AllowUserToResizeColumns = false;
            this.metroGrid4.AllowUserToResizeRows = false;
            this.metroGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.metroGrid4.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid4.EnableHeadersVisualStyles = false;
            this.metroGrid4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.Location = new System.Drawing.Point(0, 0);
            this.metroGrid4.Name = "metroGrid4";
            this.metroGrid4.ReadOnly = true;
            this.metroGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid4.RowHeadersVisible = false;
            this.metroGrid4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid4.Size = new System.Drawing.Size(591, 350);
            this.metroGrid4.Style = global::StudentsDatabase.Properties.Settings.Default.StudentsGridStyle;
            this.metroGrid4.TabIndex = 4;
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
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToAddRows = false;
            this.metroGrid3.AllowUserToDeleteRows = false;
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(0, 0);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.ReadOnly = true;
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(591, 350);
            this.metroGrid3.TabIndex = 3;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 0);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(591, 350);
            this.metroGrid2.TabIndex = 2;
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
            // fileToolStripMenuItem
            // 
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
            // 
            // რედაქტირებაToolStripMenuItem
            // 
            this.რედაქტირებაToolStripMenuItem.Name = "რედაქტირებაToolStripMenuItem";
            this.რედაქტირებაToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.რედაქტირებაToolStripMenuItem.Text = "რედაქტირება...";
            // 
            // წაშლაToolStripMenuItem
            // 
            this.წაშლაToolStripMenuItem.Name = "წაშლაToolStripMenuItem";
            this.წაშლაToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.წაშლაToolStripMenuItem.Text = "წაშლა...";
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
            // 
            // რედაქტირებაToolStripMenuItem1
            // 
            this.რედაქტირებაToolStripMenuItem1.Name = "რედაქტირებაToolStripMenuItem1";
            this.რედაქტირებაToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.რედაქტირებაToolStripMenuItem1.Text = "რედაქტირება...";
            // 
            // წაშლაToolStripMenuItem1
            // 
            this.წაშლაToolStripMenuItem1.Name = "წაშლაToolStripMenuItem1";
            this.წაშლაToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.წაშლაToolStripMenuItem1.Text = "წაშლა...";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 458);
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.mPanelCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.mPanelStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private MetroFramework.Controls.MetroPanel mPanelStudents;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroGrid metroGrid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
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
    }
}
