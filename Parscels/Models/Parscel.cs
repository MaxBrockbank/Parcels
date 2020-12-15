using System;
using System.Collections.Generic;

namespace Parscels.Models
{
  public class Parscel
  {
    private int Length {get; set;}
    private int Width {get; set;}
    private int Height {get; set;}
    private int Product {get; set;}
    private int Weight {get; set;}
    private int CostNumber {get; set;}
    private string CostText {get; set;}
    private string CantSend {get; set;}
    private static List<Parscel> _instances = new List<Parscel>{};

    public Parscel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Parscel> GetAll()
    {
      return _instances;
    }


    public int Volume()
    {
      Product = Length * Width * Height;
      return Product;
    }

    public string WhyCantShip()
    {
      if (Weight >= 70)
      {
        CantSend += "Your package is too heavy to ship with us. "
      }
      else if (Volume > 140)
      {
        CantSend += "Your package is too voluminous to ship with us. Voluminous, yes. "
      }      
    }

    public bool CanWeShip()
    {
      if (Weight >= 70 || Volume > 140)
      {
        return false;
      }
      else return true;
    }

    public string CostToShip()
    {
      CostNumber = 2 * Weight;
      return $"${CostNumber}";
    }

  }
}