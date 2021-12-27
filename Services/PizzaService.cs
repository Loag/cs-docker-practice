using csharp_docker.Models;

namespace csharp_docker.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false, IsCooked = true },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true, IsCooked = true }
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    private static int nextIndex() => Pizzas.LastOrDefault().Id++;

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextIndex();
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzas[index] = pizza;
    }
}