using ConsoleTables;

namespace CoffieShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decleration
            var bill = new List<Tuple<string, int, int, int>>();
            int order = 0, amount = 0, total = 0, qnos = 0;
            DateTime time = DateTime.Now;
            Console.WriteLine("\n\tWelcome To Cafe O Cafe Shop");
            Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input == 1)
            {
                Console.WriteLine("Enter 1 Coffie (Rs.20)" + "\nEnter 2 Tea (Rs.15)" + "\nEnter 3 Masala Tea (Rs.20)" + "\nEnter 4 Boost (Rs.25)" + "\nEnter 5 Cold Coffie (Rs.25)" + "\nEnter 6 Oreo Milk Shanke (Rs.50)");
                order = Convert.ToInt32(Console.ReadLine());
                if (order == 1)//coffie
                {
                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 20;
                    bill.Add(new Tuple<string, int, int, int>("Coffie", qnos, 20, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                else if (order == 2)
                {

                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 15;
                    Tuple.Create("Tea", 15, amount);
                    bill.Add(new Tuple<string, int, int, int>("Tea", qnos, 15, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                else if (order == 3)
                {
                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 20;
                    bill.Add(new Tuple<string, int, int, int>("Masala Tea", qnos, 20, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else if (order == 4)
                {
                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 25;
                    bill.Add(new Tuple<string, int, int, int>("Boost", qnos, 25, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                else if (order == 5)
                {

                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 25;
                    bill.Add(new Tuple<string, int, int, int>("Cold Coffie", qnos, 25, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                else if (order == 6)
                {

                    Console.WriteLine("Enter the Quantity :");
                    qnos = Convert.ToInt32(Console.ReadLine());
                    amount = qnos * 50;
                    bill.Add(new Tuple<string, int, int, int>("Oreo Milk Shake", qnos, 50, amount));
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Would you like order any Thing , If order Enter 1,Otherwise 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }
            }
            var table = new ConsoleTable("Item", "Nos", "Rate", "Amount");
            foreach (var tuple in bill)
            {
                table.AddRow(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4.ToString());
                total = total + tuple.Item4;
            }
            table.AddRow("Total", "-----", "------", total);

            //Output is Print
            Console.WriteLine("\n\n\tWelcome To Cafe O Cafe Shop");
            Console.WriteLine(time.ToString("  h:mm:ss tt") + "\t\t\t" + time.ToString("yyyy-MM-dd"));       
            Console.WriteLine(table);
            Console.WriteLine("\tThank For you Comming, Visit Again" );
        }

    }
}