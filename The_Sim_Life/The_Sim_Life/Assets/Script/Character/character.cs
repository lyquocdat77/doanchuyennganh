using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class character : MonoBehaviour
{
    public int food;
    public int health;
    public int emotion;
    public int appearance;
    public int iq;
    public int money;


    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    private void LoadData()
    {
        // Gán giá trị từ GameData
        food = gamedata.chadata.food;
        health = gamedata.chadata.health;
        emotion = gamedata.chadata.emotion;
        appearance = gamedata.chadata.appearance;
        iq = gamedata.chadata.iq;
        money = gamedata.chadata.money;

    }
}
