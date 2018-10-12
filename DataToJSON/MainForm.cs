using System;
using System.IO;
using System.Windows.Forms;

namespace DataToJSON
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CbSentence_CheckedChanged(object sender, EventArgs e)
        {
            tbSentence.Enabled = !cbSentence.Checked;
        }

        private void CbAuth_CheckedChanged(object sender, EventArgs e)
        {
            tbAuth.Enabled = cbAuthMe.Enabled = !cbAuth.Checked;
        }

        private void CbAuthMe_CheckedChanged(object sender, EventArgs e)
        {
            tbAuth.Enabled = !cbAuthMe.Checked;
        }

        private void CbDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = !cbDate.Checked;
        }

        private void CbGroup_CheckedChanged(object sender, EventArgs e)
        {
            clbOptinalGroups.Enabled = gbImportance.Enabled = !cbGroup.Checked;
        }
        
        private void CbUrl_CheckedChanged(object sender, EventArgs e)
        {
            tbUrl.Enabled = !cbUrl.Checked;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string data = "{";
            data += "\"sentence\":\"" + (!cbSentence.Checked ? tbSentence.Text.ToString() : "") + "\",";
            data += "\"url\":\"" + (!cbUrl.Checked ? tbUrl.Text.ToString() : "") + "\",";
            data += "\"auth\":\"" + (!cbAuth.Checked ? (cbAuthMe.Checked ? "'Y.E.'" : tbAuth.Text.ToString()) : "") + "\",";
            data += "\"date\":\"" + (!cbDate.Checked ? dtpDate.Value.ToString() : "") + "\",";

            data += "\"groups\":[";
            if (cbGroup.Checked)
            {
                data += "\"Karma\"],";
                data += "\"importance\":\"Normal\"}";
            }
            else
            {
                Boolean hasGroup = false;
                foreach (string str in clbOptinalGroups.CheckedItems)
                {
                    data += "\"" + str + "\",";
                    hasGroup = true;
                }
                if (hasGroup)
                {
                    data = data.Remove(data.Length - 1);
                } else
                {
                    data += "\"Karma\"";
                }
                data += "],";

                data += "\"importance\":\"";
                if (rbExImportant.Checked)
                {
                    data += "Çok Önemli";
                }
                else if (rbImportant.Checked)
                {
                    data += "Önemli";
                }
                else
                {
                    data += "Normal";
                }
                data += "\"}";
            }

            string newData = "";
            string fileName = "output.json";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
                newData = "[" + data + "]";
            }
            else
            {
                newData = File.ReadAllText(fileName);
                newData = newData.Remove(newData.IndexOf("}]") + 1);
                newData += "," + data + "]";
            }

            StreamWriter writer = new StreamWriter(fileName, false);
            writer.WriteLine(newData);
            writer.Close();
        }

        private void LabelSentence_Click(object sender, EventArgs e)
        {
            cbSentence.Checked = !cbSentence.Checked;
        }

        private void LabelDate_Click(object sender, EventArgs e)
        {
            cbDate.Checked = !cbDate.Checked;
        }

        private void LabelAuth_Click(object sender, EventArgs e)
        {
            cbAuth.Checked = !cbAuth.Checked;
        }

        private void LabelUrl_Click(object sender, EventArgs e)
        {
            cbUrl.Checked = !cbUrl.Checked;
        }

        private void LabelGroup_Click(object sender, EventArgs e)
        {
            cbGroup.Checked = !cbGroup.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAdd;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }
    }
}
