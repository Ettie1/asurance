using asurance.Models;

namespace asurance.ViewModels;

public class MainMemViewModel
{
    public int MainMemberId { get; set; }
    public Member MainMember { get; set; }
    public Member Dependant {get; set;}
    public Address Address { get; set; }
    public ContactDetail ContactDetail { get; set; }
    public IEnumerable<Member> Dependants {get; set;}
}