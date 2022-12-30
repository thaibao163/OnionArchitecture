﻿namespace Domain.ViewModel.Users
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}