using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BratsunDA.Sprint6.TaskReview.V27.Lib
{
    public class DataService
    {
       public int[,] GetMatrix(int n1, int n2, int n, int m)
       {
            Random rnd = new Random();
            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i%2==0)
                    {
                        mtrx[i, j] = rnd.Next(n1, n2);
                        if (mtrx[i, j] %2!=0)
                        {
                            mtrx[i, j] += 1;
                        }
                    }
                    else
                    {
                        mtrx[i, j] = rnd.Next(n1, n2);
                        if (mtrx[i, j]%2==0)
                        {
                            mtrx[i, j] += 1;
                        }
                    }
                }
            }
            return mtrx;
       }

        public int GetSum(int[,] mx, int r, int k, int l)
        {
            int sum = 0;
            for (int i = r; i <= r; i++)
            {
                for (int j = k; j <= l; j++)
                {
                    if (mx[i,j]%2==0)
                    {
                        sum += mx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
