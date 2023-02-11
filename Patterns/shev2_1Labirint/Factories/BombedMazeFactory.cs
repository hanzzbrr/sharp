using Mazegame;

class BombedMazeFactory : MazeFactory
{
    public override Wall MakeWall()
    {
        return new BombedWall();
    }

    public override Room MakeRoom(int number)
    {
        return new RoomWithBomb(number);
    }
}