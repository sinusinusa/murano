using System.Text.Json;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace murano.Controllers
{
  public class SearchController : Controller
  {
    private EFDBContext _context;

    public SearchController( EFDBContext context)
    {
      _context = context;
    }

    [HttpPost]
    public IActionResult ProcessSearch([FromBody] dynamic requestData)
    {
      using (JsonDocument jsonDocument = JsonDocument.Parse(requestData.GetRawText()))
      {
        if (jsonDocument.RootElement.TryGetProperty("searchText", out JsonElement searchTextElement) &&
            searchTextElement.ValueKind == JsonValueKind.String)
        {
          string searchText = searchTextElement.GetString();

          // Обработать searchText и выполнить необходимую бизнес-логику


          return Json(new { result = "Success" });
        }
      }
    

    return Json(new { result = "Error", message = "Invalid request data" });
    }
  }
  

}
