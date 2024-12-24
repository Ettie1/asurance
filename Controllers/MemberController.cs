using asurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace asurance.Controllers;

public class MemberController: Controller
{
    private AppDbContext _db;


    private MainMemViewModel _mmvm;
    public MemberController(AppDbContext db)
    {
        _db = db;
        _mmvm = new MainMemViewModel();
    }
    public IActionResult AddMember()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddMember(MainMemViewModel mmvm)
    {
        if(!ModelState.IsValid)
        {
            return View(mmvm);
        }

        _db.Members.Add(mmvm.MainMember);
        _db.SaveChanges();
        mmvm.MainMemberId = mmvm.MainMember.MemberId;
        var mid = member.MemberId;
        return RedirectToAction("MainMemberUpdateAndDetails", new{ id = member.MemberId });
    }

    public IActionResult AddDependant(int MemberId)
    {
        
        int memId = MemberId;
        ViewBag.MemberId =memId;
        
        return View();
    }
    [HttpPost]
    public IActionResult AddDependant(Member member, int mid)
    {
        if(!ModelState.IsValid)
        {
            return View(member);
        }

        //member.SubId = MemberId;
        _db.Members.Add(member);
        _db.SaveChanges();
        return RedirectToAction("MainMemberUpdateAndDetails",new {m
        
        id = member.MemberId});
    }


    public IActionResult DeleteMember(int id)
    {
        return View(_db.Members.Single(m=>m.MemberId==id));
    }
    [HttpPost]
    public IActionResult DeleteMember(int id, string text = "default")
    {
        Member mem = _db.Members.Single(m => m.MemberId == id);
        _db.Members.Remove(mem);
        _db.SaveChanges();
        return RedirectToAction("MainMenu", "Menu");
    }
    
    public IActionResult MainMemberUpdateAndDetails(int? id)
    {
        Member mem = _db.Members.Single(m => m.MemberId == id);
        return View(mem);
    }

}