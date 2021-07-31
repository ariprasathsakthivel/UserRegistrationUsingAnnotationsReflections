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
    }
}
