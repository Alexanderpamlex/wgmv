using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wg
{
    public partial class Form1 : Form
    {
        private Controller __controller;
        public Form1(Controller controller)
        {
            InitializeComponent();
            __controller = controller;
            __controller.check(tableLayoutPanel1);
        }



        private void _Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            __controller.solution(tableLayoutPanel1,button, NMove, Chel);
            
        }
    }
}
