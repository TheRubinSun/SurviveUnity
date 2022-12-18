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
        textInfoStr += $"���: {Player.name}\n";
        textInfoStr += $"������: {Player.money}\n";
        textInfoStr += $"����: {Player.CurDay}/365\n";
        textInfoStr += $"��������: {Player.CounterActionsDay}\n";
        textInfoStr += $"����������� �����: {Player.totalMoney}\n";
        textInfoStr += $"��� ����: {Player.CurActionDay}\n";
        textInfo.text = textInfoStr;

        UpdateInfoResurces();
    }

    public void UpdateInfoResurces()
    {
        infoResurces = "";
        countVariantRec = 0;
        if (Player.countBottle > 0)
        {
            infoResurces += $"�������: {Player.countBottle}";
            countVariantRec++;
        }
        if (Player.countCopper > 0)
        {
            if(countVariantRec>0) infoResurces+="\t";
            infoResurces += $"����: {((float)Player.countCopper)/10} ��.";
            countVariantRec++;
        }
        if (Player.countElectronics > 0)
        {
            if (countVariantRec > 0) infoResurces += "\t";
            infoResurces += $"�����������: {Player.countElectronics}";
        }
        textInfoResurces.text = infoResurces;
    }
}
