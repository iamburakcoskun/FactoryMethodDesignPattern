
AnkaraPizzaStore aps=new AnkaraPizzaStore();
IstanbulPizzaStore ips=new IstanbulPizzaStore();

IPizza cheesePizza = aps.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in Ankara Store.");

IPizza veggiPizza = ips.OrderPizza("veggi");
Console.WriteLine("Veggi pizza ordered in Istanbul Store.");



interface IPizza
{
    void Prepare();

    void Bake();

    void Cut();
}

class CheesePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Cheese pizza prepared.");
    }

    public void Bake()
    {
        Console.WriteLine("Cheese pizza baked.");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese pizza cut.");
    }
}

class VeggiPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Veggi pizza prepared.");
    }

    public void Bake()
    {
        Console.WriteLine("Veggi pizza baked.");
    }

    public void Cut()
    {
        Console.WriteLine("Veggi pizza cut.");
    }
}

abstract class PizzaStore
{
    protected abstract IPizza CreatePizza(string type);

    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();

        return pizza;
    }
}

class AnkaraPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese"=>new CheesePizza(),
            "veggi"=>new VeggiPizza(),
            _=>throw new ArgumentException(nameof(type))
        };
    }
}

class IstanbulPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _ => throw new ArgumentException(nameof(type))
        };
    }
}