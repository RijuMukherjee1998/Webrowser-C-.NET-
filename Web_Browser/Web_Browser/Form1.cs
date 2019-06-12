using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)ConsoleKey.Enter)
            {
                Navigate();
            }
        }

        private void Navigate()
        {
            webBrowser1.Navigate(textBox1.Text);
            toolStripProgressBar1.ProgressBar.Value = 0;
        }
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Finished";
        }

        private void progressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
            if(toolStripProgressBar1.ProgressBar.Value>=100)
            {
                toolStripProgressBar1.ProgressBar.Value = 0;
   
            }

            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }
    }
}
