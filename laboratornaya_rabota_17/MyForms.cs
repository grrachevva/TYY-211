using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wword;

namespace laboratornaya_rabota_17
{
    public partial class WForms : Form
    {
        public WForms()
        {
            InitializeComponent();
        }

        private void btnTitlePage(object sender, EventArgs e)
        {
            TitlePage formTit = new TitlePage();
            formTit.Show();
        }

        private void btnQuestionnaire_Click(object sender, EventArgs e)
        {
            FormQuestionnaire form2 = new FormQuestionnaire();
            form2.ShowDialog();
            this.Close();
        }
    }
}
