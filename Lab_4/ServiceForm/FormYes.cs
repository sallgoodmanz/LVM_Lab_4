using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.ServiceForm
{
    public partial class FormYes : Form
    {
        private MainForm mainForm;

        public FormYes(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }


   

        private void buttonYes_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox("Yes");
        }  
        private void buttonNo_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox("No");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox("Cancel");
        }
        
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
