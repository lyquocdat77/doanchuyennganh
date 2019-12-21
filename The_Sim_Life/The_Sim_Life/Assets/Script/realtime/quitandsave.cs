using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class quitandsave : MonoBehaviour
{
    DateTime t = DateTime.Now;
    double restime;
    
    public void qns()
    {

        restime = (t.ToUniversalTime() - new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        gamedata.rtdata.Save(restime);
        Debug.Log(restime);
        Application.Quit();
    }
   
}
