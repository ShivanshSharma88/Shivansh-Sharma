using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPINew.Data;
using WebAPINew.Models;

namespace WebAPINew.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly StudentDbContext dbContext;

        public StudentsController(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            return Ok(await dbContext.Students.ToListAsync());
        }
        [HttpPost]  
        public async Task<IActionResult> AddStudent(AddStudentsRequest addstudentRequest)
        {
            var studentinfo = new Studentinfo() { 
                Id= Guid.NewGuid(),
                stdName=addstudentRequest.stdName,
                stdGender = addstudentRequest.stdGender,
                stdAge =addstudentRequest.stdAge,
                stdClass=addstudentRequest.stdClass,
               
                
            };
            await dbContext.Students.AddAsync(studentinfo);
            await dbContext.SaveChangesAsync();
            
            return Ok(studentinfo);
        }
    }
}
