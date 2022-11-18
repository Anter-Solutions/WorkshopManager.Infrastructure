using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Infrastructure.DTOs.Auth
{
    public record LoginDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password{ get; set; }
        public bool DoNotSignOut { get; set; }
    }
}