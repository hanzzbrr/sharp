new Thread(ThreadSafe.Go).Start();
new Thread(ThreadSafe.Go).Start();

new Thread(NonThreadSafe.Go).Start();
new Thread(NonThreadSafe.Go).Start();

new Thread(GoException).Start();

// ловля эксепшенов происходит внутри метода, а не при запуске треда
static void GoException()
{
    try
    {
        throw null;
    }
    catch(Exception ex)
    {
        System.Console.WriteLine($"ThreadException > Поймали: {ex}");
    }
}


// Безопасный тред, общий объект залочен
class ThreadSafe
{
    static bool done;
    static readonly object locker = new object();

    public static void Go()
    {
        lock(locker)
        {
            if(!done) { System.Console.WriteLine("With lock > Done"); done = true; }
        }
    }

}

// Не безопасный трединг, общий объект done не залочен
class NonThreadSafe
{
    static bool done;

    public static void Go()
    {
        if(!done) {System.Console.WriteLine("Without lock > Done"); done = true; }
    }
}