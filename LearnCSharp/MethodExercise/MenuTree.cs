public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public List<MenuItem> Children { get; set; } // Danh sách chứa các mục con

    public MenuItem(int id, string name, int? parentId)
    {
        Id = id;
        Name = name;
        ParentId = parentId;
        Children = new List<MenuItem>(); // Khởi tạo danh sách rỗng cho các mục con
    }
}

public class MenuTree
{
    public static List<MenuItem> BuildMenuTree(List<MenuItem> menuItems, int? parentId = null)
    {
        List<MenuItem> result = new List<MenuItem>();
        foreach (var item in menuItems)
        {
            if (item.ParentId == parentId)
            {
                // Tìm và xây dựng danh sách con cho mục menu này
                item.Children = BuildMenuTree(menuItems, item.Id);
                result.Add(item);
            }
        }
        return result;
    }

    public static void DisplayMenuTree(List<MenuItem> menuTree, int level)
    {
        string indent = new String('-', level * 2);
        foreach (var item in menuTree)
        {
            Console.WriteLine($"{indent}> {item.Name}");
            if (item.Children.Count > 0)
            {
                // Gọi đệ quy để hiển thị các mục con
                DisplayMenuTree(item.Children, level + 1);
            }
        }
    }
}