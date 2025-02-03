using Microsoft.AspNetCore.Mvc;
using asurance.Models;
using asurance.ViewModels;

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

    public IActionResult ListAddresses()
    {
        return View(_db.Addresses);
    }

    public IActionResult ListContactDetails()
    {
        return View(_db.ContactDetails);
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
        _db.Members.Add(member);
        _db.SaveChanges();
        var mid = member.MemberId;
        return RedirectToAction("MainMemberUpdateAndDetails", new{ id = mid });
    }

    public IActionResult MainMemberUpdateAndDetails(int? id)
    {
        Member mem = _db.Members.Single(m => m.MemberId == id);
        return View(mem);
    }


    public IActionResult AddAddress(int MMId)
    {
        ViewBag.MainMemberId = MMId;

        MainMemViewModel mmvm = new MainMemViewModel();
        mmvm.MainMemberId = MMId;

        return View(mmvm);
    }
    [HttpPost]
    public IActionResult AddAddress(MainMemViewModel mmvm)
    {
        _db.Addresses.Add(mmvm.Address);
        _db.SaveChanges();
        return RedirectToAction("MainMemberUpdateAndDetails",new {id = mmvm.MainMemberId});
    }

    public IActionResult AddContact(int MMId)
    {
        ViewBag.MainMemberId = MMId;
        MainMemViewModel mmvm = new MainMemViewModel();
        mmvm.MainMemberId = MMId;

        return View(mmvm);
    }
    [HttpPost]
    public IActionResult AddContact(MainMemViewModel mmvm)
    {
        _db.ContactDetails.Add(mmvm.ContactDetail);
        _db.SaveChanges();
        return RedirectToAction("MainMemberUpdateAndDetails",new {id = mmvm.MainMemberId});
    }


    public IActionResult AddDependant(int MemberId)
    {
        
        int memId = MemberId;
        ViewBag.MemberId =memId;
        //Member mem = _db.Members.Single(m => m.MemberId == memId);
        MainMemViewModel mmvm = new MainMemViewModel();
        mmvm.MainMemberId = MemberId;
        return View(mmvm);
    }
    [HttpPost]
    public IActionResult AddDependant(MainMemViewModel member)
    {
        /*
        if(!ModelState.IsValid)
        {
            return View(member.MainMember);
        }
        */
        try
        {
        //member.MainMember.SubId = member.MainMember.MemberId;

        _db.Members.Add(member.MainMember);
        _db.SaveChanges();
        return RedirectToAction("MainMemberUpdateAndDetails",new {id = member.MainMemberId});
        }
        catch(Exception)
        {
            throw;
        }
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
}