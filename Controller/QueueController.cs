using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class QueueController : ControllerBase
{
    private readonly QueueContext _context;

    public QueueController(QueueContext context)
    {
        _context = context;
    }

    [HttpPost("issue")]
    public async Task<IActionResult> IssueQueue()
    {
        var queue = await _context.QueueTickets
            .FromSqlRaw("EXEC IssueNewQueue")
            .ToListAsync();

        return Ok(queue.FirstOrDefault());
    }

    [HttpPost("reset")]
    public async Task<IActionResult> ResetQueue()
    {
        var queue = await _context.QueueTickets
            .FromSqlRaw("EXEC ResetQueue")
            .ToListAsync();

        return Ok(queue.FirstOrDefault());
    }

    [HttpGet("current")]
    public async Task<IActionResult> GetCurrentQueue()
    {
        var queue = await _context.QueueTickets
            .FromSqlRaw("EXEC GetCurrentQueue")
            .ToListAsync();

        return Ok(queue.FirstOrDefault());
    }
}
