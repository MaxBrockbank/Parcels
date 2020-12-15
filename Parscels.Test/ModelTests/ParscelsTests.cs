using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shipping;

namespace Shipping.Tests
{
  [TestClass]
  public class ParscelTests
  {
    [TestMethod]
    public void ParscelConstructor_MakeNewParscel_Parscel()
    {
      Parscel newParscel = new Parscel(3,3,3,11);
      Assert.AreEqual(typeof(Parscel), newParscel.GetType());
    }

    [TestMethod]
    public void
    VolumeCalculatedFromThreeLengths_ReturnsProductOfThreeInts_Volume()
    {
      Parscel newParscel = new Parscel(2,3,4);
      Assert.AreEqual((24), newParscel.Volume());
    }
  }
}