using NANNYAGENCY.API.Model;
using NANNYAGENCY.API.Repository;

namespace NANNYAGENCY.API.Service;

public class ClientService: IClientService {

 private readonly IClientRepository _clientRepository;
 public ClientService(IClientRepository clientRepository)=>_clientRepository=clientRepository;

 public IEnumerable<Client> GetAllClients()
    {
        // var petList = _clientRepository.GetAllClients;
        // List<Client> petDTOList = [];

        return _clientRepository.GetAllClients();


    }


}