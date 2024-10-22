using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać imie!")]
    [MaxLength(length:20, ErrorMessage = "Imie zbyt długie")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać nazwisko!")]
    [MaxLength(length:50, ErrorMessage = "Nazwisko zbyt długie zbyt długie")]
    public string LastName { get; set; }
    
    [EmailAddress(ErrorMessage = "Niepoprawny format adresu email!")]
    public string Email { get; set; }
    
    [Phone(ErrorMessage = "Wpisz poprawny numer telefonu")]
    [RegularExpression("\\d\\d\\d \\d\\d\\d \\d\\d\\d", ErrorMessage = "Wpisz numer w formacie XXX XXX XXX!")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
}