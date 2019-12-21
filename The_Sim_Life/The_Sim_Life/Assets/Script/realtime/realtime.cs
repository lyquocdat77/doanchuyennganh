using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class realtime : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public float Realtime;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       Realtime += Time.deltaTime;
        
    }
}
