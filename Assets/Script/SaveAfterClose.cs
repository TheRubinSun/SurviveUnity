using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveAfterClose : MonoBehaviour
{

    private Save sv = new Save();
    private string path;
    private string pathStartGame;

    private void OnEnable()
    {
        CheckEvents.EventDeath += SaveButton;
    }
    private void OnDisable()
    {
        CheckEvents.EventDeath -= SaveButton;
    }
    void Start()
    {
        path = Application.persistentDataPath + "/Save.json";
        pathStartGame = Application.persistentDataPath + "/StartSavePerson.json";
        InvokeRepeating("SaveButton", 1, 10);
    }
    private void OnApplicationPause(bool pause)//для андроид
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0 && (pause))
        {
            SaveFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
        }
        else
        {
            File.Delete(path);
        }
    }

    private void OnApplicationQuit()//Для ПК
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0)
        {
            SaveFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
        }
        else
        {
            File.Delete(path);
        }
    }
    public void SaveButton()
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0)
        {
            SaveFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
        }
        else
        {
            File.Delete(path);
        }
    }
    public void SaveFile()
    {
        //Личность
        sv.saveName = Player.Name;
        sv.saveDayB = Player.dayB;//из 365
        sv.saveDataDayB = Player.dataDayB;//День в месяце др
        sv.saveMonthB = Player.monthB;
        sv.saveYearB = Player.yearB;
        sv.saveYearsOld = Player.yearsOld;
        //Внешность
        sv.saveEyes = Player.eyes;
        sv.saveHair = Player.hair;
        sv.saveColorhair = Player.colorhair;
        sv.saveHead = Player.head;
        sv.saveMouth = Player.mouth;
        sv.saveNose = Player.nose;
        sv.saveBeard = Player.beard;
        //Нужды
        sv.saveSailty = Player.sailty;
        sv.saveHealth = Player.health;
        sv.saveHappiness = Player.happiness;
        sv.saveMaxSailty = Player.maxSailty;
        sv.saveMaxHealth = Player.maxHealth;
        sv.savemaxHappiness = Player.maxHappiness;
        //Навыки
        sv.savePower = Player.power;
        sv.savePowerNav = Player.powerNav;
        sv.saveIntellect = Player.intellect;
        sv.saveIntelNav = Player.intelNav;
        sv.saveHandAggility = Player.handAggility;
        sv.saveHandAggNav = Player.handAggNav;


        sv.saveReputation = Player.reputation;
        sv.saveLvlBread = Player.lvlBread;
        sv.saveMotivation = Player.motivation;
        //Время и статистика
        sv.saveCurActionDay = Player.CurActionDay;//Текущие действие 1/3
        sv.saveCounterActionsDay = Player.CounterActionsDay;//Счетчик действий
        sv.saveCurDay = Player.CurDay;//Текущий день
        sv.saveDataInMounth = Player.DataInMounth;//День в месяце
        sv.saveTotalDaysInGame = Player.TotalDaysInGame;//Всего дней в игре
        sv.saveCurYears = Player.CurYears;//Текущий год
        sv.saveCurMonth = Player.mouth;//Текущий месяц
        sv.saveCurNameMonth = Player.CurNameMonth;//Название текущего месяца
        sv.saveCurNameSeason = Player.CurNameSeason;//Название текущего сезона
        //Имущество предметы
        sv.saveMoney = Player.money;
        sv.saveTotalMoney = Player.totalMoney;
        sv.saveTempMoney = Player.tempMoney;
        //Имущество жилье
        sv.saveHaveTent = Player.haveTent;
        sv.saveBrokenCar = Player.BrokenCar;
        sv.saveHaveGarage = Player.haveGarage;
        sv.saveHaveApartment = Player.haveApartment;
        sv.saveHaveHouse = Player.haveHouse;
        sv.saveLvlComfort = Player.lvlComfort;
        //Имущество предметы
        sv.saveShoes = Player.Shoes;
        sv.saveShoesWear = Player.ShoesWear;
        sv.saveClothes = Player.Clothes;
        sv.saveClothesWear = Player.ClothesWear;
        sv.saveFridge = Player.Fridge;
        sv.saveHaveSmartphone = Player.haveSmartphone;
        sv.saveHaveComputer = Player.haveComputer;
        //Документы
        sv.saveHavePassport = Player.havePassport;
        sv.saveHaveShcoolAt = Player.haveShcoolAt;
        sv.saveHaveDiplCollage = Player.haveDiplCollage;
        sv.saveHveDiplVus = Player.haveDiplVus;
        sv.saveHaveMagistr = Player.haveMagistr;
        //Опыт
        sv.saveEx = Player.ex;
        sv.saveLvl = Player.lvl;
        sv.saveOldlvl = Player.oldlvl;
        sv.saveNextExpLvl = Player.nextExpLvl;
        sv.saveTotalSkillPoint = Player.totalSkillPoint;
        sv.saveFreeSkillPoint = Player.freeSkillPoint;
        //Бизнес
        //Авто-нужды
        sv.saveHaveGarden = Player.haveGarden;
        sv.saveEatOnWeek = Player.EatOnWeek;
        sv.saveEatOnMonth = Player.EatOnMonth;
        sv.saveLvlSubForHealth = Player.lvlSubForHealth;
        sv.saveLvlSubForHapiness = Player.lvlSubForHapiness;
        //Инвестиции
        //Реусурсы
        sv.saveCountBottle = Player.countBottle;
        sv.savePriceBottle = Player.priceBottle;
        sv.saveCountBerries = Player.countBerries;
        sv.savePriceBerries = Player.priceBerries;
        sv.saveCountCopper = Player.countCopper;
        sv.savePriceCopper = Player.priceCopper;
        sv.saveCountElectronics = Player.countElectronics;
        sv.savePriceElectronics = Player.priceElectronics;
        //Разное
        sv.saveMoneyPercentForBD = Player.moneyPercentForBD;
        sv.saveDeathBool = Player.DeathBool;
        //Временные переменные
        sv.saveRememberDaysOne = Player.RememberDaysOne; //Для акт угля
        sv.saveRememberDaysTwo = Player.RememberDaysTwo; //Для таблеток
        //Акции
        sv.saveCountPromotio = Player.CountPromotio;//Массив акций игрока
    }
}


