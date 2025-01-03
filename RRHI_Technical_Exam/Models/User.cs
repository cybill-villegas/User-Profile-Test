﻿using System.Text.Json.Serialization;

namespace RRHI_Technical_Exam.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public string BirthDate {  get; set; }
        public int Age { get; set; }
        public string? CreatedAt { get; set; } = DateTime.Now.ToString();
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string About { get; set; }
    }

    public class PaginatedUsers
    {
        public IEnumerable<User> Users { get; set; }
        public Pagination Pagination { get; set; }
    }
}
