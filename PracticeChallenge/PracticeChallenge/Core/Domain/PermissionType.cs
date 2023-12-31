namespace PracticeChallenge.Core.Domain;

public class PermissionType
{
    public int Id { get; protected set; }
    public string Description { get; protected set; }

    public PermissionType(int id, string? description)
    {
        Id = id;
        Description = description ?? string.Empty;
    }
}