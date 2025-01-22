namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var userInput = int.Parse(Console.ReadLine());

        if(userInput%2 ==0){
            Console.WriteLine("This number is even!");
        }
        else{
            Console.WriteLine("This number is odd :(");
        }

        Console.WriteLine("Your number is: " + userInput);
    }
}
