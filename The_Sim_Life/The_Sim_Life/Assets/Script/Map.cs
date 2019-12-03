using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
   public void toSchool(string school)
    {
        Application.LoadLevel(school);
    }
    public void toMart(string mart)
    {
        Application.LoadLevel(mart);
    }

}
