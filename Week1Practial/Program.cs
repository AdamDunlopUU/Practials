// See https://aka.ms/new-console-template for more information
void task1()
{
    Console.WriteLine("Please enter your name : ");
    String name = Console.ReadLine();
    Console.WriteLine("Please enter your age? : ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Hello " + name + ", you will be " + (age + 5) + " In 5 years");
}

void task2()
{
    Console.WriteLine("Enter Your Age : ");
    int ageofuser = Convert.ToInt32(Console.ReadLine());

    if (ageofuser < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (ageofuser >= 13 && ageofuser <= 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (ageofuser >= 20 && ageofuser <= 110)
    {
        Console.WriteLine("You are an adult");
    }
    else { Console.WriteLine("Invalid Input"); }





    static void Main(string[] args)
    {
        task2();
    }
}
