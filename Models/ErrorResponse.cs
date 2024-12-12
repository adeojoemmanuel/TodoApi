namespace TodoAPI.Models
{
    public class ErrorResponse
    {
        public string Title { get; set; } = string.Empty;
        public int StatusCode { get; set; } = 0;
        public string Message { get; set; } = string.Empty;
    }
}

