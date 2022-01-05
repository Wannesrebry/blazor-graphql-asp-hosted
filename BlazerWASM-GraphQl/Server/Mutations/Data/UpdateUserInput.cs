using shared.models;

namespace demo_graphql.Mutations.Data
{
    public class UpdateUserInput : CreateUserInput
    {
        public int Id { get; set; }
    }

    public static class UpdateUserInputExtensions
    {
        public static ApplicationUser ToApplicationUser(this UpdateUserInput input)
        {
            return new ApplicationUser
            {
                Id = input.Id,
                Email = input.Email,
                Name = input.Name,
            };
        }
    }
}
