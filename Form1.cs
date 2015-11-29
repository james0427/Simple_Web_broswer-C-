using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function is called when the exit menu is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This function is called when the about section is selected.
        /// Just a basic about section of the code which can be edited to your liking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Place about me here");
        }
        /// <summary>
        /// On click the web control displayes the page requested, by URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Navigate();
        }
        /// <summary>
        /// Core navigation function
        /// Allows for easy recoding of the navigation functions without repeating mass amounts of code.
        /// 
        /// </summary>
        private void Navigate()
        {
            toolStripStatusLabel1.Text = "Page loading";
            button1.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
        }

        /// <summary>
        /// Checks to see if the page has completely loaded.
        /// Once it is loaded it will unlock the nagivation bar and button
        /// Allowing you to continue surfing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = webBrowser1.Url.ToString();
        }

        /// <summary>
        /// Textbox - Unused for code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Triggered event once the user has clicked the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Navigate();
            }
        }

        /// <summary>
        /// Status bar located at the bottom of the page
        /// Gets updates based on the percent of the page that has been loaded in bytes
        /// 
        /// Sets the maximum side to the total percent of the bytes
        /// (other wise the program will get an overflow error)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.MaximumProgress > 0 && e.CurrentProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Maximum = (int)((e.CurrentProgress *100) / e.MaximumProgress) + 1;
                toolStripProgressBar1.ProgressBar.Value = (int)((e.CurrentProgress *100) / e.MaximumProgress);
            }

            toolStripStatusLabel1.Text = "Loading completed";
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
