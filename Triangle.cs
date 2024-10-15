namespace _13_lib
{
    public class Triangle
    {
        int a, b, c, h;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public int H { get { return h; } set { h = value; } }

        public bool Trian
        {
            get 
            {
                if(a  != 0 && b != 0 && c != 0)
                {
                     
                    Console.WriteLine("Такой треугольник существует");
                    return true;
                } else
                {
                    Console.WriteLine("треугольник не существует");
                    return false;
                }
                
            }
        }

        public Triangle()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowLenghts() => Console.Write($"a = {a}, b = {b}, c = {c}");

        public int P_Triangle()
        {
            if (Trian == false)
            {
                Console.WriteLine("Треугольник со строной равной 0");
                return 0;
            }
            int P = a + b + c;
            Console.Write("Его периметр равен: ");
            return P;
        }

        public int S_Triangle() 
        {
            if (Trian == false) 
            { 
                Console.WriteLine("Треугольник со строной равной 0"); 
                return 0; 
            }
            int S = (a * h) / 2;
            Console.Write("Его площадь равна: ");
            return S;
        }
    }
}
