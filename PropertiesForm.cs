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
    /// <summary>
    /// New form for the Properties panel
    /// </summary>
    public partial class PropertiesForm : Form
    {
        static string homepage = "Google.com";
        public PropertiesForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Saved the text in the home page text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            homepage = Form2Text.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Closes the properties form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// A getter method for getting the saved homepage.
        /// </summary>
        /// <returns></returns>
        public string getHomePage()
        {
            return homepage;
        }
    }
}
