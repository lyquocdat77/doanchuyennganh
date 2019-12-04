using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Character_index : MonoBehaviour
{

    public Text food = null;
    public Text health = null;
    public Text emotion = null;
    public Text appearance = null;
    public Text iq = null;
    public Text money = null;

    private void Awake()
    {
        food = GameObject.Find("Food").GetComponent<Text>();
        health = GameObject.Find("Health").GetComponent<Text>();
        emotion = GameObject.Find("Emotion").GetComponent<Text>();
        appearance = GameObject.Find("Appearence").GetComponent<Text>();
        iq = GameObject.Find("IQ").GetComponent<Text>();
        money = GameObject.Find("Money").GetComponent<Text>();
    }
    void Start()
    {
        int food_index = 100;
        int health_index = 100;
        int emotion_index = 100;
        int appearance_index = 100;
        int iq_index = 100;
        int money_index = 100;


        food.text = food_index.ToString();
        health.text = health_index.ToString();
        emotion.text = emotion_index.ToString();
        appearance.text = appearance_index.ToString();
        iq.text = iq_index.ToString();
        money.text = money_index.ToString();
    }

  
}
