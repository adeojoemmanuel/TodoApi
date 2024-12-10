using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class DbSettings
    {
        public required string ConnectionString { get; set; }
    }
}