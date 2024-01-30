public class Program
{
     static void Main()
    {
        Console.WriteLine("Chose 1 for Multipliying or 2 for Deviding");
        int selectedChoice = Convert.ToInt32(Console.ReadLine());

        if(selectedChoice <= 2 && selectedChoice > 0)
        {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if(selectedChoice == 1)
        {
            int result = Multiply(number1, number2);
            Console.WriteLine(result);
        }
        else if(selectedChoice == 2){
            int result = Devide(number1, number2);
        }

        }else{
            Console.WriteLine("Not an option");
        }

    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

   public static int Devide(int a, int b)
    {
        return a / b;
    }
}