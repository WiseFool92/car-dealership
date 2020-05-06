namespace Dealership.Models
{
  public class Car
  {

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _note;

    private string _gadget;


    public Car(string makeModel, int price, int miles, string note, string gadget)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _note = note;
      _gadget = gadget;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetNote()
    {
      return _note;
    }

    public string GetGadget()
    {
      return _gadget;
    }
    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price <= maxPrice && _miles <= maxMiles);
    }
  }
}