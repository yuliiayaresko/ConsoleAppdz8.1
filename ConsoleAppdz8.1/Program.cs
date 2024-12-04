
class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}


class Order
{
    private List<Item> itemList = new List<Item>();

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public void DeleteItem(Item item)
    {
        itemList.Remove(item);
    }

    public List<Item> GetItems()
    {
        return itemList;
    }

    public int GetItemCount()
    {
        return itemList.Count;
    }

    public decimal CalculateTotalSum()
    {
        return itemList.Sum(item => item.Price);
    }
}


class OrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Замовлення збережено в базу даних.");
        
    }

    public void Load(int orderId)
    {
        Console.WriteLine($"Замовлення #{orderId} завантажено з бази даних.");
        
    }

    public void Update(Order order)
    {
        Console.WriteLine("Замовлення оновлено.");
        
    }

    public void Delete(int orderId)
    {
        Console.WriteLine($"Замовлення #{orderId} видалено.");
        
    }
}


class OrderPrinter
{
    public void PrintOrder(Order order)
    {
        Console.WriteLine("Друк замовлення...");
        foreach (var item in order.GetItems())
        {
            Console.WriteLine($"Товар: {item.Name}, Ціна: {item.Price}");
        }
    }

    public void ShowOrder(Order order)
    {
        Console.WriteLine("Відображення замовлення...");
        foreach (var item in order.GetItems())
        {
            Console.WriteLine($"Товар: {item.Name}, Ціна: {item.Price}");
        }
    }
}
//код порушував принцип єдиної відповідальності