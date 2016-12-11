namespace EventViewer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Application");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("System");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Security");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AccessibleDescription = "Log";
            this.treeView1.AccessibleName = "Log";
            this.treeView1.Location = new System.Drawing.Point(20, 10);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Application";
            treeNode1.Text = "Application";
            treeNode2.Name = "System";
            treeNode2.Text = "System";
            treeNode3.Name = "Security";
            treeNode3.Text = "Security";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(149, 395);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // eventLog1
            // 
            this.eventLog1.Log = global::EventViewer.Properties.Settings.Default.Application;
            this.eventLog1.Source = global::EventViewer.Properties.Settings.Default.Application;
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.ID,
            this.Message,
            this.Source});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(175, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(829, 395);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 57;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Message.Width = 498;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Width = 86;
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Source.Width = 178;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(EventViewer.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 423);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Event Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Source;
    }
}

