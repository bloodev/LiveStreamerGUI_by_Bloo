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

        }

        // <chanel input>
        private void ChannelInputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileInputBox.Text.Length == 0)
            {
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
        }

        private void ChannelInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                watchButton.PerformClick();
            }
            if (FileInputBox.Text.Length == 0)
            {
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
        }

        // <file input>
        private void FileInputBox_TextChanged(object sender, EventArgs e)
        {
            if (FileInputBox.Text.Length == 0)
            {
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
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
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            }
            else
                VisualCommand.Text = "livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
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
            string SendCommand = "/K livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text + " -o \"" + PathToDesktop + "\\" + FileInputBox.Text + "\"";
            if (FileInputBox.Text.Length == 0)
            {
                MessageBox.Show("No file name specified", "Error", MessageBoxButtons.OK);
            }
            else
                System.Diagnostics.Process.Start("CMD.exe", SendCommand);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/chrippa/livestreamer/releases";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process.Start(url);
        }

        private void editConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "livestreamer\\livestreamerrc");
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

        private void demoConfifFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new LiveStreamerReferenceManual();
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            string SendCommand = "/K livestreamer " + ChannelInputBox.Text + " " + QualityInputBox.Text;
            System.Diagnostics.Process.Start("CMD.exe", SendCommand);

        }
    }
}
