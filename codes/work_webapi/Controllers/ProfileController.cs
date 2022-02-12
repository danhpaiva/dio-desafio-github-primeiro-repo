using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
  public static string URLBase = "https://raw.githubusercontent.com/danhpaiva/desafios-dio-csharp/main/images/desafio00";
  private readonly ILogger<ProfileController> _logger;
  private readonly IConfiguration Configuration;

  public ProfileController(ILogger<ProfileController> logger, IConfiguration configuration)
  {
    _logger = logger;
    Configuration = configuration;
  }

  [HttpGet]
  public IActionResult Get(bool image)
  {
    var random = new Random();
    var url = URLBase + random.Next(1, 5) + ".png";

    if (image)
    {
      using (var webClient = new WebClient())
      {
        byte[] imageBytes = webClient.DownloadData(url);
        return File(imageBytes, "image/png");
      }
    }
    else
    {
      return Ok(url);
    }
  }
}

