
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_character_index : MonoBehaviour
{
    private Text food;
    private Text health;
    private Text emotion;
    private Text appearence;
    private Text iq;
    private Text money;
    public character cha;
    //public thoigian tg;


    // Start is called before the first frame update
    void Start()
    {
        food = GameObject.Find("Food").GetComponent<Text>();
        health = GameObject.Find("Health").GetComponent<Text>();
        emotion = GameObject.Find("Emotion").GetComponent<Text>();
        appearence = GameObject.Find("Appearence").GetComponent<Text>();
        iq = GameObject.Find("IQ").GetComponent<Text>();
        money = GameObject.Find("Money").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        food.text = cha.food +"";
        health.text = cha.health + "";
        emotion.text = cha.emotion + "";
        appearence.text = cha.appearance + "";
        iq.text = cha.iq + "";
        money.text = cha.money + "";
    }
}
