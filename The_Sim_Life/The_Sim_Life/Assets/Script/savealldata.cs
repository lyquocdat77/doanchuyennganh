using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savealldata : MonoBehaviour
{
    public character cha;
    public thoigian tg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void savedata(string nextscenes)
    {
        gamedata.chadata.savecharacterindex(cha);
        gamedata.tgdata.Save(tg);
        Application.LoadLevel(nextscenes);

    }
   

}
