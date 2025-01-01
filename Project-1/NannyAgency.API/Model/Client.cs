namespace NANNYAGENCY.API.Model;

public class Client{
   public int Id{get; set;}
    public required string Name {get; set;}
   public required string Address {get; set;}

   public required string PhoneNumber{get; set;}
   public required string email{get; set;}
    
   public List<Nannies> nannies {get; set;}=[]; 

}