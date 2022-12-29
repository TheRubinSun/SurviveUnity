using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Личность
    public static string Name { get;set;}
    public static int dayB { get; set; }//из 365
    public static int dataDayB { get;set;}//День в месяце др
    public static int monthB { get; set; }
    public static int yearB { get; set; }
    public static int yearsOld { get; set; }
    //Внешность
    public static int eyes { get; set; }
    public static int hair { get; set; }
    public static int colorhair { get; set; }
    public static int head { get; set; }
    public static int mouth { get; set; }
    public static int nose { get; set; }
    public static int beard { get; set; }
    //Нужды
    public static int sailty { get; set; }
    public static int health { get; set; }
    public static int happiness { get; set; }
    public static int maxSailty { get; set; }
    public static int maxHealth { get; set; }
    public static int maxHappiness { get; set; }
    //Навыки
    public static int power { get; set; }
    public static int powerNav { get; set; }
    public static int intellect { get; set; }
    public static int intelNav { get; set; }
    public static int handAggility { get; set; }
    public static int handAggNav { get; set; }


    public static int reputation { get; set; }
    public static int lvlBread { get; set; }
    public static int motivation { get; set; }
    //Время и статистика
    public static int CurActionDay { get; set; }//Текущие действие 1/3
    public static int CounterActionsDay { get; set; }//Счетчик действий
    public static int CurDay { get; set; }//Текущий день
    public static int DataInMounth { get; set; }//День в месяце
    public static int TotalDaysInGame { get; set; }//Всего дней в игре
    public static int CurYears { get; set; }//Текущий год
    public static int CurMonth { get; set; }//Текущий месяц
    public static string CurNameMonth { get; set; }//Название текущего месяца
    public static string CurNameSeason { get; set; }//Название текущего сезона
    //Имущество предметы
    public static int money { get; set; }
    public static int totalMoney { get; set; }
    public static int tempMoney { get; set; }
    //Имущество жилье
    public static bool haveTent { get; set; }
    public static bool BrokenCar { get; set; }
    public static bool haveGarage { get; set; }
    public static bool haveApartment { get; set; }
    public static bool haveHouse { get; set; }
    public static int lvlComfort { get; set; }
    //Имущество предметы
    public static int Shoes { get; set;}
    public static int ShoesWear { get; set; }
    public static int Clothes { get; set; }
    public static int ClothesWear { get; set; }
    public static bool haveSmartphone { get;set;}
    public static bool Fridge { get; set; }
    public static bool haveComputer { get;set;}
    //Документы
    public static bool havePassport { get;set;}
    public static bool haveSchool { get;set;}
    public static bool haveDiplCollage { get;set;}
    public static bool haveDiplVus { get;set;}
    public static bool haveMagistr { get;set;}
    public static bool haveAspir { get; set; }
    //Опыт
    public static int ex { get;set;}
    public static int lvl { get;set;}
    public static int oldlvl { get;set;}
    public static float nextExpLvl { get;set;}
    public static int totalSkillPoint { get;set;}
    public static int freeSkillPoint { get;set;}
    //Бизнес
    //Авто-нужды
    public static int haveGarden { get;set;}
    public static int EatSubOnDay { get;set;}
    public static int lvlSubForHealth { get;set;}
    public static int lvlSubForHapiness { get;set;}
    //Инвестиции
    //Реусурсы
    public static int countBottle { get;set;}
    public static int priceBottle { get; set; }
    public static int countBerries { get;set;}
    public static int priceBerries { get; set; }
    public static int countCopper { get;set;}
    public static int priceCopper { get; set; }
    public static int countElectronics { get;set;}
    public static int priceElectronics { get; set; }
    //Разное
    public static int moneyPercentForBD { get;set;}
    public static bool DeathBool { get;set;}
    public static int reloadingDaysCoal { get;set;}
    public static int reloadingDaysVitamins { get;set;}
    //Временные переменные
    public static int RememberDaysOne { get;set;} //Для акт угля
    public static int RememberDaysTwo { get;set;} //Для таблеток
    //Акции

    public static Action [] actions { get; set; }//Массив акций игрока
    public static int[] countAction { get; set; }//Акции у игрока


    public static int GetHead()
    {
        return head;
    }
    public static int GetHair()
    {
        return hair;
    }
    public static int GetNose()
    {
        return nose;
    }
    public static int GetMouth()
    {
        return mouth;
    }
    public static int GetEye()
    {
        return eyes;
    }
    public static int GetBeard()
    {
        return beard;
    }
    public static int GetLvlBread()
    {
        return lvlBread;
    }
    public static void PlayerEarnedMoney(int earnMoney)
    {
        Player.money += earnMoney;
        Player.totalMoney += earnMoney;
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
            Name = name_;
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
            happiness = 100;
            maxSailty = 100;
            maxHealth = 100;
            maxHappiness = 100;
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
            BrokenCar = false;
            haveGarage = false;
            haveApartment = false;
            haveApartment = false;
            haveHouse = false;

            lvlComfort = 0;
        }
        //Имущество предметы
        {
            Shoes = 0;
            ShoesWear = 0;
            Clothes = 0;
            ClothesWear = 0;
            Fridge = false;
            haveSmartphone = false;
            haveComputer = false;
        }
        //Документы
        {
            havePassport = false;
            haveSchool = false;
            haveDiplCollage = false;
            haveDiplVus = false;
            haveMagistr = false;
            haveAspir = false;

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
            EatSubOnDay = 0;
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
            moneyPercentForBD = 5;//Деньги за День рождения
            DeathBool = true;//Для респауна
            reloadingDaysCoal = 0;
            reloadingDaysVitamins = 0;
        }
        //Временные переменные
        {
            RememberDaysOne = -3;//для акт угля
            RememberDaysTwo = -3;//для таблеток
        }
        //Акции
        {
            actions = new Action[5];//Массив акций игрока
            countAction = new int[5];
        }
    }
}
