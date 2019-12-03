using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class thoigian : MonoBehaviour
{
    public int Time;

    private void Start()
    {
        LoadData();
    }

    private void LoadData()
    {
        // Gán giá trị từ GameData
        Time = gamedata.tgdata.Time;
        
    }

    public void savedata(string nextscenes)
    {
        gamedata.tgdata.Save(this);
        Application.LoadLevel(nextscenes);

    }


}

