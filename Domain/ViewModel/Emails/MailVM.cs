﻿using Microsoft.AspNetCore.Http;

namespace Domain.ViewModel.Emails
{
    public class MailVM
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}