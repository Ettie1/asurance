using Microsoft.AspNetCore.Mvc;

public class MenuController: Controller
{
    public IActionResult MainMenu()
    {
        ViewBag.Title = "Main - Menu";
        return View();
    }
}