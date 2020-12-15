using System;
using System.Collections.Generic;

namespace Shipping 
{
  public class Parscel
  {
    private int Length {get; set;}
    private int Width {get; set;}
    private int Height {get; set;}
    private int Product {get; set;}
    private int Weight {get; set;}

    public Parscel(int length, int width, int height)
    {
      Length = length;
      Width = width;
      Height = height;
    }
    
    public Parscel(int length, int width, int height, int weight)
    : this(length, width, height)
    {
      Weight = weight;
    }
    
    public int Volume()
    {
      Product = Length * Width * Height;
      return Product;
    }
  }
}