internal class ShoppingCart
{
    private List<string> _items;

    public ShoppingCart()
    {
        _items = new List<string>();
    }

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public void RemoveItem(string item)
    {
        _items.Remove(item);
    }

    public int GetItemCount()
    {
        return _items.Count;
    }
}
