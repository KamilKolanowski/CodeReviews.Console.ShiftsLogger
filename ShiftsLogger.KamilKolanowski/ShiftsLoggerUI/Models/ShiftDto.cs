using System.ComponentModel.DataAnnotations;

namespace ShiftsLogger.KamilKolanowski.Models;

public class ShiftDto
{
    public int ShiftId { get; set; }
    public string ShiftType { get; set; }
    public int WorkerId { get; set; }
    public string WorkedHours { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
