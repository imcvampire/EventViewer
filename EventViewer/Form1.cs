using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventLog1.Log = "Application";
            eventLog1.Source = "Event Viewer";
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            eventLog1.Log = "Application";
            eventLog1.Source = "Event Viewer";

            eventLog1.WriteEntry("Log is written.");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            eventLog1.Log = e.Node.Name;

            listView1.Items.Clear();
          
            for (int i = 0; i < eventLog1.Entries.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].InstanceId.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].Message);
                listViewItem.SubItems.Add(eventLog1.Entries[i].Source);
                listView1.Items.Add(listViewItem);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }
    }
}
