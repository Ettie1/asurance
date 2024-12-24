using Microsoft.AspNetCore.Mvc;
using asurance.Models;

namespace asurance.Controllers;

public class AppController: Controller
{
    private AppDbContext _db;
    public AppController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult ListAllMembers()
    {
        return View(_db.Members);
    }
    public IActionResult AddMember()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddMember(Member member)
    {
        if(!ModelState.IsValid)
        {
            return View(member);
        }
///Pass around the main id on a session
//HttpContext.Items.Add(new KeyValuePair<string,string>().Create("",""));
        _db.Members.Add(member);
        _db.SaveChanges();
        var mid = member.MemberId;
        return RedirectToAction("MainMemberUpdateAndDetails", new{ id = member.MemberId });
    }

    public IActionResult AddDependant(int MemberId)
    {
        
        int memId = MemberId;
        ViewBag.MemberId =memId;
        //Member mem = _db.Members.Single(m => m.MemberId == memId);
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
        return RedirectToAction("MainMemberUpdateAndDetails",new {id = member.MemberId});
    }


    /*
    public IActionResult MainMemberUpdateAndDetails()
    {
        return View();
    }
    */

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