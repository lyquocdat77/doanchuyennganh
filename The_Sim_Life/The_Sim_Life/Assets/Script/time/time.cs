using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public thoigian tg;
    public character cha;


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
            if (cha.food > 0)
            {
                cha.food -= 10;
            }
            else
            {
                if (cha.health > 0)
                {
                    cha.health -= 10;
      
                }
            }
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
