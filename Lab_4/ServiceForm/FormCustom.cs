using System;
using System.Windows.Forms;

namespace Project.ServiceForm
{
    public partial class FormCustom : Form
    {
        private MainForm mainForm;

        public FormCustom(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            mainForm.SetInfoInTextBox(textBox1.Text);


            if (radioButton1.Checked)
                mainForm.OptionName = radioButton1.Text;

            else if (radioButton2.Checked)
                mainForm.OptionName = radioButton2.Text;

            else if (radioButton3.Checked)
                mainForm.OptionName = radioButton3.Text;

            else if (radioButton4.Checked)
                mainForm.OptionName = radioButton4.Text;

            else
                mainForm.OptionName = String.Empty;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
