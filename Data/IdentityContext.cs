using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Dinesaur.Data;

namespace Dinesaur.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<DinesaurUser>(options)
    {
    }
}
