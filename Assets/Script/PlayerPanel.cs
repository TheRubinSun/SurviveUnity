using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    //public GameObject TimeIcon;
    //public Text TextTime;
    public Text textInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string textInfoStr = "";
        textInfoStr += $"    {Player.name}\n";
        textInfoStr += $"Деньги: {Player.money}\n";
        textInfoStr += $"Дней: {Player.CurDay}/365\n";
        textInfoStr += $"Действий: {Player.CounterActionsDay}\n";
        textInfoStr += $"Заработанно всего: {Player.totalMoney}\n";
        textInfoStr += $"Тек дейв: {Player.CurActionDay}\n";
        textInfo.text = textInfoStr;
        /*
        if(Player.CurActionDay == 1)
        {
            TimeIcon.GetComponent<Animation>().Play("morring");
            TextTime.text = "1/3";
            TextTime.color = new Color(255, 255, 255);
        }
        else if(Player.CurActionDay == 2)
        {
            TimeIcon.GetComponent<Animation>().Play("day");
            TextTime.text = "2/3";
            TextTime.color = new Color(0, 0, 0);
        }
        else if(Player.CurActionDay == 3)
        {
            TimeIcon.GetComponent<Animation>().Play("night");
            TextTime.text = "3/3";
            TextTime.color = new Color(255, 255, 255);
        }
        */
    }
}
