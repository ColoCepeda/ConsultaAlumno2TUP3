using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        //Implementar los metodos en el service desde el repository
        //Implementar los metodos en el controller desde el service
        //Como usuario quiero poder acceder a todas las materias

    }
}
