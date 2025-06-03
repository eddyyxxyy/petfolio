namespace Petfolio.Communication.Responses;

public class ResponseAllPetsJson
{
    public IList<ResponseShortPetJson> Pets { get; set; } = [];
}