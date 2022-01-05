using shared.models;

namespace demo_graphql.Mutations.Data
{
    public class CreateUserInput
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public static class CreateUserInputExtensions
    {
        public static ApplicationUser ToApplicationUser(this CreateUserInput input)
        {
            return new ApplicationUser
            {
                Name = input.Name,
                Email = input.Email,
            };
        }
    }

}
