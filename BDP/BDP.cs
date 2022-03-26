//Bridge Design Pattern ( HasA, IsA)
// BDA choose HasA relation over IsA relation.

public interface IRightLeft
{
    void GoLeft();
    void GoRight();
}

public interface IBackward
{
    void GoBackward();
}

public abstract class Vehicle
{
    public void GoForward() { }
    public string name;
    public double price;
    public double speed;
    public string brand;
    public string productionYear;
}

public class Car : Vehicle, IRightLeft, IBackward
{
    public void GoBackward()
    {
    }

    public void GoLeft()
    {
    }

    public void GoRight()
    {
    }
}

public class Train : Vehicle
{

}

public class NoBackwardCard : Vehicle, IRightLeft
{
    public void GoLeft()
    {
    }

    public void GoRight()
    {
    }
}
