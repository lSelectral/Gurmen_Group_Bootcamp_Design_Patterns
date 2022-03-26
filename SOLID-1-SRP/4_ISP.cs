// 4. Interface Segragation Principle

/*
 * Classes shouldn't be forced to implement interfaces they won't use.
 * Interfaces should be divided if only small part of interface is needed
 */

// Below shown the bad and good practice for ISP from chess game.

#region Bad Practice
public interface IMovable
{
    public void MoveVertical();
    public void MoveHorizontal();
    public void MoveDiagonal();
}

public class Queen : IMovable
{
    public void MoveDiagonal()
    {
    }

    public void MoveHorizontal()
    {
    }

    public void MoveVertical()
    {
    }
}

/*
 * This implemantation is wrong because, in chess pawn can only go forward
 * But because of interface it has to implement.
 * Now let's do the correct one
 */

public class Pawn : IMovable
{
    public void MoveDiagonal()
    {
    }

    public void MoveHorizontal()
    {
    }

    public void MoveVertical()
    {
    }
}
#endregion

#region GoodPractice
public interface IForward
{
    public void MoveForward();
}
public interface IBackward
{
    public void MoveBackward();
}
public interface IHorizontal
{
    public void MoveHorizontal();
}
public interface IDiagonal
{
    public void MoveDiagonal();
}

public class Queen_Good : IForward, IBackward, IHorizontal, IDiagonal
{
    public void MoveBackward()
    {
    }

    public void MoveDiagonal()
    {
    }

    public void MoveForward()
    {
    }

    public void MoveHorizontal()
    {
    }
}

public class Pawn_Good : IForward
{
    public void MoveForward()
    {
    }
}
#endregion
