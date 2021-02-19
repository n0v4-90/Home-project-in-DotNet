using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvp4.Models
{
    [MetadataType(typeof(UserPhysioMetadata))]
    public partial class UserPhysio
    {
        public string ConfirmPassword { get; set; }
    }
    public class UserPhysioMetadata
    {
        [Display(Name = "Fornavn")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fyll ut fornavn")]
        public string Fname { get; set; }

        [Display(Name = "Etternavn")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fyll ut etternavn")]
        public string Lname { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "HPR-Nummer")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fyll ut Ditt Helsepersonell nummer")]
        public int Hprn { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }

    }
}