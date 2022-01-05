using shared.models;

namespace demo_graphql.Queries
{
    public class ApplicationUserQuery
    {
        public List<ApplicationUser> GetApplicationUsers([Service] DartDbContext context)
        {
            return context.ApplicationUsers
                .ToList();
        }

        public ApplicationUser GetApplicationUser(int id, [Service] DartDbContext context)
        {
            return context.ApplicationUsers.First(a => a.Id == id);
        }
    }
}
