using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;

public class RequestRegisterPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public EPetTypes Type { get; set; }
}
