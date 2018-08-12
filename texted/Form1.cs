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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] ROM;
        string path;
        int offsetSize;
        int currentLenght;
        bool loaded = false;
        bool insert = true;

        private void loadRom(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                ROM = File.ReadAllBytes(@path);
                goButton.Enabled = true;
                offsetBox.Maximum = ROM.Length-1;
            }
        }

        private void loadOffset(object sender, EventArgs e)
        {
            int offset = (int)offsetBox.Value;
            int i = offset;
            string text = "";
            loaded = false;
            textBox.Clear();
            hexBox.Clear();
            do
            {
                hexBox.Text += ROM[i].ToString("X2") + " ";
                i++;
            } while (ROM[i] != 0xFF || i == ROM.Length);
            i = offset;
            do
            {
                switch (ROM[i])
                {
                    case 0xFA: text += "\\l"; break;
                    case 0xFB: text += "\\p"; break;
                    case 0xFC:
                        i++;
                        switch (ROM[i])
                        {
                            case 0x01: i++; text += "[color" + ROM[i] + "]"; break;
                            case 0x02: i++; text += "[highlight" + ROM[i] + "]"; break;
                            case 0x03: i++; text += "[shadowcolor" + ROM[i] + "]"; break;
                            case 0x08: i++; text += "[pause" + ROM[i] + "]"; break;
                            case 0x09: text += "[pausebutton]"; break;
                            case 0x10: i++; text += "[playsong" + int.Parse(ROM[i + 1].ToString("X2")) + (ROM[i].ToString("X2")).ToString() + "]"; i++; break;
                            case 0x17: text += "[pausesong]"; break;
                            case 0x18: text += "[resumesong]"; break;
                            default: text += "[hFC]"; text += HexToString(ROM[i]); break;
                        }
                        break;
                    case 0xFD: i++; text += "[v" + ROM[i] + "]"; break;
                    case 0xFE: text += "\\n"; break;
                    default: text += HexToString(ROM[i]); break;
                }
                i++;
            } while (ROM[i] != 0xFF || i == ROM.Length);
            offsetSize = countText(text);
            textBox.Text = text;
            getCounter();
            loaded = true;
            updatePreview(text);
        }

        private int countText(string text)
        {
            bool count = true;
            int i, j = 0;
            for (i = 0; i < text.Length; i++)
            {
                if (count)
                {
                    if (text[i] == '[') count = false;
                    if (text[i] == '\\') j--;
                    j++;
                }
                else
                {
                    if (text[i] == ']')
                    {
                        count = true;
                        j++;
                    }
                }
            }
            return j;
        }

        private void updatePreview(string text)
        {
            prevBox.Clear();
            int i;
            for (i = 0; i < text.Length; i++)
            {
                if (text[i] == '\\')
                {
                    i++;
                    try
                    {
                        if (text[i] == 'p' || text[i] == 'n' || text[i] == 'l') prevBox.Text += Environment.NewLine;
                    }
                    catch
                    {

                    }
                }
                else
                {
                    prevBox.Text += text[i];
                }
                
            }
        }
        
        private string HexToString(int b)
        {
            string result = "";
            string type = "NONE";
            if (b >= 0xBB && b <= 0xD4) type = "MAYUS";
            if (b >= 0xD5 && b <= 0xEE) type = "MINUS";
            if (b >= 0xA1 && b <= 0xAA) type = "NUM";
            switch (b)
            {
                case 0x00: return " ";
                case 0x01: return "À";
                case 0x02: return "Á";
                case 0x03: return "Â";
                case 0x04: return "Ç";
                case 0x05: return "È";
                case 0x06: return "É";
                case 0x07: return "Ê";
                case 0x08: return "Ë";
                case 0x09: return "Ì";
                case 0x0B: return "Î";
                case 0x0C: return "Ï";
                case 0x0D: return "Ò";
                case 0x0E: return "Ó";
                case 0x0F: return "Ô";
                case 0x10: return "Œ";
                case 0x11: return "Ù";
                case 0x12: return "Ú";
                case 0x13: return "Û";
                case 0x14: return "Ñ";
                case 0x15: return "ß";
                case 0x16: return "à";
                case 0x17: return "á";
                case 0x19: return "ç";
                case 0x1A: return "è";
                case 0x1B: return "é";
                case 0x1C: return "ê";
                case 0x1D: return "ë";
                case 0x1E: return "ì";
                case 0x20: return "î";
                case 0x21: return "ï";
                case 0x22: return "ò";
                case 0x23: return "ó";
                case 0x24: return "ô";
                case 0x25: return "œ";
                case 0x26: return "ù";
                case 0x27: return "ú";
                case 0x28: return "û";
                case 0x29: return "ñ";
                case 0x2A: return "º";
                case 0x2B: return "ª";
                case 0x2C: return "ᵉʳ";
                case 0x2D: return "&";
                case 0x2E: return "+";
                case 0x34: return "[LV]";
                case 0x35: return "=";
                case 0x36: return ";";
                case 0x50: return "▯";
                case 0x51: return "¿";
                case 0x52: return "¡";
                case 0x53: return "[PK]";
                case 0x54: return "[MN]";
                case 0x55: return "[PO]";
                case 0x56: return "[KE]";
                case 0x57: return "[BL]";
                case 0x58: return "[OC]";
                case 0x59: return "[K]";
                case 0x5A: return "Í";
                case 0x5B: return "%";
                case 0x5C: return "(";
                case 0x5D: return ")";
                case 0x68: return "â";
                case 0x6F: return "í";
                case 0x79: return "[U]";
                case 0x7A: return "[D]";
                case 0x7B: return "[L]";
                case 0x7C: return "[R]";
                case 0x84: return "ᵉ";
                case 0x85: return "<";
                case 0x86: return ">";
                case 0xA0: return "ʳᵉ";
                case 0xAB: return "!";
                case 0xAC: return "?";
                case 0xAD: return ".";
                case 0xAE: return "-";
                case 0xAF: return "·";
                case 0xB0: return "…";
                case 0xB1: return "“";
                case 0xB2: return "”";
                case 0xB3: return "‘";
                case 0xB4: return "’";
                case 0xB5: return "♂";
                case 0xB6: return "♀";
                case 0xB7: return "₽";
                case 0xB8: return ",";
                case 0xB9: return "×";
                case 0xBA: return "/";
                case 0xEF: return "▶";
                case 0xF0: return ":";
                case 0xF1: return "Ä";
                case 0xF2: return "Ö";
                case 0xF3: return "Ü";
                case 0xF4: return "ä";
                case 0xF5: return "ö";
                case 0xF6: return "ü";
                default:
                    switch (type)
                    {
                        case "MAYUS": result += (char)(b - 0x7A); return result;
                        case "MINUS": result += (char)(b - 0x74); return result;
                        case "NUM": result += (char)(b - 0x71); return result;
                        default: result += "[h" + b.ToString("X2") + "]"; return result;
                    }
            }
        }

        private void editText(object sender, EventArgs e)
        {
            if (loaded) getCounter();
            if (loaded) updateHex();
            if (loaded) updatePreview(textBox.Text);
        }

        private void getCounter()
        {
            currentLenght = countText(textBox.Text);
            counter.Text = currentLenght.ToString() + "/" + offsetSize.ToString();
            if (currentLenght > offsetSize)
            {
                    counter.ForeColor = Color.Red;
            }
            else
            {
                    counter.ForeColor = Color.Black;
            }
        }

        private void updateHex()
        {
            int i, j;
            string[] command = new string[2];
            string hex = "";
            string text = textBox.Text;
            hexBox.Clear();
            for (i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '[':
                        try{
                        command[0] = "";
                        command[1] = "";
                        hex = "";
                        i++;
                        while (text[i] != ']')
                        {
                            hex += text[i];
                            if (text[i] >= 48 && text[i] <= 57) command[1] += text[i];
                            else command[0] += text[i];
                            i++;
                        }
                        switch (command[0])
                        {
                            case "color":
                                hexBox.Text += "FC 01 " + int.Parse(command[1]).ToString("X2") + " ";
                                break;
                            case "highlight":
                                hexBox.Text += "FC 02 " + int.Parse(command[1]).ToString("X2") + " ";
                                break;
                            case "shadowcolor":
                                hexBox.Text += "FC 03 " + int.Parse(command[1]).ToString("X2") + " ";
                                break;
                            case "pause":
                                hexBox.Text += "FC 08 " + int.Parse(command[1]).ToString("X2") + " ";
                                break;
                            case "pausebutton":
                                hexBox.Text += "FC 09 ";
                                break;
                            case "playsong":
                                command[1] = int.Parse(command[1], System.Globalization.NumberStyles.HexNumber).ToString("X4");
                                hexBox.Text += (((("FC 10 " + command[1][2]) + command[1][3]) + " ") + command[1][0]) + command[1][1] + " ";
                                break;
                            case "pausesong":
                                hexBox.Text += "FC 17 ";
                                break;
                            case "resumesong":
                                hexBox.Text += "FC 18 ";
                                break;
                            case "v":
                                hexBox.Text += "FD " + int.Parse(command[1]).ToString("X2") + " ";
                                break;
                            case "LV": hexBox.Text += "34 "; break;
                            case "PK": hexBox.Text += "53 "; break;
                            case "MN": hexBox.Text += "54 "; break;
                            case "PO": hexBox.Text += "55 "; break;
                            case "KE": hexBox.Text += "56 "; break;
                            case "BL": hexBox.Text += "57 "; break;
                            case "OC": hexBox.Text += "58 "; break;
                            case "K": hexBox.Text += "59 "; break;
                            case "U": hexBox.Text += "79 "; break;
                            case "D": hexBox.Text += "7A "; break;
                            case "L": hexBox.Text += "7B "; break;
                            case "R": hexBox.Text += "7C "; break;
                            default:
                                if (command[0][0] == 'h')
                                {
                                    hex = hex.Remove(0, 1);
                                    hexBox.Text += hex + " ";
                                }
                                else hexBox.Text += "00 ";
                                break;
                        }
                        //i++;
                        }catch{}
                        break;
                    case '\\':
                        i++;
                        try
                        {
                            switch (text[i])
                            {
                                case 'l': hexBox.Text += "FA "; break;
                                case 'p': hexBox.Text += "FB "; break;
                                case 'n': hexBox.Text += "FE "; break;
                                default: break;
                            }
                        }
                        catch
                        {

                        }
                        break;
                    case 'ᵉ':
                        if (text[i + 1] == 'ʳ')
                        {
                            i++;
                            hexBox.Text += "0x2C ";
                            break;
                        }
                        hexBox.Text += "0x84 ";
                        break;
                    case 'ʳ': i++; hexBox.Text += "0xA0 "; break;
                    default: hexBox.Text += charToHex(text[i]).ToString("X2") + " "; break;
                }
                
            }
        }

        private int charToHex(char c)
        {
            string type = "NONE";
            if (c >= 0x41 && c <= 0x5A) type = "MAYUS";
            if (c >= 0x61 && c <= 0x7A) type = "MINUS";
            if (c >= 0x30 && c <= 0x39) type = "NUM";
            switch (c)
            {
                case ' ': return 0x00;
                case 'À': return 0x01;
                case 'Á': return 0x02;
                case 'Â': return 0x03;
                case 'Ç': return 0x04;
                case 'È': return 0x05;
                case 'É': return 0x06;
                case 'Ê': return 0x07;
                case 'Ë': return 0x08;
                case 'Ì': return 0x09;
                case 'Î': return 0x0B;
                case 'Ï': return 0x0C;
                case 'Ò': return 0x0D;
                case 'Ó': return 0x0E;
                case 'Ô': return 0x0F;
                case 'Œ': return 0x10;
                case 'Ù': return 0x11;
                case 'Ú': return 0x12;
                case 'Û': return 0x13;
                case 'Ñ': return 0x14;
                case 'ß': return 0x15;
                case 'à': return 0x16;
                case 'á': return 0x17;
                case 'ç': return 0x19;
                case 'è': return 0x1A;
                case 'é': return 0x1B;
                case 'ê': return 0x1C;
                case 'ë': return 0x1D;
                case 'ì': return 0x1E;
                case 'î': return 0x20;
                case 'ï': return 0x21;
                case 'ò': return 0x22;
                case 'ó': return 0x23;
                case 'ô': return 0x24;
                case 'œ': return 0x25;
                case 'ù': return 0x26;
                case 'ú': return 0x27;
                case 'û': return 0x28;
                case 'ñ': return 0x29;
                case 'º': return 0x2A;
                case 'ª': return 0x2B;
                case '&': return 0x2D;
                case '+': return 0x2E;
                case '=': return 0x35;
                case ';': return 0x36;
                case '▯': return 0x50;
                case '¿': return 0x51;
                case '¡': return 0x52;
                case 'Í': return 0x5A;
                case '%': return 0x5B;
                case '(': return 0x5C;
                case ')': return 0x5D;
                case 'â': return 0x68;
                case 'í': return 0x6F;
                case '<': return 0x85;
                case '>': return 0x86;
                case '!': return 0xAB;
                case '?': return 0xAC;
                case '.': return 0xAD;
                case '-': return 0xAE;
                case '·': return 0xAF;
                case '…': return 0xB0;
                case '“': return 0xB1;
                case '”': return 0xB2;
                case '‘': return 0xB3;
                case '’': return 0xB4;
                case '♂': return 0xB5;
                case '♀': return 0xB6;
                case '₽': return 0xB7;
                case ',': return 0xB8;
                case '×': return 0xB9;
                case '/': return 0xBA;
                case '▶': return 0xEF;
                case ':': return 0xF0;
                case 'Ä': return 0xF1;
                case 'Ö': return 0xF2;
                case 'Ü': return 0xF3;
                case 'ä': return 0xF4;
                case 'ö': return 0xF5;
                case 'ü': return 0xF6;
                default:
                    switch (type)
                    {
                        case "MAYUS": return c + 0x7A;
                        case "MINUS": return c + 0x74;
                        case "NUM": return c + 0x71;
                        default: return 0;
                    }
            }
        }

        private void toggleInsSob(object sender, EventArgs e)
        {
            if (insert)
            {
                insert = false;
                insertSobButton.Text = "SOB";
            }
            else
            {
                insert = true;
                insertSobButton.Text = "INS";
            }
        }

        private void overwriteText(object sender, KeyPressEventArgs e)
        {
            int sel;
            if (insert == false)
            {
                sel = textBox.SelectionStart;
                if(sel<textBox.Text.Length) textBox.Text = textBox.Text.Remove(sel, 1);
                textBox.SelectionStart = sel;
            }
        }

        private void saveChanges(object sender, EventArgs e)
        {
            int[] newBytes = new int[currentLenght];
            int i, j=0;
            string[] hex;
            if (currentLenght <= offsetSize)
            {
                hex = hexBox.Text.Split(' ');
                for (i = 0; i < hex.Length-1; i++)
                {
                    j = (int)offsetBox.Value + i;
                    ROM[j] = (byte)int.Parse(hex[i], System.Globalization.NumberStyles.HexNumber);
                }
                ROM[j + 1] = 0xFF;
                File.WriteAllBytes(@path, ROM);
            }
            else
            {
                MessageBox.Show("The text you entered is longer that the previous one. Continuing may replace important bytes.", "Saving", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //Repoint
            }
        }
    }
}
