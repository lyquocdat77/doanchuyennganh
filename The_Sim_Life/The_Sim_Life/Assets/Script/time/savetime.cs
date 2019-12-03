using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savetime : MonoBehaviour
{
    private Sprite hinh1;
    private Sprite hinh2;
    private Sprite hinh3;
    private Sprite hinh4;
    private Sprite hinh5;
    private Sprite hinh6;
    private Sprite hinh7;
    private Sprite hinh8;
    private GameObject imagetime;
    public thoigian tg;
    // Start is called before the first frame update
    void Start()
    {
        hinh1 = Resources.Load<Sprite>("Images/time1");
        hinh2 = Resources.Load<Sprite>("Images/time2");
        hinh3 = Resources.Load<Sprite>("Images/time3");
        hinh4 = Resources.Load<Sprite>("Images/time4");
        hinh5 = Resources.Load<Sprite>("Images/time5");
        hinh6 = Resources.Load<Sprite>("Images/time6");
        hinh7 = Resources.Load<Sprite>("Images/time7");
        hinh8 = Resources.Load<Sprite>("Images/time8");
        imagetime = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        if (tg.Time == 0)
            imagetime.GetComponent<Image>().sprite = hinh1;
        if (tg.Time == 1)
            imagetime.GetComponent<Image>().sprite = hinh2;
        if (tg.Time == 2)
            imagetime.GetComponent<Image>().sprite = hinh3;
        if (tg.Time == 3)
            imagetime.GetComponent<Image>().sprite = hinh4;
        if (tg.Time == 4)
            imagetime.GetComponent<Image>().sprite = hinh5;
        if (tg.Time == 5)
            imagetime.GetComponent<Image>().sprite = hinh6;
        if (tg.Time == 6)
            imagetime.GetComponent<Image>().sprite = hinh7;
        if (tg.Time == 7)
            imagetime.GetComponent<Image>().sprite = hinh8;
    }
}
