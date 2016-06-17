using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ant_algorithm.Classes;

namespace ant_algorithm
{
    public partial class Form1 : Form
    {

        c__hive h__hive;


        public Form1()
        {
            InitializeComponent();


            c__data_grids.data_grid(dgv_map);
        }




        private void btn_calculate_Click(object sender, EventArgs e)
        {
            chrt_length.Series["Length"].Points.Clear();


            if (txt_iteration_count.Text == "")
            {
                MessageBox.Show("Заолните поле \"Количество итераций\"");


                return;
            }       


            List<byte[]> l__ba__map;


            l__ba__map = new List<byte[]>();


            for (int i__1 = 0; i__1 < dgv_map.Rows.Count - 1; i__1++)
            {
                l__ba__map.Add(new byte[]{byte.Parse(dgv_map.Rows[i__1].Cells[0].Value.ToString()),
                                          byte.Parse(dgv_map.Rows[i__1].Cells[1].Value.ToString()),
                                          byte.Parse(dgv_map.Rows[i__1].Cells[2].Value.ToString())});
            }


            h__hive = new c__hive(l__ba__map, 5);


            if (txt_ant_count.Text != "")
            {
                h__hive.set_ant_count(byte.Parse(txt_ant_count.Text));
            }


            for (int i__1 = 0; i__1 < int.Parse(txt_iteration_count.Text); i__1++)
            {
                h__hive.iteration();


                chrt_length.Series["Length"].Points.AddXY(i__1 + 1, h__hive.get_way_length());
            }
        }




        private void btn_set_values_Click(object sender, EventArgs e)
        {
            txt_ant_count.Text       = "3";
            txt_iteration_count.Text = "5";


            dgv_map.Rows.Add("1", "2", "3");
            dgv_map.Rows.Add("1", "5", "6");

            dgv_map.Rows.Add("2", "1", "3");
            dgv_map.Rows.Add("2", "3", "3");
            dgv_map.Rows.Add("2", "4", "3");

            dgv_map.Rows.Add("3", "2", "3");
            dgv_map.Rows.Add("3", "4", "3");

            dgv_map.Rows.Add("4", "2", "3");
            dgv_map.Rows.Add("4", "3", "3");
            dgv_map.Rows.Add("4", "5", "3");

            dgv_map.Rows.Add("5", "1", "3");
            dgv_map.Rows.Add("5", "4", "3");
        }
    }
}
