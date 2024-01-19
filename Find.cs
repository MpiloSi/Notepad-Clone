using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Clone
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        public string FindText;
        MainNotepadForm main = new MainNotepadForm();
        private void button1_Click(object sender, EventArgs e)
        {
            
            main.FindText = textBox1.Text;
            main.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            } else
            {
                button1.Enabled = false;
            }
        }
    }
}
