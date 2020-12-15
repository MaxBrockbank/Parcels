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
  }
}