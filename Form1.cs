using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BSA_s_Shells
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = Environment.SystemDirectory+"/cmd.exe";
                string args = "/K cd C:/Windows/System32";
                Process.Start(cmd, args);
                Debug.WriteLine("cmd found!");
            
            }

            catch(System.ComponentModel.Win32Exception)
            {
                DialogResult notfound = MessageBox.Show("CMD was not found! Unable to run!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                string power = "powershell.exe";
                Process.Start(power);
            }
            catch(System.ComponentModel.Win32Exception) {
                DialogResult notfound = MessageBox.Show("Powershell was not found! Unable to run! Check if your version of Windows includes Powershell, or try to install it, then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string py = "python";
                Process.Start(py);
            }
            catch(System.ComponentModel.Win32Exception)
            {
                DialogResult notfound = MessageBox.Show("Python was not found! Unable to run! Check if Python binaries are installed on this computer, then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.FileRun();
            DialogResult help = MessageBox.Show("Type 'bash' in the 'run' dialog box to proceed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string note2 = "notepad++";
            try
            {
                Process.Start(note2);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                DialogResult notfound = MessageBox.Show("Notepad++ was not found! Check if it is installed on this computer, then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string note = "notepad";
            try
            {
                Process.Start(note);
            }
            catch(System.ComponentModel.Win32Exception)
            {
                DialogResult notfound = MessageBox.Show("Notepad was not found! Check if it is installed on this computer, then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
