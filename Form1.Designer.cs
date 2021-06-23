
namespace XEDTK
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.deviceGridView = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDisksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrateOSToSSDHDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partitionRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dynamicDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OperationsPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PartitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnusedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSystemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(811, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(938, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 147);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(938, 197);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 148);
            this.textBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanDrivesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // scanDrivesToolStripMenuItem
            // 
            this.scanDrivesToolStripMenuItem.Name = "scanDrivesToolStripMenuItem";
            this.scanDrivesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.scanDrivesToolStripMenuItem.Text = "Scan Drives";
            this.scanDrivesToolStripMenuItem.Click += new System.EventHandler(this.scanDrivesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deviceGridView
            // 
            this.deviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.VolumeType,
            this.VolumeSize,
            this.DeviceMode});
            this.deviceGridView.Location = new System.Drawing.Point(938, 351);
            this.deviceGridView.Name = "deviceGridView";
            this.deviceGridView.RowHeadersVisible = false;
            this.deviceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceGridView.Size = new System.Drawing.Size(192, 222);
            this.deviceGridView.TabIndex = 5;
            // 
            // DeviceName
            // 
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.Name = "DeviceName";
            // 
            // VolumeType
            // 
            this.VolumeType.HeaderText = "Volume Type";
            this.VolumeType.Name = "VolumeType";
            // 
            // VolumeSize
            // 
            this.VolumeSize.HeaderText = "Volume Size";
            this.VolumeSize.Name = "VolumeSize";
            // 
            // DeviceMode
            // 
            this.DeviceMode.HeaderText = "Mode";
            this.DeviceMode.Name = "DeviceMode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 382);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Partition Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(779, 326);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(517, 326);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.wizardToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.diskToolStripMenuItem,
            this.partitionToolStripMenuItem,
            this.dynamicDiskToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(779, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadDisksToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // reloadDisksToolStripMenuItem
            // 
            this.reloadDisksToolStripMenuItem.Name = "reloadDisksToolStripMenuItem";
            this.reloadDisksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadDisksToolStripMenuItem.Text = "Reload Disk";
            this.reloadDisksToolStripMenuItem.Click += new System.EventHandler(this.reloadDiskToolStripMenuItem_Click);
            // 
            // wizardToolStripMenuItem
            // 
            this.wizardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.migrateOSToSSDHDDToolStripMenuItem,
            this.copyPartitionToolStripMenuItem,
            this.copyDiskToolStripMenuItem,
            this.partitionRecoveryToolStripMenuItem});
            this.wizardToolStripMenuItem.Name = "wizardToolStripMenuItem";
            this.wizardToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.wizardToolStripMenuItem.Text = "Wizard";
            // 
            // migrateOSToSSDHDDToolStripMenuItem
            // 
            this.migrateOSToSSDHDDToolStripMenuItem.Name = "migrateOSToSSDHDDToolStripMenuItem";
            this.migrateOSToSSDHDDToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.migrateOSToSSDHDDToolStripMenuItem.Text = "Migrate OS to SSD/HDD";
            // 
            // copyPartitionToolStripMenuItem
            // 
            this.copyPartitionToolStripMenuItem.Name = "copyPartitionToolStripMenuItem";
            this.copyPartitionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.copyPartitionToolStripMenuItem.Text = "Copy Partition";
            // 
            // copyDiskToolStripMenuItem
            // 
            this.copyDiskToolStripMenuItem.Name = "copyDiskToolStripMenuItem";
            this.copyDiskToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.copyDiskToolStripMenuItem.Text = "Copy Disk";
            // 
            // partitionRecoveryToolStripMenuItem
            // 
            this.partitionRecoveryToolStripMenuItem.Name = "partitionRecoveryToolStripMenuItem";
            this.partitionRecoveryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.partitionRecoveryToolStripMenuItem.Text = "Partition Recovery";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // diskToolStripMenuItem
            // 
            this.diskToolStripMenuItem.Name = "diskToolStripMenuItem";
            this.diskToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.diskToolStripMenuItem.Text = "Disk";
            // 
            // partitionToolStripMenuItem
            // 
            this.partitionToolStripMenuItem.Name = "partitionToolStripMenuItem";
            this.partitionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.partitionToolStripMenuItem.Text = "Partition";
            // 
            // dynamicDiskToolStripMenuItem
            // 
            this.dynamicDiskToolStripMenuItem.Name = "dynamicDiskToolStripMenuItem";
            this.dynamicDiskToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.dynamicDiskToolStripMenuItem.Text = "Dynamic Disk";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Backup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationsPending});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(252, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Undo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OperationsPending
            // 
            this.OperationsPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OperationsPending.HeaderText = "Operations Pending";
            this.OperationsPending.Name = "OperationsPending";
            this.OperationsPending.ReadOnly = true;
            this.OperationsPending.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartitionColumn,
            this.CapacityColumn,
            this.UsedColumn,
            this.UnusedColumn,
            this.FileSystemColumn,
            this.TypeColumn,
            this.StatusColumn});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(517, 142);
            this.dataGridView2.TabIndex = 0;
            // 
            // PartitionColumn
            // 
            this.PartitionColumn.HeaderText = "Partition";
            this.PartitionColumn.Name = "PartitionColumn";
            this.PartitionColumn.ReadOnly = true;
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.ReadOnly = true;
            // 
            // UsedColumn
            // 
            this.UsedColumn.HeaderText = "Used";
            this.UsedColumn.Name = "UsedColumn";
            this.UsedColumn.ReadOnly = true;
            // 
            // UnusedColumn
            // 
            this.UnusedColumn.HeaderText = "Unused";
            this.UnusedColumn.Name = "UnusedColumn";
            this.UnusedColumn.ReadOnly = true;
            // 
            // FileSystemColumn
            // 
            this.FileSystemColumn.HeaderText = "File System";
            this.FileSystemColumn.Name = "FileSystemColumn";
            this.FileSystemColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(174, 443);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 585);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.deviceGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanDrivesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView deviceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadDisksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrateOSToSSDHDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partitionRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dynamicDiskToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationsPending;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartitionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnusedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSystemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

