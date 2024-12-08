using System.Dynamic

namespace Functions_training
{
    internal class Program
    {
        static List<int> Printnumbers(List<int> modified) {
            Console.Write("[");
            for (int i = 0; i < modified.Count; i++) { 
               
                Console.Write($"{modified[i]},");

            }
            Console.Write("]");
            Console.WriteLine();

            return modified;
        }
        static void AddNumber(List<int> values)
        {
            Console.WriteLine("Please Add Number:");
            int number = int.Parse(Console.ReadLine());

            if (values.Contains(number)) //https://www.programiz.com/csharp-programming/library/string/contains//
            {
                Console.WriteLine("The number is already found.");
            }
            else
            {
                values.Add(number);
                Console.WriteLine("The Number Has Been Added!");
            }
            Console.WriteLine("");
        }
        static int getmean(List<int> values) {
            if (values.Count == 0)
            {
                Console.WriteLine("list is empty");

            }
            else {
            }
            int Sum = 0;
            int count = values.Count;
            for (int i = 0; i < values.Count; i++)
            {
                Sum += values[i];
            }
            int mean = Sum / count;
            Console.WriteLine($"your Mean is : {mean}");
            Console.WriteLine("");
            return mean;
        }
        static int GetSmallest(List<int> values) {
            if (values.Count == 0)
            {
                Console.WriteLine("list is empty");

            }
            int smallest = values[0];
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] < values[0])
                {
                    smallest = values[i];
                }
            }
            Console.WriteLine($"The Smallest number is {smallest}");
            return smallest;
        }
        static int GetGreatest(List<int> values) {
            if (values.Count == 0) {
                Console.WriteLine("List Is Empty");
            }
            int Biggest = values[0];
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] > values[0])
                {
                    Biggest = values[i];
                }
            }
            Console.WriteLine($"The Largest number is {Biggest}");
            return Biggest;
        }
        static int Getindex(List<int> values) {
            if (values.Count == 0)
            {
                Console.WriteLine("the list is already empty");
                Console.WriteLine("");
               

            }
            else
                Console.WriteLine("Please Enter Number You Want To Search For: ");
            int newnumber = int.Parse(Console.ReadLine());
            int UserNumber = 0;
            if (values.Contains(newnumber))
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i] == newnumber)
                    {
                        UserNumber = i;
                    }
                }
            }
            Console.WriteLine($"Your number is at index {UserNumber}");
            return UserNumber;
        }
        static void clear(List<int> values) {
            values.Clear();
            Console.WriteLine("Your List celared Succefully !");
        }
        static void getassending(List<int> values) {
            int temp;
            for (int i = 0; i < values.Count - 1; i++)
            {
                for (int j = 0; j < values.Count - 1; j++)
                {
                    if ((values[j] > values[j + 1]))
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Your array sorted ascendingly:");
            for (int k = 0; k < values.Count; k++)
            {
                Console.WriteLine($"Element at index {k + 1}: {values[k]}");
            }
        }
        static void getdescending(List<int> values) {
            int swap;
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values.Count - 1; j++)
                {
                    if (values[j] < values[j + 1])
                    {
                        swap = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = swap;

                    }
                }
            }

            Console.WriteLine("Your array sorted descendingly:");
            for (int k = 0; k < values.Count; k++)
            {
                Console.WriteLine($"Element at index {k + 1}: {values[k]}");
            }
        }
        static void Main(string[] args)
        {
            List<int> modified = new List<int>() { 3,2, 4, 5, 6, 7, 8, 9 };
            char selection = '\0';
            do
            {
                Console.WriteLine("P-Print numbers");
                Console.WriteLine("A-Add numbers");
                Console.WriteLine("D-Display Mean of Numbers");
                Console.WriteLine("S-Display smallest numbers");
                Console.WriteLine("L-Display largest numbers");
                Console.WriteLine("F-Find index of number");
                Console.WriteLine("C-Clear all list ");
                Console.WriteLine("U-order list in ascending");
                Console.WriteLine("X-order list in dscending");
                Console.WriteLine("Q-Quit");
                Console.Write("Enter your choice: ");
                selection = char.ToUpper(char.Parse(Console.ReadLine()));
                switch (selection)
                {
                    case 'P':
                        if (modified.Count == 0) {
                            Console.WriteLine("the list is already empty !");
                            Console.WriteLine("");
                        }else
                        Printnumbers(modified);
                        break;
                    case 'A':
                        AddNumber(modified);
                        break;
                    case 'D':
                        getmean(modified);
                        break;
                    case 'S':
                       GetSmallest(modified);
                        break;
                    case 'L':
                       GetGreatest(modified);
                        break;
                    case 'F':
                       Getindex(modified);
                        break;
                    case 'C':
                        clear(modified);
                        break;
                    case 'U':
                       getassending(modified);
                        break;
                    case 'X':
                        getdescending(modified);
                        break;
                    case 'Q':
                        Console.WriteLine("Thank You GoodBye");
                     break;
                    default:
                        Console.WriteLine("Please Enter Valid Input");
                        Console.WriteLine(" ");
                        break;
                }


            }
            while (selection != 'Q');
            
            
            
            ;

  
        }
    }
}
