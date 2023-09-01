using Microsoft.AspNetCore.Mvc;
using Models;

[ApiController]
[Route("[controller]")]
public class UsersController: ControllerBase {

    [HttpGet("GetUser", Name = "GetUser")]
    public void GetUser() {
        Console.WriteLine("Hello GET user controller!");
    }

    [HttpGet("GetUsers", Name = "GetUsers")]
    public void GetUsers() {
        Console.WriteLine("Hello GET users controller!");
    }

    [HttpPost("PostUser",Name = "PostUser")]
    public IActionResult Post([FromBody] User requestBody) {

        User user = new User();
        user.setId(requestBody.getId());

        return Ok();
    }


}