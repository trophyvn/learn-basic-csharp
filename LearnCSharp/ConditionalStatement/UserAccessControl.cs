public class UserAccessControl
{
    public bool IsAuthenticated { get; set; }
    public bool HasPermission { get; set; }
    public bool IsOwner { get; set; }
    public bool IsAdmin { get; set; }

    public string CheckAccess(string resourceType)
    {
        if (!IsAuthenticated)
        {
            return "Bạn cần phải đăng nhập để tiếp tục.";
        }

        switch (resourceType)
        {
            case "document":
                return CheckDocumentAccess();
            case "settings":
                return CheckSettingsAccess();
            default:
                return "Loại tài nguyên không được hỗ trợ.";
        }
    }

    private string CheckDocumentAccess()
    {
        if (IsOwner || IsAdmin || HasPermission)
        {
            return "Bạn có quyền chỉnh sửa tài liệu này.";
        }
        return "Bạn không có quyền chỉnh sửa tài liệu này.";
    }

    private string CheckSettingsAccess()
    {
        if (IsAdmin)
        {
            return "Bạn có quyền truy cập cài đặt hệ thống.";
        }
        return "Bạn không có quyền truy cập cài đặt hệ thống.";
    }
}