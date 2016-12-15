using System;
using System.Diagnostics;
using System.IO;
using System.Text;
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
            toolStripProgressBar1.Value = 0;

            for (int i = 0; i < 10; i++)
            {
                this.printEntries((eventLog1.Entries.Count / 10) * i);
            }

            // FIXME: Print ...

            for (int i = (eventLog1.Entries.Count / 10) * 10; i < eventLog1.Entries.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].InstanceId.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].Message);
                listViewItem.SubItems.Add(eventLog1.Entries[i].Source);
                listViewItem.SubItems.Add(eventLog1.Entries[i].TimeGenerated.ToLongDateString());
                listView1.Items.Insert(0, listViewItem);
            }
        }

        private void printEntries(int startIndex, int times = 10)
        {
            for (int index = 0; index < eventLog1.Entries.Count / 10; index++)
            {
                int i = index + startIndex;

                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].InstanceId.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].Message);
                listViewItem.SubItems.Add(eventLog1.Entries[i].Source);
                listViewItem.SubItems.Add(eventLog1.Entries[i].TimeGenerated.ToLongDateString());
                listView1.Items.Insert(0, listViewItem);
            }

            toolStripProgressBar1.Increment(10);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = new StringBuilder();
            message.AppendLine("Event Viewer");
            message.AppendLine("Version: 1.0.0");
            message.AppendLine("View monitoring and troubleshooting messages from windows and other programs");
            MessageBox.Show(message.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            sw.WriteLine(
                                "{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                                item.SubItems[0].Text,
                                ",",
                                item.SubItems[1].Text,
                                ",",
                                item.SubItems[2].Text,
                                ",",
                                item.SubItems[3].Text,
                                ",",
                                item.SubItems[4].Text
                            );
                        }
                    }
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            toolStripProgressBar1.Value = 0;

            for (int i = 0; i < 10; i++)
            {
                this.printEntries((eventLog1.Entries.Count / 10) * i);
            }

            // FIXME: Print ...

            for (int i = (eventLog1.Entries.Count / 10) * 10; i < eventLog1.Entries.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].InstanceId.ToString());
                listViewItem.SubItems.Add(eventLog1.Entries[i].Message);
                listViewItem.SubItems.Add(eventLog1.Entries[i].Source);
                listViewItem.SubItems.Add(eventLog1.Entries[i].TimeGenerated.ToLongDateString());
                listView1.Items.Insert(0, listViewItem);
            }
        }
       
    }
}
