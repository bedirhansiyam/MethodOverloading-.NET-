namespace MethodOverloading;
class Program
{
    static void Main(string[] args)
    {
        string number = "100";
        int outNumber;
        Methods sampleMethod = new Methods();

        // Out Methods

        bool result = int.TryParse(number, out outNumber);
        if(result)
        {
            Console.WriteLine("Successful");
            Console.WriteLine(outNumber);
        }
        else
        {
            Console.WriteLine("Unsuccessful");
        }

        sampleMethod.Sum(11, 24, out int resultSum);
        Console.WriteLine(resultSum);


        // Overloading Methods

        sampleMethod.WriteToScreen("Hello World!");
        sampleMethod.WriteToScreen(54);
        sampleMethod.WriteToScreen("Hello", "World!");

    }
}

class Methods
{    
    // Out Method
    public void Sum(int a, int b, out int sum)
    {
        sum = a + b;
    }

    // Overloading Method
    public void WriteToScreen(string data)
    {
        Console.WriteLine(data);
    }
    public void WriteToScreen(int data)
    {
        Console.WriteLine(data.ToString());
    }
    public void WriteToScreen(string data, string data1)
    {
        Console.WriteLine(data + " " + data1);
    }
}
