using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reclone_Users_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        HttpClient _httpClient;
        public AuthController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("AuthMicroservice");
        }

        [HttpGet("getAuthServiceResponse")]
        public async Task<string> GetAuth()
        {
            var response = await _httpClient.GetAsync("/api/user/sendAuthServiceResponse");
            return await response.Content.ReadAsStringAsync();
        }


        //THIS FUNCTION CAN ALSO BE IN A DIFFERENT CONTROLLER THIS IS ONLY FOR TEST   
        [HttpGet("sendUserServiceResponse")]

        public string SendResponse()
        {
            return "Hello from User Service";
        }

    }
}