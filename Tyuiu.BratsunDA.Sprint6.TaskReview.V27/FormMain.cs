using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BratsunDA.Sprint6.TaskReview.V27.Lib;

namespace Tyuiu.BratsunDA.Sprint6.TaskReview.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(textBoxN1_BDA.Text);
                int n2 = Convert.ToInt32(textBoxN2_BDA.Text);
                //int r = Convert.ToInt32(textBoxNumStr_BDA.Text);
                int n = Convert.ToInt32(textBoxRows_BDA.Text);
                int m = Convert.ToInt32(textBoxColumns_BDA.Text);
                //int k = Convert.ToInt32(textBoxK_BDA.Text);
                //int l = Convert.ToInt32(textBoxL_BDA.Text);

                int[,] arrayValues = new int[n, m];

                arrayValues = ds.GetMatrix(n1, n2, n, m);

                dataGridViewMtrx_BDA.ColumnCount = m;
                dataGridViewMtrx_BDA.RowCount = n;

                for (int i = 0; i < m; i++)
                {
                    dataGridViewMtrx_BDA.Columns[i].Width = 50;
                }

                for (int j = 0; j < n; j++)
                {
                    for (int c = 0; c < m; c++)
                    {
                        dataGridViewMtrx_BDA.Rows[j].Cells[c].Value = arrayValues[j, c];
                    }
                }

                arrayValues = ds.GetMatrix(n1, n2, n, m);
                int[,] arrayValues1 = arrayValues;


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonResult_BDA.Enabled = true;


        }

        private void buttonResult_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Convert.ToInt32(textBoxNumStr_BDA.Text)-1;
                int k = Convert.ToInt32(textBoxK_BDA.Text)-1;
                int l = Convert.ToInt32(textBoxL_BDA.Text)-1;
                int ROW = dataGridViewMtrx_BDA.Rows.Count;
                int COLUMN = dataGridViewMtrx_BDA.Columns.Count;

                int[,] mx = new int[ROW, COLUMN];
                for (int rows = 0; rows < dataGridViewMtrx_BDA.Rows.Count; rows++)
                {
                    for (int col = 0; col < dataGridViewMtrx_BDA.Rows[rows].Cells.Count; col++) // упирается в кол-во ячеек в строке
                    {
                        mx[rows, col] = Convert.ToInt32(dataGridViewMtrx_BDA.Rows[rows].Cells[col].Value.ToString());
                    }
                }
                textBoxResult_BDA.Text = Convert.ToString(ds.GetSum(mx,r,k,l));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
