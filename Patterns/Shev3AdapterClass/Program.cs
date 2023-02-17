class Program
{
    static void Main()
    {
        // Кривой вариант
        Adaptee ad = new Adaptee();
        ad.SpecificRequest();
        ad.SpecificInterfaceMethod();   // здесь ненужный интерфейс доступен!!!

        ITarget target = new Adapter();
        target.Request();   // здесь ненужный интерфейс недоступен

        ITarget trueAdapter = new TrueAdapter();
        trueAdapter.Request();  // точно также как и здесь


        // еще можно сделать вот так
        Adapter adapter = new Adapter();
        adapter.OneMoreSpecificInterface(); // здесь добавляется еще лишнего интерфейса
    }
}