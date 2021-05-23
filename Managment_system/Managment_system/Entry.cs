using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment_system
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_2.Width += 3;
            if (panel_2.Width >=762)
            {
                timer1.Stop();
                Managment_System ms = new Managment_System();
                ms.Show();
                this.Hide();
            }
        }
    }
}
