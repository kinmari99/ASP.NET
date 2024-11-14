using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab3.Models
{
    public class Dane
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; } 


        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage ="Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Prosze podaj Haslo")]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d).*(?=.*[a-z]).*(?=.*[A-Z]).*)")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze powtorz Haslo")]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d).*(?=.*[a-z]).*(?=.*[A-Z]).*)")]
        [Compare(nameof(Haslo), ErrorMessage =("Hasla roznia sie"))]
        public string powtorzHaslo { get; set; }


        
        [Phone(ErrorMessage ="Podaj właściwy numer telefonu")] 
        [MaxLength(14)]
        public string numerTelefonu { get; set; }


        [Range(10, 80)]
        
        public int wiek { get; set; }

        public string Miasto { get; set; }
        public enum Miasta { Kraków, Wrocław, Warszawa, Łódz, Gdańsk}

       

    }
}
