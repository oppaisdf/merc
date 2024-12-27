namespace api.Models.Responses;

public class AttendanceResponse
{
    public required string User { get; set; }
    public required string Person { get; set; }
    public required DateTime Date { get; set; }
}