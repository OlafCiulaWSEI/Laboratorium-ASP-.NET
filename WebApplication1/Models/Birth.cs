using System.Runtime.InteropServices.JavaScript;

namespace WebApplication1.Models;

public class Birth
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    
    public object Age()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year; 
        if (BirthDate > today.AddYears(-age)) age--;
        return age;
    }

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Name) && BirthDate < DateTime.Today;
    }
}