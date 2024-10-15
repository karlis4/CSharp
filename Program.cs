using _13_lib;

class Program
{
    

    public static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        triangle.A = 10;
        triangle.B = 20;
        triangle.C = 30;
        triangle.H = 15;
        Console.WriteLine(triangle.S_Triangle());
        Console.WriteLine(triangle.P_Triangle());
        triangle.ShowLenghts();
    }
}