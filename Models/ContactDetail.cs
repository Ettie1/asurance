using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asurance.Models
{
    public class ContactDetail
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        public int MemberId { get; set; }
        public string Celphone { get; set; }
        public string Email { get; set; }
        public string HomeTel { get; set; }
        public string WorkTel { get; set; }
        public string Other { get; set; }
    }
}