[Serializable]
public class Save
{
    //Личность
    public string saveName;
    public int saveDayB;//из 365
    public int saveDataDayB;//День в месяце др
    public int saveMonthB;
    public int saveYearB;
    public int saveYearsOld;
    //Внешность
    public int saveEyes;
    public int saveHair;
    public int saveColorhair;
    public int saveHead;
    public int saveMouth;
    public int saveNose;
    public int saveBeard;
    //Нужды
    public int saveSailty;
    public int saveHealth;
    public int saveHappiness;
    public int saveMaxSailty;
    public int saveMaxHealth;
    public int savemaxHappiness;
    //Навыки
    public int savePower;
    public int savePowerNav;
    public int saveIntellect;
    public int saveIntelNav;
    public int saveHandAggility;
    public int saveHandAggNav;

    public int saveReputation;
    public int saveLvlBread;
    public int saveMotivation;
    //Время и статистика
    public int saveCurActionDay;//Текущие действие 1/3
    public int saveCounterActionsDay;//Счетчик действий
    public int saveCurDay;//Текущий день
    public int saveDataInMounth;//День в месяце
    public int saveTotalDaysInGame;//Всего дней в игре
    public int saveCurYears;//Текущий год
    public int saveCurMonth;//Текущий месяц
    public string saveCurNameMonth;//Название текущего месяца
    public string saveCurNameSeason;//Название текущего сезона
    //Имущество предметы
    public int saveMoney;
    public int saveTotalMoney;
    public int saveTempMoney;
    //Имущество жилье
    public bool saveHaveTent;
    public bool saveBrokenCar;
    public bool saveHaveGarage;
    public bool saveHaveApartment;
    public bool saveHaveHouse;
    public int saveLvlComfort;
    //Имущество предметы
    public int saveShoes;
    public int saveShoesWear;
    public int saveClothes;
    public int saveClothesWear;
    public bool saveFridge;
    public bool saveHaveSmartphone;
    public bool saveHaveComputer;
    //Документы
    public bool saveHavePassport;
    public bool saveHaveShcoolAt;
    public bool saveHaveDiplCollage;
    public bool saveHveDiplVus;
    public bool saveHaveMagistr;
    //Опыт
    public int saveEx;
    public int saveLvl;
    public int saveOldlvl;
    public float saveNextExpLvl;
    public int saveTotalSkillPoint;
    public int saveFreeSkillPoint;
    //Бизнес
    //Авто-нужды
    public int saveHaveGarden;
    public int saveEatOnWeek;
    public int saveEatOnMonth;
    public int saveLvlSubForHealth;
    public int saveLvlSubForHapiness;
    //Инвестиции
    //Реусурсы
    public int saveCountBottle;
    public int savePriceBottle;
    public int saveCountBerries;
    public int savePriceBerries;
    public int saveCountCopper;
    public int savePriceCopper;
    public int saveCountElectronics;
    public int savePriceElectronics;
    //Разное
    public int saveMoneyPercentForBD;
    public bool saveDeathBool;
    //Временные переменные
    public int saveRememberDaysOne; //Для акт угля
    public int saveRememberDaysTwo; //Для таблеток
    //Акции
    public int[] saveCountPromotio = new int[5];//Массив акций игрока
}
