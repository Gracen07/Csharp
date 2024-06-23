namespace Generic_Methods
{
    internal class Program
    {

        static void Swap<T>(T a ,T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Inside Swap method: a={a} ,b={b}");
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine($"Before Swap method:x={x} ,y={y} ");
            Swap(x,y);
            Console.WriteLine($"after Swap method:x={x} ,y={y} ");

        }
    }
}
