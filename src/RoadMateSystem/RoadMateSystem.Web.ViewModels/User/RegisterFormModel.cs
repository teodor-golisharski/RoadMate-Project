namespace RoadMateSystem.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;

    using static RoadMateSystem.Common.EntityValidationConstants.ApplicationUser;
    public class RegisterFormModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [Display(Name = "First Name")]
        [StringLength(FirstNameMaxLength, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(LastNameMaxLength, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(PhoneNumberMaxLength, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = PhoneNumberMinLength)]
        public string Phone { get; set; } = null!;

        [Required]
        [Display(Name = "Address")]
        [StringLength(AddressMaxLength, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = AddressMinLength)]
        public string Address { get; set; } = null!;
    }
}
