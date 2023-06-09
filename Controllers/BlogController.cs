using dockerapi.Models;
using System.Linq;
namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public BlogController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            return _context.Blogs.Where(b => b.Title.Contains("Title")).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }

        [HttpGet("{title}")]
        public object GetByTitle(string title)
        {
            return _context.Blogs.Where(b => b.Title == title).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }

    }
}