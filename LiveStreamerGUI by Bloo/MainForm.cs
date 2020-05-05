using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveStreamerGUI_by_Bloo
{
    public partial class MainForm : Form
    {
        string PathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QualityInputBox.SelectedIndex = 0;
            VisualCommand.Text = "Command to be executed...";
        }


        // <file input>
        private void FileInputBox_TextChanged(object sender, EventArgs e)
        {
            if (FileInputBox.Text.Length == 0)
            {
                VisualCommand.Text = "streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
        }

        private void FileInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                RecordButton.PerformClick();
            }
        }
        
        // <quality input>
        private void QualityInputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileInputBox.Text.Length == 0)
            {
                VisualCommand.Text = "streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
        }

        private void QualityInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                RecordButton.PerformClick();
            }
        }
        // </qality input>

        private void RecordButton_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            if (FileInputBox.Text.Length == 0)
            {
                string fileName = ChannelInputBox.Text.ToString().Replace("https://chaturbate.com/", "").Replace("/", "").Replace(" ", "")
                    + "_" + DateTime.Now.ToString("dd.MM.yyyy_HHmm") + ".mp4";
                string SendCommand = "/K streamlink " + ChannelInputBox.Text + " best -o "+ PathToDesktop + "\\cb\\" + fileName + "\"";
                VisualCommand.Text = SendCommand.Replace("/K ", "");
                //MessageBox.Show("Debug: " + SendCommand, "Warning", MessageBoxButtons.OK);
                // MessageBox.Show("No file name specified", "Error", MessageBoxButtons.OK);
                System.Diagnostics.Process.Start("CMD.exe", SendCommand);
            }
            else
            {
                string SendCommand = "/K streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
                System.Diagnostics.Process.Start("CMD.exe", SendCommand);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/streamlink/streamlink/releases/tag/0.14.2";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process.Start(url);
        }

        private void editConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "streamlink\\streamlinkrc");
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

        private void demoConfifFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new LiveStreamerReferenceManual();
            myForm.Show();
        }

        private void WatchBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            string SendCommand = "/K streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            System.Diagnostics.Process.Start("CMD.exe", SendCommand);

        }

        private void ChannelInputBox_TextUpdate(object sender, EventArgs e)
        {
            if(ChannelInputBox.Text.Contains("chaturbate"))
            {
                string fileName = ChannelInputBox.Text.ToString().Replace("https://chaturbate.com/", "").Replace("/", "").Replace(" ", "")
        + "_" + DateTime.Now.ToString("dd.MM.yyyy_HHmm") + ".mp4";
                string SendCommand = "/K streamlink " + ChannelInputBox.Text + " best -o " + PathToDesktop + "\\cb\\" + fileName + "\"";
                VisualCommand.Text = SendCommand.Replace("/K ", "");
            }
            else
            {
                VisualCommand.Text = "streamlink " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }

        }
    }
}
