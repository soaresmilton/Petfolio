using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Get;
public class GetPetByIdUseCase
{
    public ResponseShortPetJson Execute(int id)
    {
        return new ResponseShortPetJson()
        {
            Id = id,
            Name = "Bartolomeu",
            Type = PetType.Cat
        };
    }
}
