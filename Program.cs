using System.Diagnostics.Metrics;

public class Program
{
    public static void Main()
    {
        //ShowFullName();             //Function Call

       // ClaculateLengthOfString();

       // CalculateVowels();

        StringManipulation();
    }

    static void ShowFullName()
    {
        string FirstName, MiddleName, LastName, FullName;

        Console.WriteLine("Please Enter First Name");
        FirstName = Console.ReadLine();

        Console.WriteLine("Please Enter Middle Name");
        MiddleName = Console.ReadLine();

        Console.WriteLine("Please Enter Last Name");
        LastName = Console.ReadLine();

        FullName = FirstName + ' ' + MiddleName + ' ' + LastName;

        Console.WriteLine(FullName);
    }


    static void ClaculateLengthOfString()
    {

        //Calculate Length Of String
        Console.WriteLine("Please Enter Any String");
        var str = Console.ReadLine();

        int counter = 0;
        foreach (var item in str)
        {
            counter++;
        }
        Console.WriteLine("Length of String=" + counter);

    }

    static void CalculateVowels()
    {
         //Calculate Vowels From The String

         Console.WriteLine("Please Enter Any String");
         var str = Console.ReadLine();

         int vowelsCounter = 0;
         foreach (var item in str)
         {
             if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                 item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
             {
                 vowelsCounter++;
             }

         }
         Console.WriteLine("Length of String=" + vowelsCounter);
    }

    private static void StringManipulation()
    {
        Console.WriteLine("Enter Any String");
        var str = Console.ReadLine();

        //Calculate Number of Spaces
        int SpaceCounter = 0;
        int ConsonentCounter = 0;
        foreach (char ch in str)
        {
            if (ch == ' ')
            {
                SpaceCounter++;
            }

            if (!(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == ' ' ||
                  ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            {
                ConsonentCounter++;
            }
        }
        Console.WriteLine("Number of Spaces =" + SpaceCounter);
        Console.WriteLine("Number of Words =" + (SpaceCounter + 1));
        Console.WriteLine("Number of Consonent =" + ConsonentCounter);
    }

}