
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers();
        PrintNumbers(numbers);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    private static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine("Elements in array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
      
        }
    }

    private static void Reverse(int[] numbers)
    {
        
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            //Swapping a and b
            //int a;
            //int b;
            int temp;
            //a = b;
            //b = temp;
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = temp;


        }

        Console.WriteLine("Reversed #s :");
        return;

    }

    private static int[] GenerateNumbers()
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

}