using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveAfterClose : MonoBehaviour
{

    private Save sv = new Save();
    private SaveAction svAct = new SaveAction();
    private string path;
    private string pathActions;

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
        pathActions = Application.persistentDataPath + "/SaveActions.json";
        InvokeRepeating("SaveButton", 1, 10);
    }
    private void OnApplicationPause(bool pause)//��� �������
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0 && (pause))
        {
            SaveFile();
            SaveActionFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
            File.WriteAllText(pathActions, JsonUtility.ToJson(svAct));
        }
        else
        {
            File.Delete(path);
            File.Delete(pathActions);
        }
    }

    private void OnApplicationQuit()//��� ��
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0)
        {
            SaveFile();
            SaveActionFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
            File.WriteAllText(pathActions, JsonUtility.ToJson(svAct));
        }
        else
        {
            File.Delete(path);
            File.Delete(pathActions);
        }
    }
    public void SaveButton()
    {
        if (Player.sailty > 0 && Player.health > 0 && Player.happiness > 0)
        {
            SaveFile();
            SaveActionFile();
            File.WriteAllText(path, JsonUtility.ToJson(sv));
            File.WriteAllText(pathActions, JsonUtility.ToJson(svAct));
        }
        else
        {
            File.Delete(path);
            File.Delete(pathActions);
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
        sv.savehaveSchool = Player.haveSchool;
        sv.saveHaveDiplCollage = Player.haveDiplCollage;
        sv.saveHveDiplVus = Player.haveDiplVus;
        sv.saveHaveMagistr = Player.haveMagistr;
        sv.saveHaveAspir = Player.haveAspir;
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
        sv.saveEatSubOnDay = Player.EatSubOnDay;
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
        sv.saveReloadingDaysCoal = Player.reloadingDaysCoal;
        sv.saveReloadingDaysVitamins = Player.reloadingDaysCoal;
        //��������� ����������
        sv.saveRememberDaysOne = Player.RememberDaysOne; //��� ��� ����
        sv.saveRememberDaysTwo = Player.RememberDaysTwo; //��� ��������
        //�����
        sv.saveActions = Player.actions;//������ ����� ������
        sv.act1 = Player.actions[0];
        sv.saveCountAction = Player.countAction;

        //����
        sv.savePriceShoes = Player.PriceShoes;
        sv.savePriceClothes = Player.PriceClothes;
        sv.savePriceSmartPhone = Player.PriceSmartPhone;
        sv.savePriceFridge = Player.PriceFridge;
        sv.savePriceCutBread = Player.PriceCutBread;
        sv.savePriceTent = Player.PriceTent;
        sv.savePriceBrokenCar = Player.PriceBrokenCar;
        sv.savePriceGarage = Player.PriceGarage;
        sv.savePriceApartament = Player.PriceApartament;
        sv.savePriceHouse = Player.PriceHouse;
        sv.savePricePassport = Player.PricePassport;
        sv.savePriceSchoolEd = Player.PriceSchoolEd;
        sv.savePriceColledge = Player.PriceColledge;
        sv.savePriceBakal = Player.PriceBakal;
        sv.savePriceMagis = Player.PriceMagis;
        sv.savePriceAsper = Player.PriceAsper;
    }
    public void SaveActionFile()
    {
        for(int i = 0;i<Player.actions.Length;i++)
        {
            svAct.saveName[i] = Player.actions[i].Name;
            svAct.saveCost[i] = Player.actions[i].Cost;
        }
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
    public bool savehaveSchool;
    public bool saveHaveDiplCollage;
    public bool saveHveDiplVus;
    public bool saveHaveMagistr;
    public bool saveHaveAspir;
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
    public int saveEatSubOnDay;
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
    public int saveReloadingDaysCoal;
    public int saveReloadingDaysVitamins;
    //��������� ����������
    public int saveRememberDaysOne; //��� ��� ����
    public int saveRememberDaysTwo; //��� ��������
    //�����
    public Action[] saveActions;//������ ����� ������
    public Action act1;
    public int[] saveCountAction;

    //����
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
    public string[] saveName = new string[5];
    public int[] saveCost = new int[5];
}

