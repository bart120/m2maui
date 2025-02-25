using System.ComponentModel.DataAnnotations;

public class MessageModel
{
    [Key]
    public int Id { get; set; }

    public string Content { get; set; }

    public DateTime Timestamp { get; set; }
}