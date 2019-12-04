using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
   public thoigian tg;
  public void toMap(string map)
    {
        Application.LoadLevel(map);
    }
    public void toInventory(string inventory)
    {
        Application.LoadLevel(inventory);
    }
    public void toActivity(string Activity)
    {
        Application.LoadLevel(Activity);
    }
    public void toLog(string log)
    {
        Application.LoadLevel(log);
    }
    public void toLoading(string Loading)
    {
        Application.LoadLevel(Loading);
    }
    public void savedata(string nextscenes)
    {
        gamedata.tgdata.Save(tg);
    
        Application.LoadLevel(nextscenes);

    }

}
