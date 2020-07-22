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

    [TestMethod]
    public void JobOpeningConstructor_GetValues_StringAndInt()
    {
    string title = "Salt Miner";
    string description = "mine salt";
    string name = "Sterling Holmes";
    int number = 1234567845;

    JobOpening newJobOpening = new JobOpening(title, description, name, number);
    string resultTitle = newJobOpening.Title;
    string resultDescription = newJobOpening.Description;
    // string resultName = newJobOpening.contactInfo<0,>;
    int resultNumber = JobOpening.contactInfo;

    Assert.AreEqual(title, resultTitle);
    Assert.AreEqual(description, resultDescription);
    // Assert.AreEqual(value, resultName);
    Assert.AreEqual({ "Sterling Holmes", 1234567845 }, resultNumber);
    }

  }
}