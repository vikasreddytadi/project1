using DotnetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    DataContextDapper _dapper;
    public  UserController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }

    [HttpGet("getCategoryNames")]
    
    public IEnumerable<CategoryNames> GetCategoryNames()
    {
        string sql = @"EXEC GetCategoryNames";
        IEnumerable<CategoryNames> categoryNames = _dapper.LoadData<CategoryNames>(sql);
        return categoryNames;
    }

    [HttpGet("getTaskDetails/CategoryName")]
    
    public IEnumerable<TaskDetails> GetTaskDetails(string CategoryName)
    {
        Console.WriteLine(CategoryName);
        string sql = @"EXEC GetTaskDetails @CategoryName = '" + CategoryName +"'" ;
        IEnumerable<TaskDetails> taskDetails = _dapper.LoadData<TaskDetails>(sql);
        return taskDetails;
    }

    // [HttpGet("TestConnection")]
    // public (int,string) TestConnection()
    // {
    //     return _dapper.LoadDataSingle<(int,string)>("SELECT * from BallType");
    // }

    // [HttpGet("test/{parameter}")]
    
    // public string[] Test(string parameter)
    // {
    //     string[] example = new string[] {
    //         "vikas",
    //         "reddy",
    //         parameter
            
    //     };
    //     return example;
    // }
   
    // [HttpGet("getPlayers")]
    
    // public IEnumerable<Player> GetPlayers()
    // {
    
    // }

    // [HttpGet("getPlayer/{PlayerId}")]
    
    // public Player GetPlayer(int PlayerId)
    // {
    
    // }
}
