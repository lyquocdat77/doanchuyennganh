using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xulythoigiannghi : MonoBehaviour
{
    public restime RTIME;
    static DateTime t = DateTime.Now;
    private int solantru;
    // Start is called before the first frame update
    void Start()
    {
        double starttime = (t.ToUniversalTime() - new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        solantru = ((int)(starttime - RTIME.Restime))/800;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
