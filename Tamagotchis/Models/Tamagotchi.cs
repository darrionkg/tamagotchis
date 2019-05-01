using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    public int FoodLevel {get; set;}
    public int HappinessLevel {get; set;}
    public int SleepLevel {get; set;}
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};
    public int Id {get; set;}

    public Tamagotchi()
    {
      FoodLevel = 10;
      HappinessLevel = 10;
      SleepLevel = 10;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


    public void PassTime()
    {
      FoodLevel--;
      HappinessLevel--;
      SleepLevel--;
    }

    public void Feed()
    {
      FoodLevel++;
    }

    public void Pet()
    {
      HappinessLevel++;
    }

    public void TakeNap()
    {
      SleepLevel++;
    }
  }
}

    // Pass time
    // feed, pet, take nap. Adds 1 to a level
