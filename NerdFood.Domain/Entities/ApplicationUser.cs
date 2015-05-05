namespace NerdFood.Domain.Entities
{
    public class    ApplicationUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string FullName()
        {
            return Name + " " + LastName;
        }
    }
}
