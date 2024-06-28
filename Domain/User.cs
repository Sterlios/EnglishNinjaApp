namespace Domain
{
    internal class User
    {
        public User(int id, string? name, string? surname, string? phone, DateTime birthDay)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            BirthDay = birthDay;
        }

        public int Id { get; }
        public string? Name { get; }
        public string? Surname { get; }
        public string? Phone { get; }
        public DateTime BirthDay { get; }
    }
}
