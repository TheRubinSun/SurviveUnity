using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    private Save sv = new Save();
    private string path;


    void Start()
    {
        path = Application.persistentDataPath + "/Save.json";
        if (File.Exists(path))//При загрузке проверяет есть ли файл
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));//Загружает все данные 
            Load();
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
        Player.name = sv.saveName;
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
        Player.hapiness = sv.saveHapiness;
        Player.maxSailty = sv.saveMaxSailty;
        Player.maxHealth = sv.saveMaxHealth;
        Player.maxHapiness = sv.saveMaxHapiness;
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
        Player.haveGarage = sv.saveHaveGarage;
        Player.haveSmallApartment = sv.saveHaveSmallApartment;
        Player.haveBigApartment = sv.saveHaveBigApartment;
        Player.haveHouse = sv.saveHaveHouse;
        Player.lvlComfort = sv.saveLvlComfort;
        //Имущество предметы
        Player.haveSmartphone = sv.saveHaveSmartphone;
        Player.haveComputer = sv.saveHaveComputer;
        //Документы
        Player.havePassport = sv.saveHavePassport;
        Player.haveShcoolAt = sv.saveHaveShcoolAt;
        Player.haveDiplCollage = sv.saveHaveDiplCollage;
        Player.haveDiplVus = sv.saveHveDiplVus;
        Player.haveMagistr = sv.saveHaveMagistr;
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
        Player.lvlSubForEat = sv.saveLvlSubForEat;
        Player.lvlSubForHealth = sv.saveLvlSubForHealth;
        Player.lvlSubForHapiness = sv.saveLvlSubForHapiness;
        //Инвестиции
        //Реусурсы
        Player.countBottle = sv.saveCountBottle;
        Player.countBerries = sv.saveCountBerries;
        Player.countCopper = sv.saveCountCopper;
        Player.countElectronics = sv.saveCountElectronics;
        //Разное
        Player.moneyForBD = sv.saveMoneyForBD;
        Player.DeathBool = sv.saveDeathBool;
        //Временные переменные
        Player.RememberDaysOne = sv.saveRememberDaysOne; //Для акт угля
        Player.RememberDaysTwo = sv.saveRememberDaysTwo; //Для таблеток
                                                         //Акции
        Player.CountPromotio = sv.saveCountPromotio;//Массив акций игрока


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
        public int saveHapiness;
        public int saveMaxSailty;
        public int saveMaxHealth;
        public int saveMaxHapiness;
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
        public bool saveHaveGarage;
        public bool saveHaveSmallApartment;
        public bool saveHaveBigApartment;
        public bool saveHaveHouse;
        public int saveLvlComfort;
        //Имущество предметы
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
        public int saveLvlSubForEat;
        public int saveLvlSubForHealth;
        public int saveLvlSubForHapiness;
        //Инвестиции
        //Реусурсы
        public int saveCountBottle;
        public int saveCountBerries;
        public int saveCountCopper;
        public int saveCountElectronics;
        //Разное
        public int saveMoneyForBD;
        public bool saveDeathBool;
        //Временные переменные
        public int saveRememberDaysOne; //Для акт угля
        public int saveRememberDaysTwo; //Для таблеток
                                        //Акции
        public int[] saveCountPromotio = new int[5];//Массив акций игрока
    }
}
