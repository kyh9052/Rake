using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser temp = webBrowser1;
            Clipboard.Clear();
            webBrowser1.Document.ExecCommand("SelectAll", false, null);
            webBrowser1.Document.ExecCommand("Copy", false, null); 
            string temp2 = Clipboard.GetText();

        }
    }
}
