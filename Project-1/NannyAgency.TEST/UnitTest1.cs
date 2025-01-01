using Moq;
using NANNYAGENCY.API.Model;
using NANNYAGENCY.API.Repository;
using NANNYAGENCY.API.Service;



namespace NannyAgency.TEST;

public class UnitTest1
{

    [Fact]
    public void GetAllClientsTest()
    {
        //Arrange
        Mock<IClientRepository> mockRepo=new();
        ClientService clientService = new(mockRepo.Object);

        List<Client> clientList = [

            new Client{Id = 1, Name = "keyli", Address="texas", PhoneNumber="67777", email=" girma@gmail"},
        
          new Client{Id = 2, Name = "bla", Address="virginia", PhoneNumber="343777", email=" kurma@gmail"}
        ];

        mockRepo.Setup(repo => repo.GetAllClients()).Returns(clientList);
        
        //Act
        var result = clientService.GetAllClients().ToList();
        
        //Assert
        Assert.Equal(clientList, result);
    }
}