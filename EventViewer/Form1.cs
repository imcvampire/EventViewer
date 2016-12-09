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

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            eventLog1.Source = "Event Log Test 1";

            eventLog1.WriteEntry("Log is written.");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine(e.Node);
        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
