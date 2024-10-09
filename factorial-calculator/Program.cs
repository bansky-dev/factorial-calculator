namespace factorial_calculator;

class Program
{
    static void Main(string[] args)
    {
        menuDisplay();
        int menuChoice = int.Parse(Console.ReadLine());

        if(menuChoice == 1){
            Console.Write("Choose an number: ");
            int factorialNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < factorialNumber; i++)
            {
                int count = 1;
                int count2 = 2;
                count2++;
            }
        }


    }

    static void menuDisplay(){
        Console.WriteLine("=====FACTORIAL CALCULATOR=====");
        Console.WriteLine("[1] Normal factorial calculation");
        Console.WriteLine("[2] Adding factorials");
        Console.WriteLine("[3] Substractnig factorials");
        Console.WriteLine("[4] Multiplying factorials");
        Console.WriteLine("[5] Division factorials");
        Console.Write("Option: ");
    }
}
