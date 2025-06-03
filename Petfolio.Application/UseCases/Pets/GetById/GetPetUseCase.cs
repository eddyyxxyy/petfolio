using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        var pet = new ResponsePetJson
        {
            Id = id,
            Name = "Charlie",
            Type = Communication.Enums.EPetTypes.Dog,
            Birthday = new DateTime(
                year: 2020,
                month: 01,
                day: 01
            ),
        };

        return pet;
    }
}