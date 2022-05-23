using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wg
{
    public class Controller
    {

        private Model.Model __model;

        public Controller(Model.Model model)
        {
            __model = model;
        }

        internal void solution(TableLayoutPanel table, Button button, Label NMove, Label Chel)
        {
            __model.Solution(table, button,NMove,Chel);
        }

        internal void check(TableLayoutPanel table)
        {
            __model.Check(table);
        }



    }
}
