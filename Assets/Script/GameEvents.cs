
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
        int rep = Random.Range(-20, -40);

        PlayerSet(bottle, copper, electronics, -sailty, -health, -happines,rep);
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
        int sailty = Random.Range(25, 35);
        int health = Random.Range(16, 25);
        int happines = Random.Range(27, 35);

        PlayerSet(bottle, copper, electronics, -sailty, -health, -happines,rep);
        OutputInfoResource(bottle, copper, electronics, sailty, health, happines, rep);

        ExecuteButton?.Invoke();
        //actionsButtonsScript.AddAction();
    }
    void OutputInfoResource(int bottle, int copper, int electronics, int sailty, int health, int happines,int rep)
    {
        text = "";
        text += $"Итог:\n+{bottle} бутылок\n";
        if (copper > 0) text += $"+{((float)copper) / 10} кг. меди\n";
        if (electronics > 0) text += $"+{electronics} электроника\n";
        text += $"-{sailty} к сытости\n";
        text += $"-{health} к здоровью\n";
        text += $"-{happines} к счатью\n";
        text += $"-{rep} к репутации\n";
        info.text = text;
    }
    //===========================================================================================================
    public void SellBottle()
    {
        if (Player.countBottle > 0)
        {
            OutputInfoSaleRec($"Вы продали {Player.countBottle} бутылок\n по {Player.priceBottle} Моулей за 1 бутылку\nи получили:\n{Player.countBottle * Player.priceBottle} Моулей");
            Player.PlayerEarnedMoney(Player.countBottle * Player.priceBottle);
            Player.countBottle = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("У вас нету бутылок!");
    }
    public void SellBerries()
    {
        if (Player.countBerries > 0)
        {
            OutputInfoSaleRec($"Вы продали {Player.countBerries} кг. ягод\n по {Player.priceBerries} Моулей за 1 кг\nи получили:\n{Player.countBerries * Player.priceBerries} Моулей");
            Player.PlayerEarnedMoney(Player.countBerries * Player.priceBerries);
            Player.countBerries = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("У вас нету ягод!");
    }
    public void SellCopper()
    {
        if (Player.countCopper >= 10)
        {
            OutputInfoSaleRec($"Вы продали {Player.countCopper / 10} кг. меди\n по {Player.priceCopper} Моулей за 1 кг меди\nи получили:\n{Player.countCopper / 10 * Player.priceCopper} Моулей");
            Player.PlayerEarnedMoney((int)(Player.countCopper/10) * Player.priceCopper);
            Player.countCopper = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("У вас недостаточно меди!");
    }
    public void SellElectronics()
    {
        if (Player.countElectronics > 0)
        {
            OutputInfoSaleRec($"Вы продали {Player.countElectronics} электр.\n по {Player.priceElectronics} Моулей за 1 шт. электроники\nи получили:\n{Player.countElectronics * Player.priceElectronics} Моулей");
            Player.PlayerEarnedMoney(Player.countElectronics * Player.priceElectronics);
            Player.countElectronics = 0;
            ExecuteButton?.Invoke();
        }
        else OutputInfoSaleRec("У вас нету электроники!");
    }
    //===========================================================================================================
    public void SweepYards()
    {
        if(Player.haveSchool == true)
        {
            int sailty = Random.Range(15, 25);
            int health = Random.Range(10, 15);
            int happines = Random.Range(8, 15);
            int money = Random.Range(100, 150);
            int bottle = Random.Range(10, 20);
            int rep = Random.Range(10, 20);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            OutputInfoSaleRec("Чтобы работать дворником,\n нужно школьное образование");
        }

    }
    public void WashCars()
    {
        if ((Player.haveSchool == true) && (Player.reputation > 500))
        {
            int sailty = Random.Range(15, 22);
            int health = Random.Range(8, 15);
            int happines = Random.Range(8, 13);
            int money = Random.Range(150, 200);
            int bottle = 0;
            int rep = Random.Range(20, 40);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("Чтобы мыть машины,\n нужно школьное образование");
            else
                OutputInfoSaleRec("У вас слишком маленькая репутация,\n чтобы мыть машины");

        }
    }
    public void WorkFactory()
    {
        if (Player.haveDiplCollage == true && Player.reputation > 5000)
        {
            int sailty = Random.Range(12, 22);
            int health = Random.Range(8, 13);
            int happines = Random.Range(8, 11);
            int money = 600;
            int bottle = 0;
            int rep = Random.Range(100, 200);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("Чтобы работать на заводе,\n нужен диплом колледжа");
            else
                OutputInfoSaleRec("У вас слишком маленькая репутация,\n чтобы работать на заводе");
        }
    }
    public void WorkOffice()
    {
        if (Player.haveDiplVus == true && Player.reputation > 35000)
        {
            int sailty = Random.Range(12, 20);
            int health = Random.Range(8, 11);
            int happines = Random.Range(7, 11);
            int money = 600;
            int bottle = 0;
            int rep = Random.Range(300, 600);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("Чтобы работать в офисе,\n нужен диплом бакалавра");
            else
                OutputInfoSaleRec("У вас слишком маленькая репутация,\n чтобы работать в офисе");
        }
    }
    public void WorkItCompany()
    {
        if (Player.haveMagistr == true && Player.reputation > 100000)
        {
            int sailty = Random.Range(10, 15);
            int health = Random.Range(7, 10);
            int happines = Random.Range(6, 10);
            int money = 1500;
            int bottle = 0;
            int rep = Random.Range(600, 1500);

            PlayerWorkSet(money, -sailty, -health, -happines, bottle, rep);
            OutputInfoWork(money, sailty, health, happines, bottle, rep);

            ExecuteButton?.Invoke();
        }
        else
        {
            if (Player.haveSchool != true)
                OutputInfoSaleRec("Чтобы работать в IT компании,\n нужен диплом магистра");
            else
                OutputInfoSaleRec("У вас слишком маленькая репутация,\n чтобы работать в IT компании");
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
        text += $"Вы заработали {money} Моулей";
        text += $"-{sailty} к сытости";
        text += $"-{health} к здоровью";
        text += $"-{happiness} к счастью";
        text += $"+{rep} к репутации";
        info.text = text;
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
