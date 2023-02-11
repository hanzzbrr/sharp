namespace Mazegame
{


 class Program
{
    public static void Main(string[] args)
    {
        var mazeGame = new Mazegame();
        var maze = mazeGame.CreateMaze(new BombedMazeFactory());

        var currentRoom = maze.RoomNo(1);
        currentRoom.Enter();
        var dir = currentRoom.GetSide(Direction.East);
        System.Console.WriteLine("Entering dir");
        dir.Enter();
    }
}
}