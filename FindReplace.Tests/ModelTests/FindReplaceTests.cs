using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindReplace.Models;
using System;

namespace FindReplace.TestTools
{
  [TestClass]
  public class FindReplaceTests
  {
    [TestMethod]
    public void FinderConstructor_CreatesInstanceofFinder_Finder()
    {
      Finder newFinder = new Finder();
      Assert.AreEqual(typeof(Finder),newFinder.GetType());
    }
  }
}