using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class restime : MonoBehaviour
{
    
   
    public double Restime;
    // Start is called before the first frame update
    void Start()
    {
        loaddata();
    }

    private void loaddata()
    {
        Restime = gamedata.rtdata.Restime;
    }
}
