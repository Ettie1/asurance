using asurance.Models;
using Microsoft.AspNetCore.Mvc;
using asurance.ViewModels;

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
        var mid = mmvm.MainMember.MemberId;
        return RedirectToAction("MainMemberUpdateAndDetails", new{ MemberId = mmvm.MainMember.MemberId });
    }

    public IActionResult AddDependant(int MemberId)
    {
        
        int memId = MemberId;
        ViewBag.MemberId =memId;
        
        return View();
    }
    [HttpPost]
    public IActionResult AddDependant(MainMemViewModel mmvm, int mid)
    {
        if(!ModelState.IsValid)
        {
            return View(mmvm);
        }

        //member.SubId = MemberId;
        mmvm.MainMember.SubId = mmvm.MainMemberId;
        _db.Members.Add(mmvm.MainMember);
        _db.SaveChanges();
        return RedirectToAction("MainMemberUpdateAndDetails",new {mid = mmvm.MainMember.MemberId});
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