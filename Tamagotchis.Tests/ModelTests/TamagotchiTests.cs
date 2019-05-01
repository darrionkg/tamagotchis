using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchis.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchis.Tests
{
  [TestClass]
  public class TamagotchiTest : IDisposable
  {

    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public void TamagotchiConstructor_CreateInstanceOfTamagotchi_Tamagotchi()
    {
      Tamagotchi newTamagotchi = new Tamagotchi();
      Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
    }

    [TestMethod]
    public void PassTime_LowersAllLevels_None()
    {
      Tamagotchi newTamagotchi = new Tamagotchi();
      for(int i = 0; i < 4; i++)
      {
        newTamagotchi.PassTime();
      }
      Assert.AreEqual(6, newTamagotchi.FoodLevel);
    }

    [TestMethod]
    public void AddPoints_AddsPointsWhenTaskPerformed_Int()
    {
      Tamagotchi newTamagotchi = new Tamagotchi();
      newTamagotchi.Pet();
      Assert.AreEqual(11, newTamagotchi.HappinessLevel);
    }
  }
}
