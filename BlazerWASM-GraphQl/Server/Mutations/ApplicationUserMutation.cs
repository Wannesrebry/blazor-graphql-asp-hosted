using demo_graphql.Mutations.Data;
using shared.models;

namespace demo_graphql.Mutations
{
    public class ApplicationUserMutation
    {

        public async Task<ApplicationUser?> UpdateUser(UpdateUserInput userInput, [Service] DartDbContext context)
        {
            try
            {
                ApplicationUser toUpdate = context.ApplicationUsers.First(e => e.Id == userInput.Id);
                toUpdate.Email = userInput.Email;
                toUpdate.Name = userInput.Name;
                await context.SaveChangesAsync();
                return toUpdate;
            }catch(Exception ex)
            {
                return null;
            }
        } 

        public async Task<ApplicationUser?> AddUser(CreateUserInput userInput, [Service] DartDbContext context)
        {
            try
            {
                ApplicationUser toCreate = userInput.ToApplicationUser();
                context.ApplicationUsers.Add(toCreate);
                await context.SaveChangesAsync();
                return toCreate;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<StatusResult> DeleteUser(IdInput idInput, [Service] DartDbContext context)
        {
            try
            {
                ApplicationUser user = context.ApplicationUsers.First(e => e.Id == idInput.Id);
                string userName = user.Name;
                context.ApplicationUsers.Remove(user);
                await context.SaveChangesAsync();
                return new StatusResult($"User ID {idInput.Id} with name: '{userName}' has been deleted succesfully.");
            }
            catch (Exception ex)
            {
                // ignore
                return new StatusResult($"Unable to delete user with ID {idInput.Id}");
            }
        }
    }
}
 