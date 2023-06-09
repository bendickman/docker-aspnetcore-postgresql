using dockerapi.Models;
namespace dockerapi.Controllers
{
    [Route("/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public BlogController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            var blogPosts = _context.Blogs.Where(b => b.Title.Contains("Title"));

            return Ok(blogPosts);
        }

        [HttpGet("{title}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetByTitle(string title)
        {
            var blogPosts = _context.Blogs.Where(b => b.Title == title);

            if (!blogPosts?.Any() ?? true)
            {
                return NotFound(title);
            }

            return Ok(blogPosts);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var blogPost = _context.Blogs.FirstOrDefault(b => b.Id == id);

            if (blogPost is null)
            {
                return NotFound(id);
            }

            return Ok(blogPost);
        }
    }
}