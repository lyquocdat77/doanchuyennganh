using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public thoigian tg;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void congtime()
    {
        tg.Time ++;
        resettime();
    }

    private void resettime()
    {

        if (tg.Time == 8)
        {
            tg.Time = 0;
        }
    }

    public void hienthi()
    {
        congtime();
    }



    //// Update is called once per frame
    //void Update()
    //{

    //}
}
