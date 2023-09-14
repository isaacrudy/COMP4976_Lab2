using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZodiacLab.models;

namespace ZodiacLab.Pages;

public class IndexModel : PageModel
{
    public int Year { get; set; }
    public string Zodiac { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        ViewData["Zodiac"] = "";
        ViewData["ZodiacUrl"] = "";
    }

    public void OnPost(int year)
    {
        if (Request.Form["Clear"].Count > 0)
        {
            ViewData["Zodiac"] = "";
            ViewData["ZodiacUrl"] = "";
        } else  if (year >= 1900) {
            ViewData["Zodiac"] = utils.GetZodiac(year);
            ViewData["ZodiacUrl"] = utils.GetZodiac(year) + ".png";
        }

    }

}
