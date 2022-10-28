using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ServerTask.Entities
{
    public class Info
    {
        [Key]
        public string? slackUsername {get; set;}
        public bool backend { get; set; }
        public int age { get; set; }
        public string? bio { get; set; }
    }
}