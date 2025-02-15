using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController] //this attribute indicates that this is a controller class.
[Route("api/[controller]")] // api/users
public class UsersController(DataContext context) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //ActionResult return type allows us to return HTTP requests.
    {
        var users = await context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id:int}")]  // /api/users/3
    public async Task<ActionResult<AppUser>> GetUser(int id) //ActionResult return type allows us to return HTTP requests.
    {
        var user = await context.Users.FindAsync(id);

        if(user == null) return NotFound(); //this solves the problem where the menthod returns a null user.
        return user;
    }
}
