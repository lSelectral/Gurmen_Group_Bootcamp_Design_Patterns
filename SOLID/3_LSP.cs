// 3. Liskov Substitution Principle
// Derived and parent class should be interchangable

// Child classes shouldn't inherit members and functions from parent that won't be usable for them.

#region Bad Example witout using LSP
public abstract class Adult_Bad
{
    public void Walk() { }

    public void Talk() { }

    public void Eat() { }

    public void GoToWork() { }

    public void CookFood() { }
}

public class Child_Bad : Adult_Bad
{
    // Child can't Go To Work and Cook Food.
    // They should be removed
}
#endregion

#region Good Example with using LSP

// Interface is better because walking and talking can have different functions for child and adults.

public interface IChild
{
    void Walk();
    void Talk();
    void Eat();
}

public interface IAdult
{
    void GoToWork();
    void CookFood();
}

public class Child_Good : IChild
{
    public void Eat(){}

    public void Talk(){}

    public void Walk(){}
}

public class Adult_Good : IChild, IAdult
{
    public void CookFood(){}

    public void Eat(){}

    public void GoToWork(){}

    public void Talk(){}

    public void Walk(){}
}

#endregion
