using System;
using System.Windows.Forms;

namespace Installer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            foreach (string a in Language.Languages.Keys)
            {
                comboBox1.Items.Add(a);
            }
            comboBox1.Text = "English";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = Language.Translate(0, comboBox1.Text);
        }
    }
}
