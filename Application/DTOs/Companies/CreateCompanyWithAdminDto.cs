﻿namespace Application.DTOs.Companies
{
    public class CreateCompanyWithAdminDto
    {
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
