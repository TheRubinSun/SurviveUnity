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
    private void OnEnable()
    {
        ActionsButtons.OneAction += UpdateInfo;
        ActionsButtons.OneAction += UpdateInfoResurces;

    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= UpdateInfo;
        ActionsButtons.OneAction -= UpdateInfoResurces;

    }

    string textInfoStr;
    string infoResurces;
    int countVariantRec;
    // Update is called once per frame

    
    public void UpdateInfo()
    {
        textInfoStr = "";
        textInfoStr += $"���: {Player.Name}\n";
        textInfoStr += $"������: {Player.money}\n";
        textInfoStr += $"����: {Player.CurDay}/365\n";
        textInfoStr += $"��������: {Player.CounterActionsDay}\n";
        textInfoStr += $"����������� �����: {Player.totalMoney}\n";
        textInfoStr += $"��� ����: {Player.CurActionDay}\n";
        textInfoStr += $"���� ������: {Player.lvlBread}\n";
        textInfoStr += $"���������: {Player.reputation}\n";
        textInfo.text = textInfoStr;

    }

    public void UpdateInfoResurces()
    {
        infoResurces = "";
        infoResurces += $"������: {Player.money}\t ";
        if (Player.countBottle > 0)
        {
            infoResurces += $"�������: {Player.countBottle}\t ";
            countVariantRec++;
        }
        if (Player.countCopper > 0)
        {
            infoResurces += $"����: {((float)Player.countCopper)/10} ��.\t ";
            countVariantRec++;
        }
        if (Player.countElectronics > 0)
        {
            infoResurces += $"�����������: {Player.countElectronics}";
        }
        textInfoResurces.text = infoResurces;
    }
}
