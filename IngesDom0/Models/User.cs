using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngesDom0.Models
{
    public enum SexeEnum { Masculin, Feminin }
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        [Required]
        public SexeEnum Sexe { get; set; }
    }
}
