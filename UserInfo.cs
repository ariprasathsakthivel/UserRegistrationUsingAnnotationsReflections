using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegUsingAnnotationsReflections
{
    class UserInfo
    {
        [Required(ErrorMessage = "{0} is Required")]
        [DataType(DataType.Text,ErrorMessage ="First name can contain only characters")]
        [StringLength(50, MinimumLength = 3,ErrorMessage ="First name must contain minimum 3 letters")]
        [RegularExpression(@"^[A-Z]{1}.+$",ErrorMessage ="The first letter should be in upper case")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "{0} is Required")]
        [DataType(DataType.Text, ErrorMessage = "Last name can contain only characters")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must contain minimum 3 letters")]
        [RegularExpression(@"^[A-Z]{1}.+$", ErrorMessage = "The first letter should be in upper case")]
        public string LastName { get; set; }


        [Required(ErrorMessage ="{0} is mandatory")]
        [StringLength(30,MinimumLength =10, ErrorMessage ="Please enter a valid email ID")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} is mandatory")]
        [StringLength(13,ErrorMessage ="Please enter a valid phone number")]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage ="{0} is mandatory")]
        [StringLength(30,MinimumLength =8,ErrorMessage ="Pasword should contain atleast 8 character and atmost 30 characters")]
        [RegularExpression(@"^(?=.*[A-Z]).+$", ErrorMessage ="Password should contain atleast one upper case letter")]
        public string Password { get; set; }
    }
}
