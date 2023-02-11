class Program
{
    public static void Main(string[] args)
    {
        IBuilder builder1 = new Builder1();
        Director director = new Director(builder1);
        director.Construct();
        Product product = builder1.GetResult();
        product.Show();

        IBuilder builder2 = new Builder2();
        director = new Director(builder2);
        director.Construct();
        Product product1 = builder2.GetResult();
        product1.Show();

        // // ПРАВИЛЬНЫЙ КОД
        // builder1 = new Builder1();
        // DirectorA directorA = new DirectorA(builder1);        
        // directorA.Construct();
        // Product product2 = builder1.GetResult();
        // product2.Show();
        

        // // НЕПРАВИЛЬНЫЙ КОД
        // Здесь создается новый объект directorA, но в конструктор
        // передается старый объект builder1, у которого уже есть информация
        DirectorA directorA = new DirectorA(builder1);     

        // Далее переменной builder1 задается новый объект типа Builder1()
        // но в объектое directorA содержимое builder1 не обновилось!!!
        // directorA ссылается на старый объект builder1
        // builder1 теперь же ссылается на новый объект типа Builder1
        builder1 = new Builder1(); 
        
        // directorA производит операцию Construct()
        // т.к. он оперирует со старым builder1, то в коллекции продукта
        // должно быть пять элементов (т.к. DirectorA задает только две операции)
        directorA.Construct();

        // А результат получаем от нового объекта builder1
        // Но операция Construct() производилась со старым объектом.
        // В итоге ничего отображено не будет.
        Product product2 = builder1.GetResult();
        product2.Show();

    }
}