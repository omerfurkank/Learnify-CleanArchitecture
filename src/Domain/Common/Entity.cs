namespace Domain.Common;

public class Entity
{
    public required int Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTimeOffset? LastModifiedAt { get; set; }
    public int? LastModifiedBy { get; set; }
}
