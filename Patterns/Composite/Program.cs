public class Program
{
    public static void Main(string[] args)
    {
        Component root = new Composite("ROOT");
        Component br1 = new Composite("BR1");
        Component br2 = new Composite("BR2");
        Component l1 = new Leaf("Leaf1");
        Component l2 = new Leaf("Leaf2");
        Component l3 = new Leaf("Leaf3");

        root.Add(br1);
        root.Add(br2);
        br1.Add(l1);
        br2.Add(l2);
        br2.Add(l3);

        root.Operation();
    }
}

abstract class Component
{
    /*
        Есть имя компонента, а также
        Конструктор компонента
        Есть методы добавления и удаления компонентов
        Есть методы действий Operation1-N()
        А так же методы получения компонентов,
        например по индексу.
    */
    protected string name;
    public Component(string name)
    {
        this.name = name;
    }

    public abstract void Operation();
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract Component GetChild(int index);

}


class Composite : Component
{
    List<Component> nodes = new List<Component>();


    public Composite(string name) : base(name)
    {

    }

    public override void Add(Component component)
    {
        nodes.Add(component);
    }

    public override Component GetChild(int index)
    {
        return nodes[index];
    }

    public override void Operation()
    {
        System.Console.WriteLine($"Father name: {name}");
        foreach(var item in nodes)
            item.Operation();
    }

    public override void Remove(Component component)
    {
        nodes.Remove(component);
    }
}

/*
    Чайлдов нет, поэтому методы для работы с чайлдами
    возвращают исключения
*/
class Leaf : Component
{
    public Leaf(string name) : base(name)
    {

    }

    public override void Operation()
    {
        System.Console.WriteLine($"Operation 1 is here {name}!!!!");
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public override Component GetChild(int index)
    {
        throw new NotImplementedException();
    }
}