//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_26.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BloodBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BloodBank()
        {
            this.BloodBags = new HashSet<BloodBag>();
        }

        public int bank_id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Bank name is required")]
        public string bank_name { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = " Bank address is required")]
        public string bank_address { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = " Bank phone number is required")]
        public int bank_phone { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = " Bank email is required")]
        [DataType(DataType.EmailAddress)]
        public string bank_email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = " Stock id is required")]
        public int Stock_id { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public bool RememberMe { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BloodBag> BloodBags { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
