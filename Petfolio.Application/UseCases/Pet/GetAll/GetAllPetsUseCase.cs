using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson()
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Bartolomeu",
                    Type = PetType.Cat
                },
                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Rebeca",
                    Type = PetType.Cat
                },
                new ResponseShortPetJson
                {
                    Id = 3,
                    Name = "July",
                    Type = PetType.Dog
                }
            }
        };
    }
}
