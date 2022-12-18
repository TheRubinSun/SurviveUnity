using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Личность
    public static string name = "";
    public static int dayB;//из 365
    public static int dataDayB;//День в месяце др
    public static int monthB;
    public static int yearB;
    public static int yearsOld;
    //Внешность
    public static int eyes;
    public static int hair;
    public static int colorhair;
    public static int head;
    public static int mouth;
    public static int nose;
    public static int beard;
    //Нужды
    public static int sailty;
    public static int health;
    public static int hapiness;
    public static int maxSailty;
    public static int maxHealth;
    public static int maxHapiness;
    //Навыки
    public static int power;
    public static int powerNav;
    public static int intellect;
    public static int intelNav;
    public static int handAggility;
    public static int handAggNav;


    public static int reputation;
    public static int lvlBread;
    public static int motivation;
    //Время и статистика
    public static int CurActionDay;//Текущие действие 1/3
    public static int CounterActionsDay;//Счетчик действий
    public static int CurDay;//Текущий день
    public static int DataInMounth;//День в месяце
    public static int TotalDaysInGame;//Всего дней в игре
    public static int CurYears;//Текущий год
    public static int CurMonth;//Текущий месяц
    public static string CurNameMonth;//Название текущего месяца
    public static string CurNameSeason;//Название текущего сезона
    //Имущество предметы
    public static int money;
    public static int totalMoney;
    public static int tempMoney;
    //Имущество жилье
    public static bool haveTent;
    public static bool haveGarage;
    public static bool haveSmallApartment;
    public static bool haveBigApartment;
    public static bool haveHouse;
    public static int lvlComfort;
    //Имущество предметы
    public static bool haveSmartphone;
    public static bool haveComputer;
    //Документы
    public static bool havePassport;
    public static bool haveShcoolAt;
    public static bool haveDiplCollage;
    public static bool haveDiplVus;
    public static bool haveMagistr;
    //Опыт
    public static int ex;
    public static int lvl;
    public static int oldlvl;
    public static float nextExpLvl;
    public static int totalSkillPoint;
    public static int freeSkillPoint;
    //Бизнес
    //Авто-нужды
    public static int haveGarden;
    public static int lvlSubForEat;
    public static int lvlSubForHealth;
    public static int lvlSubForHapiness;
    //Инвестиции
    //Реусурсы
    public static int countBottle;
    public static int countBerries;
    public static int countCopper;
    public static int countElectronics;
    //Разное
    public static int moneyForBD;
    public static bool DeathBool;
    //Временные переменные
    public static int RememberDaysOne; //Для акт угля
    public static int RememberDaysTwo; //Для таблеток
    //Акции
    public static int [] CountPromotio = new int[5];//Массив акций игрока


    public string GetName()
    {
        return name;
    }
    public int GetHead()
    {
        return head;
    }
    public int GetHair()
    {
        return hair;
    }
    public int GetNose()
    {
        return nose;
    }
    public int GetMouth()
    {
        return mouth;
    }
    public int GetEye()
    {
        return eyes;
    }
    public int GetBeard()
    {
        return beard;
    }
    public void AddActions()
    {
        CurActionDay++;
    }
    public int GetLvlBread()
    {
        return lvlBread;
    }


    public Player
        (
        string name_,
        int dayB_,
        int yearB_,
        int yearsOld_,
        int eyes_,
        int hair_,
        int colorhair_,
        int head_,
        int mouth_,
        int nose_,
        int beard_,
        int curDay_,
        int money_
        )
    {
        //Личность
        {
            name = name_;
            dayB = dayB_;
            monthB = 0;
            yearB = yearB_;
            yearsOld = yearsOld_;
        }
        //Внешность
        {
            eyes = eyes_;
            hair = hair_;
            colorhair = colorhair_;
            head = head_;
            mouth = mouth_;
            nose = nose_;
            beard = beard_;
        }
        //Нужды
        {
            sailty = 100;
            health = 100;
            hapiness = 100;
            maxSailty = 100;
            maxHealth = 100;
            maxHapiness = 100;
        }
        //Навыки
        {
            power = 0;
            powerNav = 0;
            intellect = 0;
            intelNav = 0;
            handAggility = 0;
            handAggNav = 0;
            reputation = 0;
            lvlBread = 1;
            motivation = 0;
        }
        //Время и статистика
        {
            CurActionDay = 0;
            CounterActionsDay = 0;
            CurDay = curDay_;
            DataInMounth = 0;
            TotalDaysInGame = 1;
            CurYears = 2000;
            CurMonth = 0;
            CurNameMonth = "";
            CurNameSeason = "";
        }
        //Имущество предметы
        {
            money = money_;
            totalMoney = 0;
            tempMoney = money_;
        }
        //Имущество жилье
        {
            haveTent = false;
            haveGarage = false;
            haveSmallApartment = false;
            haveBigApartment = false;
            haveHouse = false;

            lvlComfort = 0;
        }
        //Имущество предметы
        {
            haveSmartphone = false;
            haveComputer = false;
        }
        //Документы
        {
            havePassport = false;
            haveShcoolAt = false;
            haveDiplCollage = false;
            haveDiplVus = false;
            haveMagistr = false;

        }
        //Опыт
        {
            ex = 0;
            lvl = 1;
            oldlvl = 1;
            nextExpLvl = 100;
            totalSkillPoint = 0;
            freeSkillPoint = 0;
        }
        //Бизнес
        {

        }
        //Авто-нужды
        {
            haveGarden = 0;
            lvlSubForEat = 0;
            lvlSubForHealth = 0;
            lvlSubForHapiness = 0;

        }
        //Инвестиции
        {

        }
        //Реусурсы
        {
            countBottle = 0;
            countBerries = 0;
            countCopper = 0;
            countElectronics = 0;
        }
        //Разное
        {
            moneyForBD = 10;//Деньги за День рождения
            DeathBool = true;//Для респауна
        }
        //Временные переменные
        {
            RememberDaysOne = -3;//для акт угля
            RememberDaysTwo = -3;//для таблеток
        }
        //Акции
        {
            CountPromotio = new int[5];//Массив акций игрока
        }

        
    }
}
