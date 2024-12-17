namespace computerShop;

public class computer
{
  public string _brand { get; set; }  
  public int _ram { get; set; }
  public double _Price { get; set; }

  public computer(string brand, int ram, double price)
  {
    _brand=brand;
    _ram=ram;
    _Price=price;
  }
}