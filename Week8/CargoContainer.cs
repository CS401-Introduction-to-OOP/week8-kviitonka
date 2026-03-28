namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> Objects = new List<T>();
    
    public void AddItem(T item)
    {
        Objects.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var o in Objects)
        {
            totalCost += o.CalculateCost();
        }

        return totalCost;
    }
}