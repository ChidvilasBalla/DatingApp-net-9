using System;

namespace API.Entities;

public class AppUser
{
    //Entity frameworks works only with public access modifier
    public int Id { get; set; }

    //required ensures UserName is mandatory and also deal with Nullable warning.
    public required string UserName { get; set; }

}
