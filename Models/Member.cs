using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace asurance.Models;

public class Member
{
    [Key]
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int MemberId { get; set; }
    public int SubId { get; set; }
    public string MemberType { get; set; }
    public string Title { get; set; }
    public string Firstname { get; set; }
    public string SecondName { get; set; }
    public string Lastname { get; set; }
    public string IDNo { get; set; }
}