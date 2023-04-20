using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reclone_Users_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly HttpClient _httpClient;



        public PostController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("PostMicroservice");
        }

        //establihs get connect with the post microservice

        [HttpGet("getPostServiceResponse")]
        public async Task<string> Get()
        {
            var response = await _httpClient.GetAsync("/api/user/sendPostServiceResponse");
            return await response.Content.ReadAsStringAsync();
        }


        //return response to post microservice
        [HttpGet("sendUserServiceResponse")]
        public string GetResponse()
        {
            return "Hello from User Microservice!";
        }

    }



}