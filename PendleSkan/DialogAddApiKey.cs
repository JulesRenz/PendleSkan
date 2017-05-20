using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendleSkan
{
    public partial class DialogAddApiKey : Form
    {
        public string apiKey {get; private set; }
        public DialogAddApiKey() {
            InitializeComponent();
        }

        private void DialogAddApiKey_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.apiKey = textBox1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
