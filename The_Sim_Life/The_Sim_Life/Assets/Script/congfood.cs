using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congfood : MonoBehaviour
{
    public character cha;
    public void cfood()
    {
        cha.food = 100;
        gamedata.chadata.savecharacterindex(cha);
    }
}
