using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Model.RequestModel
{
    public class AddSchoolRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
