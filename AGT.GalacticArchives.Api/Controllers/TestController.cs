using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("api/test")]
public class TestController: ControllerBase
{
    private readonly FirestoreDb _db;
    private readonly ILogger<TestController> _logger;

    public TestController(FirestoreDb db, ILogger<TestController> logger)
    {
        _db = db;
        _logger = logger;
    }

    [HttpGet("firebase-connection")]
    public async Task<IActionResult> GetAsync()
    {
        try
        {
            var testDoc = _db.Collection("_test").Document("connection");
            await testDoc.SetAsync(new Dictionary<string, object>
            {
                { "timestamp", FieldValue.ServerTimestamp },
                { "message", "Test Successful" },
            });

            var snapshot = await testDoc.GetSnapshotAsync();

            return Ok(new
            {
                success = true,
                message = "Firebase connected",
                projectId = _db.ProjectId,
                date = snapshot.ToDictionary(),
            });
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Firebase connection test failed");
            return StatusCode(500, new
            {
                success = false,
                error = e.Message,
            });
        }
    }
}