namespace PorfolioWeb.Dto
{
    public class ErrorDto
    {
        public string? RequestId { get; set; }
        public string? ErrorMessage { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
