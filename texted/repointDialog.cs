using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texted
{
    public partial class repointDialog : Form
    {
        List<int> ptrList = new List<int>();
        public repointDialog()
        {
            InitializeComponent();
            currentOffsetBox.Maximum = Form1.ROM.Length;
            newOffsetBox.Maximum = Form1.ROM.Length;
            searchStartBox.Maximum = Form1.ROM.Length;
            progressBar.Maximum = Form1.ROM.Length - 4;
            searchStartBox.Value = 0x700000;
            currentOffsetBox.Value = data.currentOffset;
            ptrList.Clear();
        }

        private void searchFreeSpace(object sender, EventArgs e)
        {
            byte[] freespace = new byte[Form1.currentLenght + 1];
            int i;
            int offset = (int)searchStartBox.Value;
            for (i = 0; i < freespace.Length; i++)
            {
                freespace[i] = 0xFF;
            }
            if (freeOffsetList.Items.Count == 0)
            {
                while (checkFreeSpace(Form1.ROM, freespace, offset)==false)
                {
                    offset++;
                }
                freeOffsetList.Items.Add(offset.ToString("X6"));
            }
            else
            {
                offset = int.Parse(freeOffsetList.Items[freeOffsetList.Items.Count - 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                offset += freespace.Length;
                while (checkFreeSpace(Form1.ROM, freespace, offset) == false)
                {
                    offset++;
                }
                freeOffsetList.Items.Add(offset.ToString("X6"));
            }
        }
        private bool checkFreeSpace(byte[] rom, byte[] free, int offset)
        {
            int i,j=0;
            for (i = 0; i < free.Length; i++)
            {
                if (rom[offset+i] == free[i]) j++;
            }
            if (j == free.Length) return true;
            return false;
        }
        private void selectAsNewOffset(object sender, EventArgs e)
        {
            if (freeOffsetList.Items.Count != 0)
            {
                newOffsetBox.Value = int.Parse(freeOffsetList.Items[freeOffsetList.SelectedIndex].ToString(), System.Globalization.NumberStyles.HexNumber);
            }
        }
        private void findPointers(int oldOffset)
        {
            int i, j = 0;
            byte[] ptr = getPtr(oldOffset);
            for (i = 0; i < Form1.ROM.Length-4; i++)
            {
                if (i % 10 == 0)
                {
                    progressBar.Value = i;
                    Application.DoEvents();
                }
                if (Form1.ROM[i] == ptr[0]) j++;
                if (Form1.ROM[i+1] == ptr[1]) j++;
                if (Form1.ROM[i+2] == ptr[2]) j++;
                if (Form1.ROM[i+3] == ptr[3]) j++;
                if (j == 4)
                {
                    ptrList.Add(i);
                    pointerList.Items.Add(i.ToString("X6"));
                    j = 0;
                }
                else
                {
                    j = 0;
                }
            }
        }
        private byte[] getPtr(int offset)
        {
            int dir = offset;
            byte[] ptr = new byte[4];
            ptr[1] = (byte)(dir % 0x100);
            dir /= 0x100;
            ptr[2] = (byte)(dir % 0x100);
            dir /= 0x100;
            ptr[3] = (byte)(dir % 0x100);
            dir /= 0x100;
            ptr[0] = (byte)(dir % 0x100 + 0x08);
            return ptr;
        }

        private void scanPtr(object sender, EventArgs e)
        {
            pointerList.Items.Clear();
            groupBox3.Text = "Scanning pointers...";
            ptrList.Clear();
            findPointers((int)currentOffsetBox.Value);
            groupBox3.Text = "Pointers found";
            if (pointerList.Items.Count == 0)
            {
                MessageBox.Show("This string hasn't got any pointer. It can't be repointed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
        }

        private void checkNewOffset(object sender, EventArgs e)
        {
            if (newOffsetBox.Value == 0 || newOffsetBox.Value == currentOffsetBox.Value || pointerList.Items.Count == 0)
            {
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
        }

        private void saveAndRepoint(object sender, EventArgs e)
        {
            //Save
            data.writeAt(data.hexbox.Split(' '), (int)newOffsetBox.Value);
            //Repoint
            string log = "";
            int i, j;
            byte[] newPtr;
            for (i = 0; i < ptrList.Count; i++)
            {
                newPtr = getPtr((int)newOffsetBox.Value);
                log += "Pointer at " + ptrList[i].ToString("X6") + " changed from [" + Form1.ROM[ptrList[i] + 0].ToString("X2") + " " + Form1.ROM[ptrList[i] + 1].ToString("X2") + " " + Form1.ROM[ptrList[i] + 2].ToString("X2") + " " + Form1.ROM[ptrList[i] + 3].ToString("X2") + "]" + " to [" + newPtr[0].ToString("X2") + " " + newPtr[1].ToString("X2") + " " + newPtr[2].ToString("X2") + " " + newPtr[3].ToString("X2") + "]." + Environment.NewLine;
                for (j = 0; j < 4; j++)
                {
                    Form1.ROM[ptrList[i] + j] = newPtr[j];
                }
            }
            Form1.logPath += "log_" + data.currentOffset.ToString("X6") + ".txt";
            File.WriteAllText(@Form1.logPath, log);
            File.WriteAllBytes(@Form1.path, Form1.ROM);
            MessageBox.Show(log + "A log file was created at " + Form1.logPath, "Repoint successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.currentOffset = (int)newOffsetBox.Value;
            Close();
        }
    }
}
