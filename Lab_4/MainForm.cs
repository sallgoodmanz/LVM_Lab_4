using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project.ServiceForm;

namespace Project
{
    public partial class MainForm : Form
    {
        FormYes formYes;
        FormAbort formAbort;
        FormCustom formCustom;


        public void SetInfoInTextBox(string mes)
        {
            textBox1.Text = mes;
        }
        public string OptionName { get; set; }


        public MainForm()
        {
            InitializeComponent();

            formYes = new FormYes(this);
            formAbort = new FormAbort(this);
            formCustom = new FormCustom(this);
        }



        private void buttonYes_Click(object sender, EventArgs e)
        {
            formYes.Show();
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            formAbort.Show();
        }
        private void buttonCusDialog_Click(object sender, EventArgs e)
        {
            formCustom.Show();
        }



        private void buttonOption_Click(object sender, EventArgs e)
        {
            if (OptionName != String.Empty)
            {
                SetInfoInTextBox(OptionName);
            }
        }



        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "TXT File (*.txt)|*.txt|LEX File (*.lex)|*.lex|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    SetInfoInTextBox(openFileDialog.FileName);
                    OptionName = String.Empty;
                }
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
