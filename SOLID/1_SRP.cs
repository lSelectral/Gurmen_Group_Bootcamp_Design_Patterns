// Single Responsibility Principle
/// <summary>
/// This principle indicates, every class should have its own responsibility.
/// </summary>

/*
 * As shown below, every class has its own responsibility and has its own method/property/fields.
 */

public class Customer
{
    public string name;
    public string order;
}

public class FoodService
{
    public void GetFoodRequests() { }

    public void PrepareFoods() { }

    public void ServeFoods() { }
}

public class OrderService
{
    public void GetOrder() { }

    public void UpdateOrder() { }

    public void DeleteOrder() { }
}

public class TableService
{
    public void SetTable() { }

    public void CleanTable() { }
}

public class BillService
{
    public void CalculateBill() { }

    public void ApplyDiscount() { }
}