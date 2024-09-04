public class CoffeeShop
{
    private Dictionary<string, decimal> menus = new Dictionary<string, decimal> { };
    private Dictionary<string, decimal> order = new Dictionary<string, decimal> { };
    public void Start()
    {

        while (true)
        {
            Console.WriteLine("Welcome to the Coffee Shop!\r\n" +
                                "1. Add Menu Item\r\n" +
                                "2. View Menu\r\n" +
                                "3. Place Order\r\n" +
                                "4. View Order\r\n" +
                                "5. Calculate Total\r\n" +
                                "6. Exit\r\n" +
                                "Select an option: ");
            string Selected = Console.ReadLine();

            switch (Selected)
            {
                case "1":
                    AddMenuItem();
                    break;

                case "2":
                    ViewMenu();
                    break;

                case "3":
                    PlaceOrder();
                    break;

                case "4":
                    ViewOrder();
                    break;

                case "5":
                    CalculateTotal();
                    break;

                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }


    }
    private void AddMenuItem()
    {
        Console.WriteLine("Enter item name: ");
        string newmenu = Console.ReadLine();
        Console.WriteLine("Enter item price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        if (price >= 0)
        {
            menus.Add(newmenu, price);
            Console.WriteLine("Item added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid Price");
        }
    }

    private void ViewMenu()
    {
        int i = 0;
        Console.WriteLine("Menu: ");
        foreach (var x in menus)
        {
            i++;
            Console.WriteLine(i + "." + x.Key + " - " + x.Value);
        }
    }

    private void PlaceOrder()
    {
        int i = 0;
        Console.WriteLine("Menu: ");
        foreach (var x in menus)
        {
            i++;
            Console.WriteLine(i + "." + x.Key + " - " + x.Value);
        }
        Console.WriteLine("Enter the item number to order: ");
        int order_no = int.Parse(Console.ReadLine());
        if (order_no >= 1 && order_no <= menus.Count)
        {
            int y = 0;
            foreach (var x in menus)
            {
                y++;
                if (y == order_no)
                {
                    order[x.Key] = x.Value;
                    Console.WriteLine("Item added to order!");
                }
            }
        }

        else
        {
            Console.WriteLine("Invalid Order");
        }
    }

    private void ViewOrder()
    {
        Console.WriteLine("Your Order:");
        foreach (var a in order)
        {
            Console.WriteLine(a.Key + " - " + a.Value);
        }
    }

    private void CalculateTotal()
    {
        decimal total_amount = order.Values.Sum();
        Console.WriteLine("Total Amount Payable by admin: " + total_amount);
    }
}

