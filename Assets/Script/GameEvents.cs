
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    //[SerializeField] ActionsButtons actionsButtonsScript;
    public delegate void DisButtonWork();
    public static event DisButtonWork ExecuteButton;

    public Text info;
    string text;
    //===========================================================================================================
    public void SearchUrn()
    {
        int bottle = Random.Range(3, 8);
        int copper = Random.Range(0, 2);
        int chance = Random.Range(0, 15);
        int electronics = 0;
        if (chance > 13) electronics = 1;

        int sailty = Random.Range(7, 11);
        int health = Random.Range(3, 6);
        int happines = Random.Range(6, 13);

        Player.countBottle += bottle;
        Player.countCopper += copper;
        Player.countElectronics += electronics;
        Player.sailty -= sailty;
        Player.health -= health;
        Player.hapiness -= happines;

        OutputInfoResource(bottle, copper, electronics, sailty, health, happines);

        ExecuteButton?.Invoke();
        //actionsButtonsScript.AddAction();
    }
    public void SearchDumb()
    {
        int bottle = Random.Range(6, 12);
        int copper = Random.Range(0, 8);
        int chance = Random.Range(0, 15);
        int electronics = 0;
        while (chance < 3)
        {
            chance = Random.Range(0, 15);
            electronics++;
        }

        int sailty = Random.Range(25, 40);
        int health = Random.Range(16, 25);
        int happines = Random.Range(30, 46);

        Player.countBottle += bottle;
        Player.countCopper += copper;
        Player.countElectronics += electronics;
        Player.sailty -= sailty;
        Player.health -= health;
        Player.hapiness -= happines;

        OutputInfoResource(bottle, copper, electronics, sailty, health, happines);

        ExecuteButton?.Invoke();
        //actionsButtonsScript.AddAction();
    }
    void OutputInfoResource(int bottle, int copper, int electronics, int sailty, int health, int happines)
    {
        text = "";
        text += $"����:\n+{bottle} �������\n";
        if (copper > 0) text += $"+{((float)copper) / 10} ��. ����\n";
        if (electronics > 0) text += $"+{electronics} �����������\n";
        text += $"-{sailty} � �������\n";
        text += $"-{health} � ��������\n";
        text += $"-{happines} � ������\n";
        info.text = text;
    }
    //===========================================================================================================
    public void SellBottle()
    {
        if (Player.countBottle > 0)
        {
            OutputInfoSaleRec($"�� ������� {Player.countBottle} �������\n �� {Player.priceBottle} ���. �� 1 �������\n� ��������:\n{Player.countBottle * Player.priceBottle} ������");
            Player.PlayerEarnedMoney(Player.countBottle * Player.priceBottle);
            Player.countBottle = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ���� �������!");
    }
    public void SellBerries()
    {
        if (Player.countBerries > 0)
        {
            OutputInfoSaleRec($"�� ������� {Player.countBerries} ��. ����\n �� {Player.priceBerries} ���. �� 1 ��\n� ��������:\n{Player.countBerries * Player.priceBerries} ������");
            Player.PlayerEarnedMoney(Player.countBerries * Player.priceBerries);
            Player.countBerries = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ���� ����!");
    }
    public void SellCopper()
    {
        if (Player.countCopper >= 10)
        {
            OutputInfoSaleRec($"�� ������� {Player.countCopper / 10} ��. ����\n �� {Player.priceCopper} ���. �� 1 �� ����\n� ��������:\n{Player.countCopper / 10 * Player.priceCopper} ������");
            Player.PlayerEarnedMoney((int)(Player.countCopper/10) * Player.priceCopper);
            Player.countCopper = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ������������ ����!");
    }
    public void SellElectronics()
    {
        if (Player.countElectronics > 0)
        {
            OutputInfoSaleRec($"�� ������� {Player.countElectronics} �����������\n �� {Player.priceElectronics} ���. �� �� 1 �����������\n� ��������:\n{Player.countElectronics * Player.priceElectronics} ������");
            Player.PlayerEarnedMoney(Player.countElectronics * Player.priceElectronics);
            Player.countElectronics = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ���� �����������!");
    }
    void OutputInfoSaleRec(string warning)
    {
        info.text = warning;
    }
    //===========================================================================================================
    public delegate void DelOpen();
    public static event DelOpen OpenEvent;
    public void OpenDisplayPrice()
    {
        OpenEvent.Invoke();
    }
    public void SkipDay()
    {
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
    }
    public void SkipTenDay()
    {
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
        ExecuteButton?.Invoke();
    }

}
