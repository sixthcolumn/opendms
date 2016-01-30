using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Displays log entries
    /// </summary>
    public partial class LogControl : UserControl
    {
        List<Entry> entries = new List<Entry>();
        public enum entryType { OK = 0, FAIL = 1 };

        public LogControl()
        {
            InitializeComponent();
            listView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(listItem_selected);

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            listView.Columns.Add(header);
            listView.Scrollable = true;
            listView.View = View.Details;
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Displays the log message when user selects from shortcust list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listItem_selected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                int i = item.Index;
               textBox.Text =  entries.ElementAt<Entry>(i).LogEntry;
            }
        }

        /// <summary>
        /// Add new entry to the log
        /// </summary>
        /// <param name="date">date of entry</param>
        /// <param name="logType">OK, Fail - display green or red bar to left</param>
        /// <param name="title">short title for log message</param>
        /// <param name="logEntry">long log entry</param>
        public void addEntry(DateTime date, entryType logType, String title, string logEntry)
        {
            Entry e = new Entry(date, logType, title, logEntry);
            entries.Add(e);
            listView.Items.Add(e.getListTitle(), e.getImageIndex());
        }

        public void addEntry(entryType logType, String title, string logEntry)
        {
            addEntry(DateTime.Now, logType, title, logEntry);
        }

        /// <summary>
        /// Clears out the log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            listView.Clear();
            textBox.Clear();
            entries.Clear();
        }

        /// <summary>
        /// Copies currently selected log entry to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                int i = item.Index;
                Clipboard.SetText(entries.ElementAt<Entry>(i).LogEntry);
            }
        }

        /// <summary>
        /// private class, contains a single log entry
        /// </summary>
        private class Entry
        {
            private DateTime date;
            private entryType logType;
            private string title;
            private string logEntry;

            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }

            public String getListTitle()
            {
                String format = "MM/dd/yyyy HH:mm::ss" ;
                return Date.ToString(format) + " : " + title;
            }

            public int getImageIndex() {
                return Array.IndexOf(Enum.GetValues(LogType.GetType()), LogType);
            }

            public entryType LogType
            {
                get { return logType; }
                set { logType = value; }
            }

            public Entry(DateTime date, entryType et, string message, string text)
            {
                Date = date;
                LogType = et;
                this.title = message;
                this.logEntry = text;
            }

            public String Title
            {
                get { return title; }
                set { title = value; }
            }

            public String LogEntry
            {
                get { return logEntry; }
                set { logEntry = value; }
            }
        }

    }

}
