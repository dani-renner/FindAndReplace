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
      Finder newFinder = new Finder("have","Some","arguments");
      Assert.AreEqual(typeof(Finder),newFinder.GetType());
    }
    [TestMethod]
    public void FinderReplacer_FindsStringandReplaces_Finder()
    {
      Finder testFinder = new Finder("The dog is lying in the sun.", "Dog", "cat");
      Assert.AreEqual(testFinder.FindandReplace(),"The cat is lying in the sun.");
    }
  }
}