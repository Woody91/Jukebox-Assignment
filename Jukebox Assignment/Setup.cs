using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jukebox_Assignment
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBut_Click(object sender, EventArgs e)
        {
                Close();   
        }
    }
}
