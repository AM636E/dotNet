using System;

namespace Matrix
{
    class Matrix
    {
        int rows, cols;
        int[,] matrix;

        public Matrix()
        {
            rows = 0;
            cols = 0;
            matrix = null;
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;

            this.matrix = new int[rows, cols];
        }

        public Matrix(int[,] array)
        {
            this.rows = array.GetLength(0);
            this.cols = array.GetLength(1);

            this.matrix = new int[this.rows, this.cols];

            for (var i = 0; i < this.rows; i++)
            {
                for (var j = 0; j < this.cols; j++)
                {
                    this.matrix[i, j] = array[i, j];
                }
            }
        }

        public Matrix(Matrix m)
        {
            this.rows = m.rows;
            this.cols = m.cols;

            this.Copy(m);
        }

        public bool Equals(Matrix m)
        {
            return this.rows == m.rows && this.cols == m.cols;
        }

        public void Copy(Matrix source)
        {
            if (this.Equals(source))
            {
                Console.WriteLine("Wrong source");

                return;
            }

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    this.matrix[i, j] = source.matrix[i, j];
                }
            }
        }

        public Matrix UMinus()
        {
            Matrix res = new Matrix(this.rows, this.cols);
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    res.matrix[i, j] = this.matrix[i, j] * -1;
                }
            }

            return res;
        }

        public Matrix Add(Matrix m)
        {
            if (!this.Equals(m))
            {
                Console.WriteLine("Matrix must by equals");
                return null;
            }
            Matrix res = new Matrix(this.rows, this.cols);

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    res.matrix[i, j] = this.matrix[i, j] + m.matrix[i, j];
                }
            }

            return res;
        }

        public Matrix Mul(Matrix m)
        {
            if (!this.Equals(m))
            {
                Console.WriteLine("Matrix must by equals");
                return null;
            }
            Matrix res = new Matrix(this.rows, this.cols);

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    res.matrix[i, j] = this.matrix[i, j] * m.matrix[i, j];
                }
            }

            return res;
        }

        public void Set(int i, int j, int val)
        {
            this.matrix[i, j] = val;
        }

        public Matrix Mul(int m)
        {
            var res = new Matrix(this.rows, this.cols);

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    res.matrix[i, j] = this.matrix[i, j] * m;
                }
            }

            return res;
        }



        public Matrix Sub(Matrix m)
        {
            return this.Add(m.UMinus());
        }

        public override string ToString()
        {
            String res = String.Empty;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    res += this.matrix[i, j] + " ";
                }
                res += '\n';
            }

            return res;
        }
    }
}
