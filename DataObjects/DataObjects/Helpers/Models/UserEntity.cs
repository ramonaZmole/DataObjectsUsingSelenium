namespace DataObjects.Helpers.Models
{
    public class UserEntity
    {
        public string Email { get; set; } = Faker.Internet.Email();
        public string Password { get; set; } = Faker.Internet.UserName();
    }
}
