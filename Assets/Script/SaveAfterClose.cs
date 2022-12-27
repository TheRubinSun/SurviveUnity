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
    private void OnApplicationPause(bool pause)//��� �������
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

    private void OnApplicationQuit()//��� ��
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
        //��������
        sv.saveName = Player.Name;
        sv.saveDayB = Player.dayB;//�� 365
        sv.saveDataDayB = Player.dataDayB;//���� � ������ ��
        sv.saveMonthB = Player.monthB;
        sv.saveYearB = Player.yearB;
        sv.saveYearsOld = Player.yearsOld;
        //���������
        sv.saveEyes = Player.eyes;
        sv.saveHair = Player.hair;
        sv.saveColorhair = Player.colorhair;
        sv.saveHead = Player.head;
        sv.saveMouth = Player.mouth;
        sv.saveNose = Player.nose;
        sv.saveBeard = Player.beard;
        //�����
        sv.saveSailty = Player.sailty;
        sv.saveHealth = Player.health;
        sv.saveHappiness = Player.happiness;
        sv.saveMaxSailty = Player.maxSailty;
        sv.saveMaxHealth = Player.maxHealth;
        sv.savemaxHappiness = Player.maxHappiness;
        //������
        sv.savePower = Player.power;
        sv.savePowerNav = Player.powerNav;
        sv.saveIntellect = Player.intellect;
        sv.saveIntelNav = Player.intelNav;
        sv.saveHandAggility = Player.handAggility;
        sv.saveHandAggNav = Player.handAggNav;


        sv.saveReputation = Player.reputation;
        sv.saveLvlBread = Player.lvlBread;
        sv.saveMotivation = Player.motivation;
        //����� � ����������
        sv.saveCurActionDay = Player.CurActionDay;//������� �������� 1/3
        sv.saveCounterActionsDay = Player.CounterActionsDay;//������� ��������
        sv.saveCurDay = Player.CurDay;//������� ����
        sv.saveDataInMounth = Player.DataInMounth;//���� � ������
        sv.saveTotalDaysInGame = Player.TotalDaysInGame;//����� ���� � ����
        sv.saveCurYears = Player.CurYears;//������� ���
        sv.saveCurMonth = Player.mouth;//������� �����
        sv.saveCurNameMonth = Player.CurNameMonth;//�������� �������� ������
        sv.saveCurNameSeason = Player.CurNameSeason;//�������� �������� ������
        //��������� ��������
        sv.saveMoney = Player.money;
        sv.saveTotalMoney = Player.totalMoney;
        sv.saveTempMoney = Player.tempMoney;
        //��������� �����
        sv.saveHaveTent = Player.haveTent;
        sv.saveBrokenCar = Player.BrokenCar;
        sv.saveHaveGarage = Player.haveGarage;
        sv.saveHaveApartment = Player.haveApartment;
        sv.saveHaveHouse = Player.haveHouse;
        sv.saveLvlComfort = Player.lvlComfort;
        //��������� ��������
        sv.saveShoes = Player.Shoes;
        sv.saveShoesWear = Player.ShoesWear;
        sv.saveClothes = Player.Clothes;
        sv.saveClothesWear = Player.ClothesWear;
        sv.saveFridge = Player.Fridge;
        sv.saveHaveSmartphone = Player.haveSmartphone;
        sv.saveHaveComputer = Player.haveComputer;
        //���������
        sv.saveHavePassport = Player.havePassport;
        sv.saveHaveShcoolAt = Player.haveShcoolAt;
        sv.saveHaveDiplCollage = Player.haveDiplCollage;
        sv.saveHveDiplVus = Player.haveDiplVus;
        sv.saveHaveMagistr = Player.haveMagistr;
        //����
        sv.saveEx = Player.ex;
        sv.saveLvl = Player.lvl;
        sv.saveOldlvl = Player.oldlvl;
        sv.saveNextExpLvl = Player.nextExpLvl;
        sv.saveTotalSkillPoint = Player.totalSkillPoint;
        sv.saveFreeSkillPoint = Player.freeSkillPoint;
        //������
        //����-�����
        sv.saveHaveGarden = Player.haveGarden;
        sv.saveEatOnWeek = Player.EatOnWeek;
        sv.saveEatOnMonth = Player.EatOnMonth;
        sv.saveLvlSubForHealth = Player.lvlSubForHealth;
        sv.saveLvlSubForHapiness = Player.lvlSubForHapiness;
        //����������
        //��������
        sv.saveCountBottle = Player.countBottle;
        sv.savePriceBottle = Player.priceBottle;
        sv.saveCountBerries = Player.countBerries;
        sv.savePriceBerries = Player.priceBerries;
        sv.saveCountCopper = Player.countCopper;
        sv.savePriceCopper = Player.priceCopper;
        sv.saveCountElectronics = Player.countElectronics;
        sv.savePriceElectronics = Player.priceElectronics;
        //������
        sv.saveMoneyPercentForBD = Player.moneyPercentForBD;
        sv.saveDeathBool = Player.DeathBool;
        //��������� ����������
        sv.saveRememberDaysOne = Player.RememberDaysOne; //��� ��� ����
        sv.saveRememberDaysTwo = Player.RememberDaysTwo; //��� ��������
        //�����
        sv.saveCountPromotio = Player.CountPromotio;//������ ����� ������
    }
}


