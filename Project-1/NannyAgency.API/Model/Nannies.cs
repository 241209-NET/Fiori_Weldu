namespace NANNYAGENCY.API.Model;

public class Nannies{
   public int Id{get; set;}
    public required string Name {get; set;}
    public int ExprienceYear{get; set;}

   public required string PhoneNumber{get; set;}
   public required string email{get; set;}
    
   public List<Client> nannies {get; set;}= [] ; 

}