using System.Diagnostics.Metrics;

public class Program
{
    public static void Main()
    {
        //string FirstName, MiddleName, LastName, FullName;

        //Console.WriteLine("Please Enter First Name");
        //FirstName = Console.ReadLine();

        //Console.WriteLine("Please Enter Middle Name");
        //MiddleName = Console.ReadLine();

        //Console.WriteLine("Please Enter Last Name");
        //LastName = Console.ReadLine();

        //FullName = FirstName + ' ' + MiddleName + ' ' + LastName;

        //Console.WriteLine(FullName);




        //Calculate Length Of String
        //Console.WriteLine("Please Enter Any String");
        //var str = Console.ReadLine();

        //int counter = 0;
        //foreach (var item in str)
        //{
        //    counter++;
        //}
        //Console.WriteLine("Length of String=" +counter);



        //Calculate Vowels From The String

        Console.WriteLine("Please Enter Any String");
        var str = Console.ReadLine();

        int vowelsCounter = 0;
        foreach (var item in str)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item  == 'o' || item == 'u' ||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                vowelsCounter++;  
            }
            
        }
        Console.WriteLine("Length of String=" +vowelsCounter);
    }
}