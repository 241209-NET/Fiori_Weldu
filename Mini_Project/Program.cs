// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



namespace computerShop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("computer shoping");
        List<computer> ComputerList = new List<computer>();
        bool cycle=true;

        while (cycle)                          
        {
            
            Console.WriteLine("1. which brand are you looking");
            Console.WriteLine("2. checkout");
            Console.WriteLine("3. exit");
           

            string? option = Console.ReadLine();   

            if (string.IsNullOrWhiteSpace(option))
                {
                    Console.WriteLine("Invalid input");
                }      

            switch (option)
            {
                case "1":
                    AddComputers( ComputerList);
                    break;
                case "2":
                    CalculateTotal(ComputerList);
                    break;
                case "3":
                    cycle = false;
                    break;
                default:                                    
                    break;
            }
        }
        Console.WriteLine("See you!");
    
    }

    static void AddComputers(List<computer>  ComputerList)
    {
        string brand = "";
        bool cycle4 = false;

        while (!cycle4)
        {
            Console.Write("Enter brand: ");
            brand = Console.ReadLine()?.Trim();              

            if (brand.Length == 0)
            {
                Console.WriteLine("please enter a brand.");
                continue;
            } 
            if (true)
            {
                cycle4 = true;
            }
        }
        
        int ram = 0;
        bool cycle2 = false;

        while (!cycle2)
        {
            Console.Write("Enter valid ram size ");
            string? priceInput = Console.ReadLine();                 
            
            ram = int.Parse(priceInput);
            if ((ram== 4 )|| (ram== 8) || (ram== 16) || (ram== 32) || (ram==64)) 
            {
                cycle2= true;
            }
            else
            {
                Console.WriteLine("please enter valid ram sizes");
            }
        }

        double price = 0;
        bool cycle3 = false;

         while (!cycle3)
        {
            Console.Write("Enter the price ");
            string? priceInput = Console.ReadLine();                 
            
            price = double.Parse(priceInput);
            if (price>0) 
            {
                cycle3= true;
            }
            else
            {
                Console.WriteLine("enter valid price");
            }
        }

        computer computer = new computer(brand, ram, price);
        ComputerList.Add(computer);
        Console.WriteLine($"Added: [ {brand}: {ram}: ${price:F2} ]");   
    }
    static void CalculateTotal(List<computer>  ComputerList)
    {
        if (ComputerList.Count == 0)
        {
            Console.WriteLine("Add computers first.");
            return;
        }

        double totalprice = 0;

        foreach (var comp in ComputerList)                  
        {
            totalprice = totalprice + comp._Price;
       
        }
         Console.WriteLine($" your total is: [ {totalprice:F2} ]");
        
    }
}