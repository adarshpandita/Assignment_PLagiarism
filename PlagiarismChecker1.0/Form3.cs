using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace PlagiarismChecker1._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            object wordTrue = (object)true;
            object wordFalse = (object)false;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word.Document doc1 = wordApp.Documents.Open(textBox1.Text, ref missing, ref wordFalse, ref wordFalse, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref wordTrue, ref missing, ref missing, ref missing, ref missing);

            // read 2nd document 
            Microsoft.Office.Interop.Word.Document doc2 = wordApp.Documents.Open(textBox2.Text, ref missing, ref wordFalse, ref wordFalse, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            // compare the two documents 
            Microsoft.Office.Interop.Word.Document doc = wordApp.CompareDocuments(doc1, doc2, WdCompareDestination.wdCompareDestinationNew, WdGranularity.wdGranularityWordLevel, true, true, true, true, true, true, true, true, true, true, "", false);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;

            }
        }
    }
}
