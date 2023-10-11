namespace fizzbuzz;
class Program
{
    static void Main(string[] args)
    {
        for (int x = 1; x <= 255; x++) {
            if (x % 3 == 0 && x % 5 == 0) {
                Console.WriteLine("fizzbuzz");
            } else if (x % 5 == 0) {
                Console.WriteLine("buzz");
            } else if (x % 3 == 0) {
                Console.WriteLine("fizz");
            } else {
                Console.WriteLine(x);
            }
        }
    }
}
