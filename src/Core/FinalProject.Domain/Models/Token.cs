﻿

namespace FinalProject.Domain.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime TokenLifeTime { get; set; }
    }
}
