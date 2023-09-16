using Microsoft.AspNetCore.Builder; // For the web app results
using Microsoft.EntityFrameworkCore; // For AppDbContext
using UserAPI.Models; // For User


namespace UserAPI.Routing
{
    public static class UserRoutes
    {
        public static void RegisterUsers(WebApplication app)
        {
            app.MapPost("/api/createusers", async (AppDbContext db, User user) =>
            {
                Console.WriteLine("Received a new request to create a user.");
                Console.WriteLine($"Data received: Name - {user.Name}, Email - {user.Email}, Password - {user.Password}");

                db.Users.Add(user);
                await db.SaveChangesAsync();
                return Results.Created($"/api/users/{user.Id}", user);
            });
        }
    }
}
