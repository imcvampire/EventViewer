using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventViewer
{
    public partial class EventViewer : Form
    {
        public EventViewer()
        {
            InitializeComponent();
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void EventViewerLoad(object sender, EventArgs e)
		{
			this.eventLog.Log = "Application";
		}

		private void eventLog_EntryWritten(object sender, EntryWrittenEventArgs e)
		{

		}

		private void logButton_Click(object sender, EventArgs e)
		{
			foreach (EventLogEntry entry in this.eventLog.Entries)
			{
				Console.WriteLine(entry.Message);
			}
		}
	}
}
