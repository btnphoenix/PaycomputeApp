using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Entity
{
    public class Employee
    {
        public string FullName { get; set; }
        [Required, MaxLength(100)]

        public int Id { get; set; } 
        [Required]
        public string EmployeeNo { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string Gender { get; set; }  
        public string ImageUrl { get; set; }    
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }  
        public string Phone { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string SocialSecurityNo { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        public string Address { get; set; }
        [Required, MaxLength(150)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string Postcode { get; set; }
        [Required, MaxLength(50)]
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }


    }
}
