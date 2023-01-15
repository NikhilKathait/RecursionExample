class Sample
{
    public double Factorial(int number)
    {
        if(number == 0)
        {
            return 1;
        }
        else
            return number*Factorial(number-1); //Recursion as we are calling same method
    }

    static void Main()
    {
        //Read a number from keyboard
        System.Console.WriteLine("Enter a number : ");
        int n = int.Parse(System.Console.ReadLine());

        //Create an object
        Sample S = new Sample();

        //Call Factorial method
        double fact = S.Factorial(n);

        System.Console.WriteLine("Factorial of " +n+ " is : " +fact);
        System.Console.ReadKey();
    }
}