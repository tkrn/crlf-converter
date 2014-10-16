using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRLFConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ValidateNames = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.FileName = "";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFilePath;

                if (Path.GetDirectoryName(openFileDialog.FileName).Equals(@"C:\"))
                {
                    fullFilePath = Path.GetDirectoryName(openFileDialog.FileName) + Path.GetFileName(openFileDialog.FileName);
                }
                else
                {
                    fullFilePath = Path.GetDirectoryName(openFileDialog.FileName) + @"\" + Path.GetFileName(openFileDialog.FileName);
                }

                if (!checkForDuplicate(fullFilePath))
                {
                    selectedFilesFoldersListBox.Items.Add(fullFilePath);
                }
            } 
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFilePath;

                if (folderBrowserDialog.SelectedPath.ToString().Equals(@"C:\")) 
                {
                    fullFilePath = folderBrowserDialog.SelectedPath.ToString() + @"*.*";
                } 
                else
                {
                    fullFilePath = folderBrowserDialog.SelectedPath.ToString() + @"\*.*";
                }



                if (!checkForDuplicate(fullFilePath))
                {
                    selectedFilesFoldersListBox.Items.Add(fullFilePath);
                }
            }          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!selectedFilesFoldersListBox.SelectedIndex.Equals(-1))
            {
                int index = selectedFilesFoldersListBox.SelectedIndex;
                selectedFilesFoldersListBox.Items.RemoveAt(index);

                if (index - 1 < 0)
                {
                    try
                    {
                        selectedFilesFoldersListBox.SelectedIndex = 0;
                    }
                    catch
                    {
                        selectedFilesFoldersListBox.SelectedIndex = -1;
                    }
                }
                else
                {
                    selectedFilesFoldersListBox.SelectedIndex = index - 1;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            enableFormControls(false);
            convertProgressBar.Value = 0;
            Cursor.Current = Cursors.WaitCursor;

            ArrayList ItemList = new ArrayList();
            
            if (selectedFilesFoldersListBox.Items.Count > 0)
            {
                for (int i = 0; i < selectedFilesFoldersListBox.Items.Count; ++i)
                {
                    bool directory = selectedFilesFoldersListBox.Items[i].ToString().EndsWith(@"\*.*");

                    if (directory)
                    {
                        string[] filePaths = Directory.GetFiles(selectedFilesFoldersListBox.Items[i].ToString().Substring(0, selectedFilesFoldersListBox.Items[i].ToString().Length - 3), "*.*", SearchOption.AllDirectories);

                        foreach (string s in filePaths)
                        {
                            ItemList.Add(s);
                        }
                    }
                    else
                    {
                        ItemList.Add(selectedFilesFoldersListBox.Items[i].ToString());
                    }
                }

                decimal percentIncrease = 100 / ItemList.Count;
                decimal currentValue = 0;

                for (int i = 0; i < ItemList.Count; ++i)
                {
                    string filePath = Path.GetFullPath(ItemList[i].ToString());

                    try
                    {
                        byte[] fileIn = File.ReadAllBytes(filePath);
                        ArrayList fileOutList = new ArrayList(fileIn.Length);

                        for (int ii = 0; ii < fileIn.Length; ii++)
                        {
                            if (!fileIn[ii].Equals(13)) //Checks for CR
                            {
                                if (fileIn[ii].Equals(10)) //Checks for LF
                                {
                                    fileOutList.Add((byte)13); //Adds CR before the initial LF
                                }
                            }

                            fileOutList.Add((byte)fileIn[ii]);
                        }

                        byte[] fileOutArray = new byte[fileOutList.Count];

                        fileOutList.CopyTo(fileOutArray);

                        if (rbCreateFile.Checked)
                        {
                            filePath = Path.GetDirectoryName(ItemList[i].ToString()) + "\\" + Path.GetFileNameWithoutExtension(ItemList[i].ToString()).ToUpper() + ".CONV.TXT";
                        }

                        File.WriteAllBytes(filePath, fileOutArray);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Error occured reading/writing the following file: \n" + filePath.Replace(@"\\", @"\"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    catch
                    {
                        MessageBox.Show("General Error Occured", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                    currentValue += percentIncrease;
                    convertProgressBar.Value = (int)currentValue;
                }
            }
            else
            {
                MessageBox.Show("No files or folders selected!", "Please Select Files/Folders", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            convertProgressBar.Value = 100;
            Cursor.Current = Cursors.Default;
            enableFormControls(true);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && e.Modifiers == Keys.Control)
            {
                frmAbout aboutForm = new frmAbout();
                    aboutForm.Show();
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { 
                Close(); 
            }
        }

        private void enableFormControls(bool sender)
        {
            btnAddFolder.Enabled = sender;
            btnFile.Enabled = sender;
            btnConvert.Enabled = sender;
            rbCreateFile.Enabled = sender;
            rbOverwrite.Enabled = sender;
        }

        private bool checkForDuplicate(string sender)
        {
            for (int i = 0; i < selectedFilesFoldersListBox.Items.Count; ++i)
            {
                if (selectedFilesFoldersListBox.Items[i].Equals(sender)){
                    return true;
                }
            }
            return false;
        }
    }
}