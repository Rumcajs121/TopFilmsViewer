using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ApplicationLayer;
using DomainLayer;
namespace TopFilmsViewer;

[Route("api/[controller]")]
[ApiController]
public class MovieController:ControllerBase
{
    private readonly ITopFilmsViewer _serviceFilms;

    public MovieController(ITopFilmsViewer serviceFilms)
    {
        _serviceFilms = serviceFilms;
    }

    //Kontrolery
}
