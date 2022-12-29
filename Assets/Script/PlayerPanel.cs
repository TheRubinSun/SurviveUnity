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
        textInfoStr += $"Имя: {Player.Name}\n";
        textInfoStr += $"Моулей: {Player.money}\n";
        textInfoStr += $"Дней: {Player.CurDay}/365\n";
        textInfoStr += $"Действий: {Player.CounterActionsDay}\n";
        textInfoStr += $"Заработанно всего: {Player.totalMoney}\n";
        textInfoStr += $"Тек дейв: {Player.CurActionDay}\n";
        textInfoStr += $"Уров бороды: {Player.lvlBread}\n";
        textInfoStr += $"Репутация: {Player.reputation}\n";
        textInfo.text = textInfoStr;

    }

    public void UpdateInfoResurces()
    {
        infoResurces = "";
        infoResurces += $"Моулей: {Player.money}\t ";
        if (Player.countBottle > 0)
        {
            infoResurces += $"Бутылок: {Player.countBottle}\t ";
            countVariantRec++;
        }
        if (Player.countCopper > 0)
        {
            infoResurces += $"Меди: {((float)Player.countCopper)/10} кг.\t ";
            countVariantRec++;
        }
        if (Player.countElectronics > 0)
        {
            infoResurces += $"Электроники: {Player.countElectronics}";
        }
        textInfoResurces.text = infoResurces;
    }
}
