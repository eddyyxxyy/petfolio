using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets =
            [
                new ResponseShortPetJson
                {
                    Id = 0,
                    Name = "Charlie",
                    Type = Communication.Enums.EPetTypes.Dog
                }
            ]
        };
    }
}