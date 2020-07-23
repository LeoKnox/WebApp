using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RCandidate
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string roomName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string floor { get; set; }
        public int length { get; set; }
        public int width { get; set; }
    }
}
