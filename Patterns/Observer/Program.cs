using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        /*
            Создать Subject (издеталя).
            Добавить издателю конкретных подписчиков.
            Установить состояние издателя.
            Вызвать Notify() издателя.
        */

        ConcreteSubject subj = new ConcreteSubject() { Name = "Coole"};
        subj.Attach(new ConcreteObserver(subj) {Name = "Alex"});
        subj.Attach(new ConcreteObserver(subj) {Name = "Maria"});
        subj.Attach(new ConcreteObserver(subj) {Name = "Wolf"});
        subj.State = "Magazine March";
        subj.Notify();
        subj.State = "Magazien December";
        subj.Notify();
    }
}


/*
    В интерфейсе Observer есть единственный метод:
    Update(State)
*/
abstract class Observer
{
    public abstract void Update(string state);
}

/*
    Содрежит:
        конкретный state (Филд)
        ссылку на издателя 
    Методы:
        конструктор, принимающий объект издателя
        Метод Update(state) - в результате наследования
    Реализует (наследует):
        Observer
*/
class ConcreteObserver : Observer
{
    private string state;
    private Subject subject;
    public string Name { get; set; }

    public ConcreteObserver(Subject subject)
    {
        this.subject = subject;
    }

    public override void Update(string state)
    {
        this.state = state;
        System.Console.WriteLine($"{Name}! {state}");
    }
}

/*
    Содержит:
        коллекцию элементов Observer
    Интерфейс:
        состояние (авто-проперти)
    Методы:
        ПриаттачитьПодписчика(Observer)
        ЗадеаттачитьПодписчика(Observer)
        Уведомить подписчика
*/
abstract class Subject
{
    private List<Observer> observers = new List<Observer>();

    public abstract string State { get; set; }

    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Deattach(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach(var o in observers)
            o.Update(State);
    }
}

/*
    Реализует состояние своим способом
    Реализует:
        Observer 
*/
class ConcreteSubject : Subject
{
    private string _state;
    public string Name { get; set;}
    public override string State
    {
        get
        {
            return _state + " " + Name;
        }
        set
        {
            _state = value;
        }
    }
}