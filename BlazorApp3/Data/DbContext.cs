namespace BlazorApp3.Data
{
    using Microsoft.EntityFrameworkCore;

    public class GameContext : DbContext
    {
        public DbSet<PlayerScore> PlayerScores { get; set; } = null!;

        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }
    }

}
