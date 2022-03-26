// 5. Dependency Inversion Principle

/*
 * The Dependency Inversion Principle (DIP) states that high-level 
 * modules/classes should not depend on low-level modules/classes. 
 * Both should depend upon abstractions.
 */

#region BAD CODE
public class FactoryWorker
{
    public void DoWork() { }
}

public class WarehouseWorker
{
    public void DoWork() { }
}

public class WorkerManagementSystem
{
    public void StartFactoryWorker()
    {
        FactoryWorker factoryWorker = new();
        factoryWorker.DoWork();
    }

    public void StartWarehouseWorker()
    {
        WarehouseWorker warehouseWorker = new();
        warehouseWorker.DoWork();
    }
}
#endregion

/*
 * In above bad code, every worker instantiated 
 */

#region GOOD CODE

public interface IWorker
{
    void DoWork();
}

public class FactoryWorker_Good : IWorker
{
    public void DoWork()
    {
    }
}

public class WarehouseWorker_Good : IWorker
{
    public void DoWork()
    {
    }
}

public class WorkerManagementSystem_Good
{
    public void StartWork(IWorker worker)
    {
        worker.DoWork();
    }
}

#endregion