using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab01.Models;

namespace Lab01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public string Search(string q, int counter)
    {
        return $"q={q}, counter{counter}";
    }

    [HttpPost]
    public string Create(string name, int age)
    {
        return $"name={name}, age={age}";
    }

    [HttpGet]
    
    public Book FindBook(int id)
    {
       // Random random = new 
       return new Book()
       {
           Id = id,
           Title = "C#",
           Pages = 234,
       };
    }
    [HttpPost]
    public Book CreateBook([FromBody] Book book)
    {
        Random random = new Random();
        return new Book()
        {
            Id = random.Next(maxValue:100),
            Title = book.Title,
            Pages = book.Pages
        };
        
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }
}