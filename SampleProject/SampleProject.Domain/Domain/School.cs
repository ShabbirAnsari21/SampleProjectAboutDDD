using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Domain.Domain
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string City { get; set; }
    }
}
