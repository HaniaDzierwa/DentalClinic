using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
    }
}