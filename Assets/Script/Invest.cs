using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Invest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public static int NewPrice(int lastPrice)
    {
        return (int)Mathf.Round((float)lastPrice + ((float)lastPrice / 100 * JumpPrice(lastPrice)));
    }
    static float JumpPrice(int lastPrice)
    {
        if(lastPrice>150)
        {
            int jumpPrice = Random.Range(0, 31);
            switch (jumpPrice)
            {
                case 0: return -6;
                case 1: return -5;
                case 2: return -4;
                case 3: return -4;
                case 4: return -3;
                case 5: return -3;
                case 6: return -3;
                case 7: return -3;
                case 8: return -2;
                case 9: return -2;
                case 10: return -2;
                case 11: return -2;
                case 12: return -1;
                case 13: return -1;
                case 14: return -1;
                case 15: return 1;
                case 16: return 2;
                case 17: return 2;
                case 18: return 2;
                case 19: return 2;
                case 20: return 3;
                case 21: return 3;
                case 22: return 3;
                case 23: return 3;
                case 24: return 4;
                case 25: return 4;
                case 26: return 4;
                case 27: return 5;
                case 28: return 5;
                case 29: return 6;
                case 30: return 7;
                default: return 1;
            }
        }
        else
        {
            int jumpPrice = Random.Range(0, 11);
            switch (jumpPrice)
            {
                case 0: return -8;
                case 1: return -6;
                case 2: return -5;
                case 3: return -3;
                case 4: return -1;
                case 5: return 1;
                case 6: return 3;
                case 7: return 5;
                case 8: return 7;
                case 9: return 9;
                case 10: return 10;
                default: return 2;
            }
        }

    }
}
public class Action
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public Action(string name, int cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
}
