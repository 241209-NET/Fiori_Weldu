using NANNYAGENCY.API.Model;

namespace NANNYAGENCY.API.Service;

public interface IClientService{
    IEnumerable<Client> GetAllClients();
    
}