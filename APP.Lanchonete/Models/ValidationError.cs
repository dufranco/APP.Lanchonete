using System.Text.Json.Serialization;

namespace APP.Lanchonete.Models
{
    public class ValidationError
    {
        [JsonPropertyName("propertyName")]
        public string? PropertyName { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("attemptedValue")]
        public object? AttemptedValue { get; set; }

        [JsonPropertyName("customState")]
        public object? CustomState { get; set; }

        [JsonPropertyName("severity")]
        public int? Severity { get; set; }

        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        [JsonPropertyName("formattedMessagePlaceholderValues")]
        public object? FormattedMessagePlaceholderValues { get; set; }
    }
}
