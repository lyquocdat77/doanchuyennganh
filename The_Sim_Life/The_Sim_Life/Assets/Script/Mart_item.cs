using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mart_item : MonoBehaviour
{
    public Sprite img_item;
    void Awake()
    {
        img_item = GameObject.Find("Button").GetComponent<Sprite>();
    }
    void Start()
    {
        Sprite img1 = Resources.Load<Sprite>("Image_item/Donut");
        //img_item.
    }

   
}
