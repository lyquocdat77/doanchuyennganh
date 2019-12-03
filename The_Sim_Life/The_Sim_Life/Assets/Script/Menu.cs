using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

        public void toStart(string home)
        {
            Application.LoadLevel(home);
        }

}
