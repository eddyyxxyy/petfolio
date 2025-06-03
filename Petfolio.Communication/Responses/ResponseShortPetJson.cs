using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public EPetTypes Type { get; set; }
}