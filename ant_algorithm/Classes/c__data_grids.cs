using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ant_algorithm.Classes
{
    static class c__data_grids
    {
        public static void data_grid(DataGridView dgv_grid)
        {
            dgv_grid.AutoGenerateColumns = true;

            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_3 = new DataGridViewTextBoxCell();            

            DataGridViewColumn col__from   = new DataGridViewColumn();
            DataGridViewColumn col__to     = new DataGridViewColumn();
            DataGridViewColumn col__length = new DataGridViewColumn();
           

            col__from.HeaderText   = "Откуда";
            col__to.HeaderText     = "Куда";
            col__length.HeaderText = "Длина";           

            col__from.Width   = 110;
            col__to.Width     = 110;
            col__length.Width = 110;            


            col__from.CellTemplate   = Cell_1;
            col__to.CellTemplate     = Cell_2;
            col__length.CellTemplate = Cell_3;

            dgv_grid.ReadOnly = false;
            dgv_grid.AllowUserToAddRows = true;
            dgv_grid.AllowUserToDeleteRows = true;
            dgv_grid.Columns.Add(col__from);
            dgv_grid.Columns.Add(col__to);
            dgv_grid.Columns.Add(col__length);            
        }
    }
}
