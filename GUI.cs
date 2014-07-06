using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_File_Organiser
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            String folderName;

            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = browser.SelectedPath;
                foldersList.Items.Add(folderName);
            }
        }

        private void removeFolderButton_Click(object sender, EventArgs e)
        {
            if (foldersList.SelectedItems.Count > 0)
            {
                var selected = foldersList.Items.Cast<ListViewItem>().Where(x => x.Selected);
                foreach (var item in selected)
                {
                    foldersList.Items.RemoveAt(item.Index);
                }
            }

        }

        private void addStringButton_Click(object sender, EventArgs e)
        {
            stringPopUp();
        }

        private void stringPopUp()
        {
            string value = "";
            if (InputBox("Search term", "New Search Term:", ref value) == DialogResult.OK)
            {
                searchList.Items.Add(value);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void removeSearchButton_Click(object sender, EventArgs e)
        {
            if (searchList.SelectedItems.Count > 0)
            {
                var selected = searchList.Items.Cast<ListViewItem>().Where(x => x.Selected);
                foreach (var item in selected)
                {
                    searchList.Items.RemoveAt(item.Index);
                }
            }
        }

        private async void sortButton_Click(object sender, EventArgs e)
        {
            // Variable setting
            List<String> folders = foldersList.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
            List<String> searchTerms = searchList.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
            bool seperateByFolders = seperateByFoldersCheckbox.Checked;
            String outputAll = null;
            if (outputAllCheckBox.Checked && outputAllTextBox.Text != String.Empty)
                outputAll = outputAllTextBox.Text;

            // Progress bar declaration
            var progress = new Progress<string>(s => statusBox.AppendText(s + "\n")); // Progress delegate
            
            this.Enabled = false; // Disable UI

            // Start in new thread
            await Task.Factory.StartNew(() => SearchEngine.sort(progress, searchTerms, folders, folderCheck.Checked, seperateByFolders, outputAll), TaskCreationOptions.LongRunning);

            // Re-enable UI
            this.Enabled = true;
        }

        private void outputAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (outputAllCheckBox.Checked)
            {
                outputAllToButton.Enabled = true;
                outputAllTextBox.Enabled = true;
                seperateByFoldersCheckbox.Enabled = true;

                // Set output 
                String folderName;

                FolderBrowserDialog browser = new FolderBrowserDialog();
                DialogResult result = browser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderName = browser.SelectedPath;
                    outputAllTextBox.Text = folderName;
                }
            }
            else 
            {
                outputAllToButton.Enabled = false;
                outputAllTextBox.Enabled = false;
                seperateByFoldersCheckbox.Enabled = false;
            }
        }

        private void outputAllToButton_Click(object sender, EventArgs e)
        {
            String folderName;

            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = browser.SelectedPath;
                outputAllTextBox.Text = folderName;
            }
        }
    }
}
