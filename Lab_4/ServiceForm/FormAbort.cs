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
    public partial class FormAbort : Form
    {
        private MainForm mainForm;

        public FormAbort(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

      

        private void buttonAbort_Click(object sender, EventArgs e)
        {
          mainForm.SetInfoInTextBox("Abort");
        }
        private void buttonRetry_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox("Retry");
        }
        private void buttonIgnor_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox("Ignore");
        }  
        
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
