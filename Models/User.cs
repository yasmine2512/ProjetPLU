namespace platformApp.Models;

public class User
{
    public int UserID { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string Major { get; set; }
    public string University { get; set; }
    public string Specialty { get; set; }
    public string? PicturePath { get; set; }
}
