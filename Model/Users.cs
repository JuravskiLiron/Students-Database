﻿namespace CRUD_Students.Model
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        


       
    }
}
