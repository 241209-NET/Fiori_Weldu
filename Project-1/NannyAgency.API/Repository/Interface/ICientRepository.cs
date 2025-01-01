using NANNYAGENCY.API.Model;

namespace NANNYAGENCY.API.Repository;

public interface IClientRepository{
    IEnumerable<Client> GetAllClients(); 
    

}