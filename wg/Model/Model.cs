using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wg.Model
{
    public class Model
    {

        private bool h = true;


        public void Check(TableLayoutPanel table)
        {

            foreach (Control c in table.Controls)
            {

                if (c.Text == "k")
                {
                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c)).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c)).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c), table.GetRow(c) + 1).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c), table.GetRow(c) - 1).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c) + 1).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c) - 1).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c) - 1).BackColor = Color.Salmon;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c) + 1).BackColor = Color.Salmon;

                }

                if (c.Text == "c")
                {
                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c)).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c)).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c), table.GetRow(c) + 1).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c), table.GetRow(c) - 1).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c) + 1).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c) - 1).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c) + 1, table.GetRow(c) - 1).BackColor = Color.Blue;

                    table.GetControlFromPosition(table.GetColumn(c) - 1, table.GetRow(c) + 1).BackColor = Color.Blue;

                }

            }

        }




        public void Solution(TableLayoutPanel tableLayoutPanel1, Button label, Label NMove, Label Chel)
        {

            Color color;
            string a;



            if (h)
            {
                color = Color.Salmon;
                a = "k";
            }
            else
            {
                color = Color.Blue;
                a = "c";
            }


            if (label.BackColor == color)
            {
                label.Text = a;

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).BackColor = color;
                }

                if (tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount & tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                NMove.Text = Convert.ToString(int.Parse(NMove.Text) - 1);
                if (NMove.Text == "0")
                {
                    if (h)
                    {
                        NMove.Text = "5"; Chel.Text = "Синий"; h = false;
                    }
                    else
                    {
                        NMove.Text = "5"; Chel.Text = "Красный"; h = true;
                    }
                }

            }
        }
    }
}
