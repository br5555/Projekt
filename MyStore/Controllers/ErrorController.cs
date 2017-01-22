using Microsoft.AspNetCore.Mvc;

namespace MyStore.Controllers
{

    public class ErrorController : Controller
    {

        public ViewResult Error() => View();
    }
}