[Serializable]
public class Save
{
    //��������
    public string saveName;
    public int saveDayB;//�� 365
    public int saveDataDayB;//���� � ������ ��
    public int saveMonthB;
    public int saveYearB;
    public int saveYearsOld;
    //���������
    public int saveEyes;
    public int saveHair;
    public int saveColorhair;
    public int saveHead;
    public int saveMouth;
    public int saveNose;
    public int saveBeard;
    //�����
    public int saveSailty;
    public int saveHealth;
    public int saveHappiness;
    public int saveMaxSailty;
    public int saveMaxHealth;
    public int savemaxHappiness;
    //������
    public int savePower;
    public int savePowerNav;
    public int saveIntellect;
    public int saveIntelNav;
    public int saveHandAggility;
    public int saveHandAggNav;

    public int saveReputation;
    public int saveLvlBread;
    public int saveMotivation;
    //����� � ����������
    public int saveCurActionDay;//������� �������� 1/3
    public int saveCounterActionsDay;//������� ��������
    public int saveCurDay;//������� ����
    public int saveDataInMounth;//���� � ������
    public int saveTotalDaysInGame;//����� ���� � ����
    public int saveCurYears;//������� ���
    public int saveCurMonth;//������� �����
    public string saveCurNameMonth;//�������� �������� ������
    public string saveCurNameSeason;//�������� �������� ������
    //��������� ��������
    public int saveMoney;
    public int saveTotalMoney;
    public int saveTempMoney;
    //��������� �����
    public bool saveHaveTent;
    public bool saveBrokenCar;
    public bool saveHaveGarage;
    public bool saveHaveApartment;
    public bool saveHaveHouse;
    public int saveLvlComfort;
    //��������� ��������
    public int saveShoes;
    public int saveShoesWear;
    public int saveClothes;
    public int saveClothesWear;
    public bool saveFridge;
    public bool saveHaveSmartphone;
    public bool saveHaveComputer;
    //���������
    public bool saveHavePassport;
    public bool saveHaveShcoolAt;
    public bool saveHaveDiplCollage;
    public bool saveHveDiplVus;
    public bool saveHaveMagistr;
    //����
    public int saveEx;
    public int saveLvl;
    public int saveOldlvl;
    public float saveNextExpLvl;
    public int saveTotalSkillPoint;
    public int saveFreeSkillPoint;
    //������
    //����-�����
    public int saveHaveGarden;
    public int saveEatOnWeek;
    public int saveEatOnMonth;
    public int saveLvlSubForHealth;
    public int saveLvlSubForHapiness;
    //����������
    //��������
    public int saveCountBottle;
    public int savePriceBottle;
    public int saveCountBerries;
    public int savePriceBerries;
    public int saveCountCopper;
    public int savePriceCopper;
    public int saveCountElectronics;
    public int savePriceElectronics;
    //������
    public int saveMoneyPercentForBD;
    public bool saveDeathBool;
    //��������� ����������
    public int saveRememberDaysOne; //��� ��� ����
    public int saveRememberDaysTwo; //��� ��������
    //�����
    public int[] saveCountPromotio = new int[5];//������ ����� ������
}
