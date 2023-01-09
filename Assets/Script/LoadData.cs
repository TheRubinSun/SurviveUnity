using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    private Save sv = new Save();
    private SaveAction svAct = new SaveAction();
    private string path;
    private string pathActions;
    public Text textVersion;

    void Start()
    {
        textVersion.text = "Version: "+Application.version;
        path = Application.persistentDataPath + "/Save.json";
        pathActions = Application.persistentDataPath + "/SaveActions.json";
        Invoke("StartGame",1);
    }
    void StartGame()
    {
        if (File.Exists(path))//При загрузке проверяет есть ли файл
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));//Загружает все данные 
            svAct = JsonUtility.FromJson<SaveAction>(File.ReadAllText(pathActions));//Загружает все данные 
            Load();
            LoadAction();
            SceneManager.LoadScene("Street");
        }
        else//Если файла нету
        {
            SceneManager.LoadScene("CreatePlayer");
        }
    }
    public void Load()
    {
        //Личность
        Player.Name = sv.saveName;
        Player.dayB = sv.saveDayB;//из 365
        Player.dataDayB = sv.saveDataDayB;//День в месяце др
        Player.monthB = sv.saveMonthB;
        Player.yearB = sv.saveYearB;
        Player.yearsOld = sv.saveYearsOld;
        //Внешность
        Player.eyes = sv.saveEyes;
        Player.hair = sv.saveHair;
        Player.colorhair = sv.saveColorhair;
        Player.head = sv.saveHead;
        Player.mouth = sv.saveMouth;
        Player.nose = sv.saveNose;
        Player.beard = sv.saveBeard;
        //Нужды
        Player.sailty = sv.saveSailty;
        Player.health = sv.saveHealth;
        Player.happiness = sv.saveHappiness;
        Player.maxSailty = sv.saveMaxSailty;
        Player.maxHealth = sv.saveMaxHealth;
        Player.maxHappiness = sv.savemaxHappiness;
        //Навыки
        Player.power = sv.savePower;
        Player.powerNav = sv.savePowerNav;
        Player.intellect = sv.saveIntellect;
        Player.intelNav = sv.saveIntelNav;
        Player.handAggility = sv.saveHandAggility;
        Player.handAggNav = sv.saveHandAggNav;


        Player.reputation = sv.saveReputation;
        Player.lvlBread = sv.saveLvlBread;
        Player.motivation = sv.saveMotivation;
        //Время и статистика
        Player.CurActionDay = sv.saveCurActionDay;//Текущие действие 1/3
        Player.CounterActionsDay = sv.saveCounterActionsDay;//Счетчик действий
        Player.CurDay = sv.saveCurDay;//Текущий день
        Player.DataInMounth = sv.saveDataInMounth;//День в месяце
        Player.TotalDaysInGame = sv.saveTotalDaysInGame;//Всего дней в игре
        Player.CurYears = sv.saveCurYears;//Текущий год
        Player.mouth = sv.saveCurMonth;//Текущий месяц
        Player.CurNameMonth = sv.saveCurNameMonth;//Название текущего месяца
        Player.CurNameSeason = sv.saveCurNameSeason;//Название текущего сезона
                                                    //Имущество предметы
        Player.money = sv.saveMoney;
        Player.totalMoney = sv.saveTotalMoney;
        Player.tempMoney = sv.saveTempMoney;
        //Имущество жилье
        Player.haveTent = sv.saveHaveTent;
        Player.BrokenCar = sv.saveBrokenCar;
        Player.haveGarage = sv.saveHaveGarage;
        Player.haveApartment = sv.saveHaveApartment;
        Player.haveHouse = sv.saveHaveHouse;
        Player.lvlComfort = sv.saveLvlComfort;
        //Имущество предметы
        Player.Shoes = sv.saveShoes;
        Player.ShoesWear = sv.saveShoesWear;
        Player.Clothes = sv.saveClothes;
        Player.ClothesWear = sv.saveClothesWear;
        Player.Fridge = sv.saveFridge;
        Player.haveSmartphone = sv.saveHaveSmartphone;
        Player.haveComputer = sv.saveHaveComputer;
        //Документы
        Player.havePassport = sv.saveHavePassport;
        Player.haveSchool = sv.savehaveSchool;
        Player.haveDiplCollage = sv.saveHaveDiplCollage;
        Player.haveDiplVus = sv.saveHveDiplVus;
        Player.haveMagistr = sv.saveHaveMagistr;
        Player.haveAspir = sv.saveHaveAspir;
        //Опыт
        Player.ex = sv.saveEx;
        Player.lvl = sv.saveLvl;
        Player.oldlvl = sv.saveOldlvl;
        Player.nextExpLvl = sv.saveNextExpLvl;
        Player.totalSkillPoint = sv.saveTotalSkillPoint;
        Player.freeSkillPoint = sv.saveFreeSkillPoint;
        //Бизнес
        //Авто-нужды
        Player.haveGarden = sv.saveHaveGarden;
        Player.EatSubOnDay = sv.saveEatSubOnDay;
        Player.lvlSubForHealth = sv.saveLvlSubForHealth;
        Player.lvlSubForHapiness = sv.saveLvlSubForHapiness;
        //Инвестиции
        //Реусурсы
        Player.countBottle = sv.saveCountBottle;
        Player.countBerries = sv.saveCountBerries;
        Player.countCopper = sv.saveCountCopper;
        Player.countElectronics = sv.saveCountElectronics;
        Player.priceBottle = sv.savePriceBottle;
        Player.priceBerries = sv.savePriceBerries;
        Player.priceCopper = sv.savePriceCopper;
        Player.priceElectronics = sv.savePriceElectronics;
        //Разное
        Player.moneyPercentForBD = sv.saveMoneyForBD;
        Player.DeathBool = sv.saveDeathBool;
        Player.reloadingDaysCoal = sv.saveReloadingDaysCoal;
        Player.reloadingDaysVitamins = sv.saveReloadingDaysVitamins;
        //Временные переменные
        Player.RememberDaysOne = sv.saveRememberDaysOne; //Для акт угля
        Player.RememberDaysTwo = sv.saveRememberDaysTwo; //Для таблеток
                                                         //Акции
        Player.actions = sv.saveActions;//Массив акций игрока
        Player.countAction = sv.saveCountAction;

        //Цены
        Player.PriceShoes = sv.savePriceShoes;
        Player.PriceClothes = sv.savePriceClothes;
        Player.PriceSmartPhone = sv.savePriceSmartPhone;
        Player.PriceFridge = sv.savePriceFridge;
        Player.PriceCutBread = sv.savePriceCutBread;
        Player.PriceTent = sv.savePriceTent;
        Player.PriceBrokenCar = sv.savePriceBrokenCar;
        Player.PriceGarage = sv.savePriceGarage;
        Player.PriceApartament = sv.savePriceApartament;
        Player.PriceHouse = sv.savePriceHouse;
        Player.PricePassport = sv.savePricePassport;
        Player.PriceSchoolEd = sv.savePriceSchoolEd;
        Player.PriceColledge = sv.savePriceColledge;
        Player.PriceBakal = sv.savePriceBakal;
        Player.PriceMagis = sv.savePriceMagis;
        Player.PriceAsper = sv.savePriceAsper;
    }
    public void LoadAction()
    {
        Player.actions = new Action[svAct.saveName.Length];

        for (int i = 0; i < svAct.saveName.Length; i++)
        {
            Player.actions[i] = new Action(svAct.saveName[i], svAct.saveCost[i]);
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
        public bool savehaveSchool;
        public bool saveHaveDiplCollage;
        public bool saveHveDiplVus;
        public bool saveHaveMagistr;
        public bool saveHaveAspir;
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
        public int saveEatSubOnDay;
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
        public int saveMoneyForBD;
        public bool saveDeathBool;
        public int saveReloadingDaysCoal;
        public int saveReloadingDaysVitamins;
        //Временные переменные
        public int saveRememberDaysOne; //Для акт угля
        public int saveRememberDaysTwo; //Для таблеток
                                        //Акции
        public Action[] saveActions;//Массив акций игрока
        public int[] saveCountAction;

        //Цены
        public int savePriceShoes;
        public int savePriceClothes;
        public int savePriceSmartPhone;
        public int savePriceFridge;
        public int savePriceCutBread;
        public int savePriceTent;
        public int savePriceBrokenCar;
        public int savePriceGarage;
        public int savePriceApartament;
        public int savePriceHouse;
        public int savePricePassport;
        public int savePriceSchoolEd;
        public int savePriceColledge;
        public int savePriceBakal;
        public int savePriceMagis;
        public int savePriceAsper;
    }
    [Serializable]
    class SaveAction
    {
        public string[] saveName;
        public int[] saveCost;
    }
}

