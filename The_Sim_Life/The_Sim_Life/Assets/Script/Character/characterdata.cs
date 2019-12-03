using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterdata 
{
    public int food;
    public int health;
    public int emotion;
    public int appearance;
    public int iq;
    public int money;
    private string CHARACTER_DATA = "character_data";

    public characterdata()
    {
        food = 0;
        health = 0;
        emotion = 0;
        appearance = 0;
        iq = 0;
        money = 0;
    }

    public void savecharacterindex(character ch)
    {
        food = ch.food;
        health = ch.health;
        emotion = ch.emotion;
        appearance = ch.appearance;
        iq = ch.iq;
        money = ch.money;

        string s = JsonUtility.ToJson(this);
        Debug.Log(s);
        PlayerPrefs.SetString(CHARACTER_DATA,s);
    }






}
