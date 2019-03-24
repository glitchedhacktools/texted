using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace texted
{
    public partial class bookmarksWindow : Form
    {
        string[] csvLines;
        string path_CSV = "";
        Form1 mainForm;


        public bookmarksWindow(Form1 Form1)
        {
            mainForm = Form1;
            InitializeComponent();
            if (Properties.Settings.Default.lastBookmarkPath != "none")
            {
                path_CSV = Properties.Settings.Default.lastBookmarkPath;
                getDataFromPath(path_CSV);
            }
        }

        private void getDataFromPath(string path)
        {
            int i, offset;
            CSV_Import single_entry;
            path_CSV = path;
            csvLines = File.ReadAllLines(@path_CSV, Encoding.GetEncoding(1252));
            csvLines = csvLines.Skip(1).ToArray();
            offsetListBox.Items.Clear();
            mainForm.data_CSV.Clear();
            for (i = 0; i < csvLines.Count(); i++)
            {
                single_entry = new CSV_Import();
                single_entry.Offset = Int32.Parse(csvLines[i].Split(';')[0].Remove(0, 2), System.Globalization.NumberStyles.HexNumber);
                if (csvLines[i].Split(';')[1] == "Y") single_entry.Changed = true;
                if (csvLines[i].Split(';')[1] == "N") single_entry.Changed = false;
                if (csvLines[i].Split(';')[2] == "") single_entry.Repoint = 0;
                if (csvLines[i].Split(';')[2] != "") single_entry.Repoint = Int32.Parse(csvLines[i].Split(';')[2].Remove(0, 2), System.Globalization.NumberStyles.HexNumber);
                single_entry.Text = csvLines[i].Split(';')[3];
                mainForm.data_CSV.Add(single_entry);
            }

            for (i = 0; i < mainForm.data_CSV.Count(); i++)
            {
                if (mainForm.data_CSV[i].Repoint != 0)
                {
                    offset = mainForm.data_CSV[i].Repoint;
                }
                else
                {
                    offset = mainForm.data_CSV[i].Offset;
                }
                offsetListBox.Items.Add(offset.ToString("X6") + "\t   " + mainForm.data_CSV[i].Text);
            }
            addOffsetButton.Enabled = true;
            addCsvToBookmarksButton.Enabled = true;
            loadOffsetButton.Enabled = true;
            Properties.Settings.Default.lastBookmarkPath = path_CSV;
            Properties.Settings.Default.Save();
        }

        private void getDataFromCsv()
        {
            if (openCSV.ShowDialog() == DialogResult.OK)
            {
                getDataFromPath(openCSV.FileName);
            }
        }

        private void importCsvAtClick(object sender, EventArgs e)
        {
            getDataFromCsv();
        }

        private void sendOffsetOnClick(object sender, EventArgs e)
        {
            string bookmarkText = offsetListBox.SelectedItem.ToString();
            int toLoad = Int32.Parse(bookmarkText.Remove(6,bookmarkText.Length-6), System.Globalization.NumberStyles.HexNumber);
            mainForm.Focus();
            mainForm.loadOffset(toLoad);
            mainForm.offsetBox.Value = toLoad;
        }

        private void addNewOffsetToListOnClick(object sender, EventArgs e)
        {
            int offset = (int)mainForm.offsetBox.Value;
            CSV_Import single_entry;
            csvLines = File.ReadAllLines(@path_CSV, Encoding.GetEncoding(1252));
            csvLines = csvLines.Skip(1).ToArray();
            single_entry = new CSV_Import();
            single_entry.Offset = offset;
            single_entry.Changed = false;
            single_entry.Repoint = 0;
            single_entry.Text = mainForm.textBox.Text;
            mainForm.data_CSV.Add(single_entry);
            offsetListBox.Items.Add(offset.ToString("X6") + "\t   " + mainForm.data_CSV[mainForm.data_CSV.Count-1].Text);
            mainForm.saveCsvAfterEditing(path_CSV);
        }

        
    }
}
