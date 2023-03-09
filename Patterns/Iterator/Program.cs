using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
		aggregate[0] = "Something";
		aggregate[1] = "Element";

		Iterator i = aggregate.CreateIterator();
		object item = i.First();
		while(!i.IsDone())
		{
			System.Console.WriteLine($"Item is: {item}");
			item = i.Next();
		}
    }
}

abstract class Aggregate
{
	/*
		Создать итератор
		Посчитать количество элементов (проп, set для чилдов)
		Получить элемент по индексу
	*/
	// Значимым является этот элемент интерфейса! 
	public abstract Iterator CreateIterator();

	public abstract int Count { get; protected set; }
	public abstract object this[int index] { get; set;}
}

// Реализовать Aggregate 

class ConcreteAggregate : Aggregate
{
	/*
		- коллекция
		+ Создать итератор: возвращать конкретный
		+ Посчитать количество элементов
		+ Получить элемент по индексу ( get; set;)
		~ Без явного конструктораы
	*/
	private readonly ArrayList _items = new ArrayList(5);
	
	
	// Значимым является этот метод !!!
	public override Iterator CreateIterator()
	{
		return new ConcreteIterator(this);
	}
	
	public override int Count
	{
		get => _items.Count;
		protected set { }
	}
	
	public override object this[int index]
	{
		get { return _items[index]; }
		set { _items.Insert(index, value); }
	}
}


class ConcreteIterator : Iterator
{
	/*
		Филды:
		- Aggregate
		- current - счетчик (или указатель) на текущий элемент
	*/

	private readonly Aggregate _aggregate;
	private int _current;

	public ConcreteIterator(Aggregate aggregate)
	{
		_aggregate = aggregate;
	}

	public override object First()
	{
		return _aggregate[0];
	}

    public override object Next()
    {
        object ret = null;
		_current++;
		if(_current < _aggregate.Count)
		{
			ret = _aggregate[_current];
		}
		return  ret;
    }

    public override object Current()
    {
        return _aggregate[_current];
    }

    public override bool IsDone()
    {
        return _current >= _aggregate.Count;
    }
}


abstract class Iterator
{
	/*
		первый
		следующий
		сделано?
		текущий
	*/
	
	public abstract object First();
	public abstract object Next();
	public abstract bool IsDone();
	public abstract object Current();
}