using Auth0.Models.DTO;
using Auth0.Models.DTO.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Auth0.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public AuthController() { }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> RegisteredUser(UserRegistrationRequest UserRegistration )
        {
           
            UserDTO Response = new UserDTO();

            try
            {

              

            }
            catch(Exception ex )
            {
                ProblemDetails problemDetails = new ProblemDetails() { 
                    Detail= ex.Message,
                };
                return BadRequest(problemDetails);
            }

            return Response;
            
        }


    }
}
