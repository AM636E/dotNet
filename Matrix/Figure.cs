//using System;

//namespace Matrix
//{
//    class Figure
//    {
//        public string name     { set; get; }
//        public double square   { set; get; }
//        public double perimetr { set; get; }
//        public Point center;

//        public static int count;

//        static Figure( )
//        {
//            count = 1;
//        }

//        public Figure():
//            this( String.Empty, 0, 0, new Point() )
//        {
          
//        }

//        public Figure( string name, double square, double perimetr, Point center )
//        {
//            this.name = name;
//            this.square = square;
//            this.perimetr = perimetr;
//          //  this.center = new Point( );
//            this.center = center;
//            count ++;
//        }

//        public struct Point
//        {
//            public double x { set; get; }
//            public double y { set; get; }
            
//            public Point()
//            {
//                x = y = 0;
//            }

//            public override string ToString()
//            {
//                return '(' + x.ToString() + ';' + y.ToString() + ')';
//            }
//        }          

//        public override string ToString()
//        {
//            return "name: " + this.name + '\n' +
//                    "petimetr: " + this.perimetr + '\n' +
//                    "square: " + this.square + '\n' +
//                    "Center: " + center.ToString() + '\n';
//        }
//    }
//}
