using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaCheats
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string cheat = "https://github.com/miniusbhater/motdstuff/releases/latest/download/motdstuff.dll";
                string directoryPath1 = textBox1.Text;
                string cheatname = "motdstuff.dll";
                string fullPath1 = Path.Combine(directoryPath1, cheatname);

                using (WebClient webclient1 = new WebClient())
                {
                    webclient1.DownloadFile(cheat, fullPath1);
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            }
        }
    }
}
