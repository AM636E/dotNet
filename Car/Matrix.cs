using System;

namespace Car
{
    class Matrix
    {
        protected Point[,] matrix;

        public delegate Point Action(Point p);
        
        public Matrix() { }

        public Matrix(int rows, int cols)
        {
            matrix = new Point[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    matrix[i, j] = new Point(ConsoleColor.White);
                    matrix[i, j].Ch = '\0';
                }
            }      
        }


        public Matrix(int rows, int cols, char ch)
        {
            matrix = new Point[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    matrix[i, j] = new Point(ConsoleColor.White);
                    matrix[i, j].Ch = ch;
                }
            }      
        }

        public Matrix(Matrix copy)
        {
            this.matrix = new Point[copy.Rows, copy.Cols];

            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                {
                    this.matrix[i, j] = copy.matrix[i, j];                    
                }
            }  
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }
        public int Cols
        {
            get { return matrix.GetLength(1); }
        }

        public Point[,] GetMatrix()
        {
            return this.matrix;
        }


        public Point this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public void Print()
        {
            Console.Clear();
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                {
                    matrix[i, j].Print();
                }
                Console.Write('\n');
            }
            ; ; ; ; ; ; ; ; ; ; ; ; ;
          //  Console.ReadKey();
        }

        public void ActWithMatrix(Action action)
        {
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                {
                    matrix[i, j] = action(matrix[i, j]);
                }
            }
        }

        public void WriteTo(Matrix target)
        {
            if (target.Rows < this.Rows || target.Cols < this.Cols)
            {
                throw new ArgumentException("Matrix is to big");
            }

            for (var i = 0; i < this.Rows; i++)
            {
                for (var j = 0; j < this.Cols; j++)
                {
                    target[matrix[i, j].Row, matrix[i, j].Col] = matrix[i, j];
                }
            }
            //target.ActWithMatrix(delegate(Point p)
            //{

            //});
        }
        public void EraseFrom(Matrix r)
        {
            var a = matrix[0, 0];

            if (a.Row > 0 && a.Col > 0 && a.Row < r.Rows && a.Col < r.Cols)
            {
                r.GetMatrix()[a.Row, a.Col].Ch = ' ';
            }
        }
        public void Erase(Matrix target)
        {
           
        }
    }
}