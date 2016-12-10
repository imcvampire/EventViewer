namespace EventViewer
{
    partial class EventViewer
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
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Applications");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Security");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Setup");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("System");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Events", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
			this.eventLog = new System.Diagnostics.EventLog();
			this.treeView = new System.Windows.Forms.TreeView();
			this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox = new System.Windows.Forms.TextBox();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.logButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// eventLog
			// 
			this.eventLog.SynchronizingObject = this;
			this.eventLog.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog_EntryWritten);
			// 
			// treeView
			// 
			this.treeView.Location = new System.Drawing.Point(11, 12);
			this.treeView.Margin = new System.Windows.Forms.Padding(2);
			this.treeView.Name = "treeView";
			treeNode6.Name = "Applications";
			treeNode6.Text = "Applications";
			treeNode7.Name = "Security";
			treeNode7.Text = "Security";
			treeNode8.Name = "Setup";
			treeNode8.Text = "Setup";
			treeNode9.Name = "System";
			treeNode9.Text = "System";
			treeNode10.Name = "Events";
			treeNode10.Text = "Events";
			this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
			this.treeView.Size = new System.Drawing.Size(158, 423);
			this.treeView.TabIndex = 0;
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
			// 
			// formBindingSource
			// 
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(174, 12);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(830, 423);
			this.textBox.TabIndex = 1;
			// 
			// logButton
			// 
			this.logButton.Location = new System.Drawing.Point(929, 441);
			this.logButton.Name = "logButton";
			this.logButton.Size = new System.Drawing.Size(75, 23);
			this.logButton.TabIndex = 2;
			this.logButton.Text = "Log";
			this.logButton.UseVisualStyleBackColor = true;
			this.logButton.Click += new System.EventHandler(this.logButton_Click);
			// 
			// EventViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 476);
			this.Controls.Add(this.logButton);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.treeView);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EventViewer";
			this.Text = "Event Viewer";
			this.Load += new System.EventHandler(this.EventViewerLoad);
			((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.BindingSource formBindingSource;
        private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.Button logButton;
	}
}

