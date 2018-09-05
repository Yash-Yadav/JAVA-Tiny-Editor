using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAVA_IDE
{
    public partial class JAVA_IDE : Form
    {
        string fileNameOnly = null, fileName_path, Drive, RemainingPath;

        public JAVA_IDE()
        {
            InitializeComponent();

            //Setting UP
            saveState.Text = "Setting UP";
            statusStrip.Refresh();
            //Opening cmd
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            var proc = Process.Start(psi);
            //Entering commands in CMD
            string TestCmd = "javac";
            proc.StandardInput.WriteLine(@TestCmd);  //Test Command
            proc.StandardInput.WriteLine(@"exit");
            string error = proc.StandardError.ReadToEnd();
            if (error.Contains("'javac'"))
            {
                error = "";                
                MessageBox.Show("Please configure the JDK on this machine and then setup the Path"+Environment.NewLine+"Using the labels on the right side");
                saveState.Text = "First setup the Environment    ";
            }
            else
                saveState.Text = "All Set";
        }

        private void downloadJDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://www.oracle.com/technetwork/java/javase/downloads/index.html";
            Process.Start(url);
        }

        private void configPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://youtu.be/iImJ1PHrHE8";
            Process.Start(url);
        }
               

        private void Save_Click(object sender, EventArgs e)
        {
            saveState.Text = "";
            if (fileName_path!=null)
            {
                //Saving the File
                using (StreamWriter outputFile = new StreamWriter(fileName_path))
                    outputFile.WriteLine(Code.Text);
                saveState.Text = "Saved Successfully";
            }
            else
            {
                saveState.Text = "Kindly Use Save As button";                
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Code.Text = "";
            Output.Text = "";
            fileName_path = null;
            saveState.Text = " - ";
            CurrentFile.Text = " - ";
            fileNameOnly = null;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveState.Text = "";
            //Saving the File
            SaveFileDialog SDialog = new SaveFileDialog();
            SDialog.Filter = "Java file (*.java)|*.java";
            SDialog.Title = "Save Dialog Box";
            SDialog.RestoreDirectory = true;
            if (SDialog.ShowDialog() != DialogResult.OK)
                saveState.Text = "Nothing Saved";
            else
            {
                using (StreamWriter outputFile = new StreamWriter(SDialog.FileName))
                {
                    outputFile.WriteLine(Code.Text);
                }
            }
        }

        private void Compile_Run_Click(object sender, EventArgs e)
        {
            saveState.Text = "";
            if (fileNameOnly==null)
                MessageBox.Show("For existing files only (No file selected currently)- \"Please Select the File\"");

            else
            {
                //Saving the File
                using (StreamWriter outputFile = new StreamWriter(fileName_path))
                    outputFile.WriteLine(Code.Text);

                //Opening cmd
                ProcessStartInfo psi = new ProcessStartInfo("cmd");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                psi.RedirectStandardInput = true;
                var proc = Process.Start(psi);

                saveState.Text = "Executing...";
                statusStrip.Refresh();

                //Entering commands in CMD
                string compileCmd = "javac " + fileNameOnly;
                string runCmd = "java " + Path.GetFileNameWithoutExtension(fileNameOnly);
                proc.StandardInput.WriteLine(@Drive);   //Change Drive
                proc.StandardInput.WriteLine(@RemainingPath);   //Change Directory
                proc.StandardInput.WriteLine(@compileCmd);  //Compile Command
                proc.StandardInput.WriteLine(@runCmd);  //Run Command
                proc.StandardInput.WriteLine(@"exit");
                string result = proc.StandardOutput.ReadToEnd();
                string error = proc.StandardError.ReadToEnd();

                //Result in the Output Textbox
                string op = result.Substring(result.IndexOf(">javac ") + 6);
                Output.Text = "Compile Status of file: " + op;   //Prints the output to the TextBox2(Output one)
                                    //Trimming the Last Junk Part
                for (int tmp = 1; tmp <= 2; tmp++)
                {
                    var i = Output.Text.LastIndexOf("\n");
                    Output.SelectionStart = i;
                    Output.SelectionLength = Output.TextLength - i + 1;
                    Output.SelectedText = "";
                }
                Output.Text += "\nError:" + Environment.NewLine + error;

                saveState.Text = "Execution Done!";
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            saveState.Text = " - ";
            OpenFileDialog OpenJavaFile = new OpenFileDialog();
            OpenJavaFile.Filter = "Java file (*.java)|*.java";
            OpenJavaFile.Title = "Select a JAVA code File";
            if (OpenJavaFile.ShowDialog() == DialogResult.OK)
            {
                fileNameOnly = OpenJavaFile.SafeFileName;
                fileName_path = OpenJavaFile.FileName;
                Drive = fileName_path.Split('\\')[0].ToString();
                RemainingPath = "cd " + Path.GetDirectoryName(fileName_path);
                Code.Lines = File.ReadAllLines(OpenJavaFile.FileName);
                CurrentFile.Text = fileNameOnly;
            }
        }
    }
}
