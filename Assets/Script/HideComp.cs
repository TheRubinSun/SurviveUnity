using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideComp : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    //public GameObject three;
    bool hideBool = true;
    public void HideOBG()
    {
        if(hideBool == true)
        {
            hideBool = false;
            one.SetActive(false);
            two.SetActive(false);
            //three.SetActive(false);
        }
        else
        {
            hideBool = true;
            one.SetActive(one);
            two.SetActive(one);
            //three.SetActive(one);
        }
    }
}
