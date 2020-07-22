using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.TestTools
{
  [TestClass]
  public class JobOpeningTest : IDisposable
  {
    public void Dispose()
    {
      JobOpening.ClearAll();
    }
    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfJobOpening_JobOpening()
    {
      JobOpening newJobOpening = new JobOpening("Salt Miner", "mine salt", "Sterling Holmes", 1234567845);
      Assert.AreEqual(typeof(JobOpening), newJobOpening.GetType());
    }
  }
}