
string[] products = { "chebsi", "pepsi", "cocacola", "oruo","fridayicecream" } ;
decimal[] prices = { 10, 15, 17, 7.5m, 10 };
int[] stock= { 200, 3000, 1450, 233, 12 };
bool flow = true;

while (flow)
{
    Console.WriteLine("--- Smart Cashier System ---");
    Console.WriteLine("1. Add / Edit Product\r\n2. View Inventory\r\n3. Sell Product\r\n4. Exit");
    string test = Console.ReadLine();
    int choose = 0;
    while (!(int.TryParse(test, out choose))||choose >4||choose <0)
    {
        Console.WriteLine("please enter a valid num");
         test = Console.ReadLine();
    }


    switch (choose)
    {
        case 1:
            {
                Console.WriteLine("please enter the num of shelf ");
                string shelfs= Console.ReadLine();
                int shelf = 0;
                while (!int.TryParse(shelfs,out shelf)||!(shelf <=5)||!(shelf>0))
                {
                    Console.WriteLine("enter a valid num");
                    shelfs = Console.ReadLine();
                }
                Console.WriteLine("enter the product name ");
                string newproduct = Console.ReadLine();
                products[shelf-1]=new string( newproduct);
                Console.WriteLine("enter the stock");
                string newstocks= Console.ReadLine();
                int newstock = 0;

                while (!int.TryParse(newstocks, out newstock))
                {
                    Console.WriteLine("enter a valid num");
                    newstocks = Console.ReadLine();
                }
                stock[shelf-1]= newstock;  
                Console.WriteLine("enter the price");
                string newprices = Console.ReadLine();
                int newprice = 0;

                while (!int.TryParse(newprices, out newprice))
                {
                    Console.WriteLine("enter a valid num");
                    newprices = Console.ReadLine();
                }
                prices[shelf - 1] = newprice;
                break;
            }
        case 2:
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                    Console.Write($"the product is {products[i]} "); 
                    Console.Write($" his price is {prices[i]} EGP");
                    Console.Write($" his stock is {stock[i]} pices ");
                    Console.WriteLine("\n");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Empty Slot");
                        throw;
                    }
                  
                }
                break;
            }
            case 3:
            {
                for (int i = 0; i < 5; i++)
                {
                  
                    
                        Console.Write($"{i+1}-the product is {products[i]} ");
                        Console.Write($" his price is {prices[i]} EGP");
                        Console.Write($" his stock is {stock[i]} pices ");
                        Console.WriteLine("\n");
                    
                    
                }

                Console.WriteLine("What the num of product are you need?");
                string need = Console.ReadLine();
                int f = 0;
                while (!int.TryParse(need, out f) || f < 1 || f > 4)
                {
                    Console.WriteLine("enter a valid num ");
                    need = Console.ReadLine();
                }
                switch (f)
                {
                    case 1:
                        {
                            if (stock[0] > 0)
                            {
                                Console.WriteLine($"{products[0]} it's great product ");
                                Console.WriteLine("enter the amont");
                                string amonts = Console.ReadLine();
                                int amont = 0;
                                while (!int.TryParse(amonts, out amont) || amont > stock[0])
                                {
                                    Console.WriteLine("enter a valid num ");
                                    amonts = Console.ReadLine();

                                }
                                stock[0] = stock[0] - amont;
                                Console.WriteLine("great we will prepare that ");
                            }
                            else Console.WriteLine("out of stock");
                            break;
                        }
                            case 2:
                                {
                                    if (stock[1] > 0)
                                    {
                                        Console.WriteLine($"{products[1]} it's great product ");
                                        Console.WriteLine("enter the amont");
                                        string amonts = Console.ReadLine();
                                        int amont = 0;
                                        while (!int.TryParse(amonts, out amont) || amont > stock[1])
                                        {
                                            Console.WriteLine("enter a valid num ");
                                    amonts = Console.ReadLine();

                                }
                                stock[1] = stock[1] - amont;
                                        Console.WriteLine("great we will prepare that ");
                                    }
                                    else Console.WriteLine("out of stock");
                                    break;
                                }
                    case 3:
                        {
                            if (stock[2] > 0)
                            {
                                Console.WriteLine($"{products[2]} it's great product ");
                                Console.WriteLine("enter the amont");
                                string amonts = Console.ReadLine();
                                int amont = 0;
                                while (!int.TryParse(amonts, out amont) || amont > stock[2])
                                {
                                    Console.WriteLine("enter a valid num ");
                                     amonts = Console.ReadLine();

                                }
                                stock[2] = stock[2] - amont;
                                Console.WriteLine("great we will prepare that ");
                            }
                            else Console.WriteLine("out of stock");
                            break;
                        }
                    case 4:
                        {
                            if (stock[3] > 0)
                            {
                                Console.WriteLine($"{products[3]} it's great product ");
                                Console.WriteLine("enter the amont");
                                string amonts = Console.ReadLine();
                                int amont = 0;
                                while (!int.TryParse(amonts, out amont) || amont >stock[3])
                                {
                                    Console.WriteLine("enter a valid num ");
                                    amonts = Console.ReadLine();

                                }
                                stock[3] = stock[3] - amont;
                                Console.WriteLine("great we will prepare that ");
                            }
                            else Console.WriteLine("out of stock");
                            break;
                        }
                }

                break;

            }
        case 4: flow = false;break;

    }

   
}