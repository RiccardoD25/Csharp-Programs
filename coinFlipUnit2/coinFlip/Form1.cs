using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coinFlip
{
    public partial class HeadsOrTailsForm : Form
    {
        public HeadsOrTailsForm()
        {
            InitializeComponent();
        }

        private void ShowHeadsButton_Click(object sender, EventArgs e)
        {
            CoinHeadsPictureBox.Visible = true;
            CoinTailsPictureBox.Visible = false;
        }

        private void ShowTailsButton_Click(object sender, EventArgs e)
        {
            CoinHeadsPictureBox.Visible=false;
            CoinTailsPictureBox.Visible=true; 

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeadsOrTailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
