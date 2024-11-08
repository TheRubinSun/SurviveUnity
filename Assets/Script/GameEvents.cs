
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
        int copper = Random.Range(0, 4);
        int chance = Random.Range(0, 15);

        int electronics = 0;
        if (chance > 13) electronics = 1;

        int sailty = Random.Range(-7, -11);
        int health = Random.Range(-3, -6);
        int happines = Random.Range(-6, -13);
        int rep = Random.Range(-20, -40);

        PlayerSet(bottle, copper, electronics, sailty, health, happines,rep);
        OutputInfoResource(bottle, copper, electronics, sailty, health, happines, rep);

        ExecuteButton?.Invoke();
        //actionsButtonsScript.AddAction();
    }
    public void SearchDumb()
    {
        int bottle = Random.Range(6, 12);
        int copper = Random.Range(0, 15);

        int chance = Random.Range(0, 17);
        int electronics = 0;
        while (chance < 3)
        {
            chance = Random.Range(0, 15);
            electronics++;
        }

        int rep = Random.Range(-40, -80);
        int sailty = Random.Range(-15, -35);
        int health = Random.Range(-16, -25);
        int happines = Random.Range(-20, -30);

        PlayerSet(bottle, copper, electronics, sailty, health, happines,rep);
        OutputInfoResource(bottle, copper, electronics, sailty, health, happines, rep);

        ExecuteButton?.Invoke();
        //actionsButtonsScript.AddAction();
    }
    void OutputInfoResource(int bottle, int copper, int electronics, int sailty, int health, int happines,int rep)
    {
        text = "";
        text += $"����:\n+{bottle} �������\n";
        if (copper > 0) text += $"+{((float)copper) / 10} ��. ����\n";
        if (electronics > 0) text += $"+{electronics} �����������\n";
        text += $"{sailty} � �������\n";
        text += $"{health} � ��������\n";
        text += $"{happines} � ������\n";
        text += $"{rep} � ���������\n";
        info.text = text;
    }
    //===========================================================================================================
    public void SellBottle()
    {
        if (Player.countBottle > 0)
        {
            OutputInfoSaleRec($"�� ������� {Player.countBottle} �������\n �� {Player.priceBottle} ������ �� 1 �������\n� ��������:\n{Player.countBottle * Player.priceBottle} ������");
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
            OutputInfoSaleRec($"�� ������� {Player.countBerries} ��. ����\n �� {Player.priceBerries} ������ �� 1 ��\n� ��������:\n{Player.countBerries * Player.priceBerries} ������");
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
            OutputInfoSaleRec($"�� ������� {Player.countCopper / 10} ��. ����\n �� {Player.priceCopper} ������ �� 1 �� ����\n� ��������:\n{Player.countCopper / 10 * Player.priceCopper} ������");
            Player.PlayerEarnedMoney((int)(Player.countCopper/10) * Player.priceCopper);
            Player.countCopper = Player.countCopper%10;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ������������ ����!\n����� ��������� ������� 1 ��.");
    }
    public void SellElectronics()
    {
        if (Player.countElectronics > 0)
        {
            OutputInfoSaleRec($"�� ������� {Player.countElectronics} ������.\n �� {Player.priceElectronics} ������ �� 1 ��. �����������\n� ��������:\n{Player.countElectronics * Player.priceElectronics} ������");
            Player.PlayerEarnedMoney(Player.countElectronics * Player.priceElectronics);
            Player.countElectronics = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("� ��� ���� �����������!");
    }
    //===========================================================================================================
    public void SweepYards()
    {
        if(Player.havePassport == true)
        {
            int sailty = Random.Range(15, 25);
            int health = Random.Range(10, 15);
            int happines = Random.Range(8, 15);
            int money = Random.Range(90, 130);
            int bottle = Random.Range(10, 20);
            int rep = Random.Range(15, 25);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            OutputInfoSaleRec("����� �������� ���������,\n ������ �������");
        }

    }
    public void WashCars()
    {
        if ((Player.havePassport == true) && (Player.reputation > 500))
        {
            int sailty = Random.Range(15, 22);
            int health = Random.Range(8, 15);
            int happines = Random.Range(8, 13);
            int money = Random.Range(140, 180);
            int bottle = 0;
            int rep = Random.Range(30, 60);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("����� ���� ������,\n ������ �������");
            else
                OutputInfoSaleRec("� ��� ������� ��������� ���������,\n ����� ���� ������");

        }
    }
    public void WorkMarket()
    {
        if ((Player.haveSchool == true) && (Player.reputation > 2000))
        {
            int sailty = Random.Range(13, 21);
            int health = Random.Range(8, 14);
            int happines = Random.Range(8, 12);
            int money = Random.Range(350, 550);
            int bottle = 0;
            int rep = Random.Range(70, 200);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("����� �������� ���������,\n ����� �������� �����������");
            else
                OutputInfoSaleRec("� ��� ������� ��������� ���������,\n ����� �������� ���������");

        }
    }
    public void WorkFactory()
    {
        if (Player.haveDiplCollage == true && Player.reputation > 10000)
        {
            int sailty = Random.Range(12, 20);
            int health = Random.Range(8, 13);
            int happines = Random.Range(8, 11);
            int money = 1100;
            int bottle = 0;
            int rep = Random.Range(500, 800);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("����� �������� �� ������,\n ����� ������ ��������");
            else
                OutputInfoSaleRec("� ��� ������� ��������� ���������,\n ����� �������� �� ������");
        }
    }
    public void WorkOffice()
    {
        if (Player.haveDiplVus == true && Player.reputation > 50000)
        {
            int sailty = Random.Range(11, 19);
            int health = Random.Range(8, 11);
            int happines = Random.Range(7, 11);
            int money = 3800;
            int bottle = 0;
            int rep = Random.Range(1000, 1700);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("����� �������� � �����,\n ����� ������ ���������");
            else
                OutputInfoSaleRec("� ��� ������� ��������� ���������,\n ����� �������� � �����");
        }
    }
    public void WorkItCompany()
    {
        if (Player.haveMagistr == true && Player.reputation > 150000)
        {
            int sailty = Random.Range(11, 15);
            int health = Random.Range(7, 10);
            int happines = Random.Range(6, 10);
            int money = 9500;
            int bottle = 0;
            int rep = Random.Range(2000, 3500);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("����� �������� � IT ��������,\n ����� ������ ��������");
            else
                OutputInfoSaleRec("� ��� ������� ��������� ���������,\n ����� �������� � IT ��������");
        }
    }

    //===========================================================================================================
    void OutputInfoSaleRec(string warning)
    {
        info.text = warning;
    }

    void PlayerSet(int countBottle,int countCopper,int countElectronics,int sailty, int health,int happiness,int rep)
    {
        Player.countBottle += countBottle;
        Player.countCopper += countCopper;
        Player.countElectronics += countElectronics;
        Player.sailty += sailty;
        Player.health += health;
        Player.happiness += happiness;
        Player.reputation += rep;
    }
    void PlayerWorkSet(int money, int sailty, int health, int happiness, int bottle,int rep)
    {
        Player.PlayerEarnedMoney(money);
        Player.countBottle += bottle;
        Player.sailty += sailty;
        Player.health += health;
        Player.happiness += happiness;
        Player.reputation += rep;
    }
    void OutputInfoWork(int money, int sailty, int health, int happiness, int bottle, int rep)
    {
        text = "";
        text += $"�� ���������� {money} ������\n";
        text += $"-{sailty} � �������\n";
        text += $"-{health} � ��������\n";
        text += $"-{happiness} � �������\n";
        text += $"+{rep} � ���������\n";
        info.text = text;
    }
    //===========================================================================================================
    public delegate void DelOpen();
    public static event DelOpen OpenEvent;
    public void OpenDisplayPriceRec()
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
