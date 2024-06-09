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

    // [HttpPost]
    // public async Task<ActionResult<Movie>> CreateStudio(AddStudioDto studioDto){
    //     var addedMovie=_serviceFilms.CreateStudio(studioDto);//zmienic interfejs by przyjmował parametry dto a nie osobych zmiennych
    //     return Ok(addedMovie);
    // }
}
