using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    //public GameObject TimeIcon;
    //public Text TextTime;
    public Text textInfo;
    public Text textInfoResurces;
    // Start is called before the first frame update
    void Start()
    {
        UpdateInfo();
        UpdateInfoResurces();
    }

    string textInfoStr;
    string infoResurces;
    int countVariantRec;
    // Update is called once per frame
    public void UpdateInfo()
    {
        textInfoStr = "";
        textInfoStr += $"Имя: {Player.name}\n";
        textInfoStr += $"Деньги: {Player.money}\n";
        textInfoStr += $"Дней: {Player.CurDay}/365\n";
        textInfoStr += $"Действий: {Player.CounterActionsDay}\n";
        textInfoStr += $"Заработанно всего: {Player.totalMoney}\n";
        textInfoStr += $"Тек дейв: {Player.CurActionDay}\n";
        textInfo.text = textInfoStr;

        UpdateInfoResurces();
    }

    public void UpdateInfoResurces()
    {
        infoResurces = "";
        countVariantRec = 0;
        if (Player.countBottle > 0)
        {
            infoResurces += $"Бутылок: {Player.countBottle}";
            countVariantRec++;
        }
        if (Player.countCopper > 0)
        {
            if(countVariantRec>0) infoResurces+="\t";
            infoResurces += $"Меди: {((float)Player.countCopper)/10} кг.";
            countVariantRec++;
        }
        if (Player.countElectronics > 0)
        {
            if (countVariantRec > 0) infoResurces += "\t";
            infoResurces += $"Электроники: {Player.countElectronics}";
        }
        textInfoResurces.text = infoResurces;
    }
}
