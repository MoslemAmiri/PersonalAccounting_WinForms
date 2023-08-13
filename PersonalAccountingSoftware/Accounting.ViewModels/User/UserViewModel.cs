namespace Accounting.ViewModels.User
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public byte Role { get; set; }
        public string Status { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string CreationDate { get; set; }
        public bool IsBlock { get; set; }
    }
}