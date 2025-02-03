using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace asurance.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [HiddenInput]
        public string AddressType { get; set; }
        [HiddenInput]
        public int MemberId { get; set; }
        [DisplayName("Street")]
        public string Addr1 { get; set; }
        [DisplayName("Suburb")]
        public string Addr2 { get; set; }
        [DisplayName("Town/City")]
        public string Addr3 { get; set; }
        [DisplayName("Code")]
        public string Addr4 { get; set; }
    }
}