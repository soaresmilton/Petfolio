using Petfolio.Communication.Requests;

namespace Petfolio.Application.UseCases.Pet.Update;
public class UpdatePetUseCase
{
    public void Execute(int id, RequestPetJson request)
    {
       // Logica do Update
       // No caso vai fazer um lookup na tabela de pets, pegando o registro quando o ID for igual ao id
       // Faz a atualização das informacoes com base nos dados passados no request.
       // os dados do request vem num formulário
    }
}
