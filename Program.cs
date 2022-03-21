int x = 5;
int y = 6; 
double number1 = Math.Pow(x, y);
string name = "Mathew";
//String name = new String("Mathew");

System.Console.WriteLine(Sum(2,2));

name.ToUpper();

SaySomething("Hello World");

int num = Max(2, 4);

System.Console.WriteLine("Enter a number between 1 - 10");
int number = GetInt();

System.Console.WriteLine(number);
   

static int GetInt()
{
    SaySomething("Hello!");
    return Convert.ToInt32(Console.ReadLine());
}
static void SaySomething(string something)
{
    System.Console.WriteLine(something);
}

static int Max(int num1, int num2)
{
    int number1;
    double anotherSomething;

    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

static bool IsTrue()
{
    return false;
}

static int Sum(int num1, int num2)
{
    return num1 + num2;
}
