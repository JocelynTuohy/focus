using Microsoft.EntityFrameworkCore;

namespace focus.Models
{
  public class FocusContext : DbContext
  {
    public FocusContext(DbContextOptions<FocusContext> options) : base(options) { }
    // ADD DBSETS HERE (USER SNIPPET dbsetexample)
  }
}