using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Joegofett.Controllers
{
  public class BlogController : Controller
  {
    // GET: /Blog/

    public string Index()
    {
      return "This is a test";
    }

    // Get: Blog/Title/id

    public string Title(string title, int id)
    {
      return HtmlEncoder.Default.Encode($"Hello {title}, ID: {id}");
    }
  }
}
