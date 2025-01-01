using Microsoft.AspNetCore.Mvc;
using NANNYAGENCY.API.Model;
using NANNYAGENCY.API.Service;

namespace NANNYAGENCY.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase

{

private readonly IClientService _clientService;
public ClientController(IClientService clientService)=> _clientService=clientService;

[HttpGet]
public IActionResult GetAllClients(){
    var clientList = _clientService.GetAllClients();    
        return Ok(clientList);
}


}
