using Microsoft.EntityFrameworkCore;
using NANNYAGENCY.API.Data;
using NANNYAGENCY.API.Model;

namespace NANNYAGENCY.API.Repository;

public class ClientRepository: IClientRepository{
   
    private readonly NannyContext _nannyContext;

    public ClientRepository(NannyContext nannyContext)=> _nannyContext=nannyContext;

      public IEnumerable<Client> GetAllClients()
    {
        return _nannyContext.Clients
            .Include(c =>c.nannies)
            .ToList();
    }
    

    
}