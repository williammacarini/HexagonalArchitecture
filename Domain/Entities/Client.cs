namespace Domain.Entities
{
    public class Client : Entity
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public int Age { get; protected set; }

        public Client(string name, string email, int age)
        {
            UpdateBasicInformation(name, email, age);
        }

        public void UpdateBasicInformation(string name, string email, int age)
        {
            if (!string.IsNullOrEmpty(name)
                && name.Length >= 2
                && !string.IsNullOrEmpty(email)
                && email.Contains("@")
                && email.Length >= 5
                && age > 0
                && age > Age)
            {
                Email = email;
                Age = age;
            }
            else
                throw new ArgumentException("Verify your informations!");
        }
    }
}
