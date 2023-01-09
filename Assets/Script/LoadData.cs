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
        if (File.Exists(path))//��� �������� ��������� ���� �� ����
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));//��������� ��� ������ 
            svAct = JsonUtility.FromJson<SaveAction>(File.ReadAllText(pathActions));//��������� ��� ������ 
            Load();
            LoadAction();
            SceneManager.LoadScene("Street");
        }
        else//���� ����� ����
        {
            SceneManager.LoadScene("CreatePlayer");
        }
    }
    public void Load()
    {
        //��������
        Player.Name = sv.saveName;
        Player.dayB = sv.saveDayB;//�� 365
        Player.dataDayB = sv.saveDataDayB;//���� � ������ ��
        Player.monthB = sv.saveMonthB;
        Player.yearB = sv.saveYearB;
        Player.yearsOld = sv.saveYearsOld;
        //���������
        Player.eyes = sv.saveEyes;
        Player.hair = sv.saveHair;
        Player.colorhair = sv.saveColorhair;
        Player.head = sv.saveHead;
        Player.mouth = sv.saveMouth;
        Player.nose = sv.saveNose;
        Player.beard = sv.saveBeard;
        //�����
        Player.sailty = sv.saveSailty;
        Player.health = sv.saveHealth;
        Player.happiness = sv.saveHappiness;
        Player.maxSailty = sv.saveMaxSailty;
        Player.maxHealth = sv.saveMaxHealth;
        Player.maxHappiness = sv.savemaxHappiness;
        //������
        Player.power = sv.savePower;
        Player.powerNav = sv.savePowerNav;
        Player.intellect = sv.saveIntellect;
        Player.intelNav = sv.saveIntelNav;
        Player.handAggility = sv.saveHandAggility;
        Player.handAggNav = sv.saveHandAggNav;


        Player.reputation = sv.saveReputation;
        Player.lvlBread = sv.saveLvlBread;
        Player.motivation = sv.saveMotivation;
        //����� � ����������
        Player.CurActionDay = sv.saveCurActionDay;//������� �������� 1/3
        Player.CounterActionsDay = sv.saveCounterActionsDay;//������� ��������
        Player.CurDay = sv.saveCurDay;//������� ����
        Player.DataInMounth = sv.saveDataInMounth;//���� � ������
        Player.TotalDaysInGame = sv.saveTotalDaysInGame;//����� ���� � ����
        Player.CurYears = sv.saveCurYears;//������� ���
        Player.mouth = sv.saveCurMonth;//������� �����
        Player.CurNameMonth = sv.saveCurNameMonth;//�������� �������� ������
        Player.CurNameSeason = sv.saveCurNameSeason;//�������� �������� ������
                                                    //��������� ��������
        Player.money = sv.saveMoney;
        Player.totalMoney = sv.saveTotalMoney;
        Player.tempMoney = sv.saveTempMoney;
        //��������� �����
        Player.haveTent = sv.saveHaveTent;
        Player.BrokenCar = sv.saveBrokenCar;
        Player.haveGarage = sv.saveHaveGarage;
        Player.haveApartment = sv.saveHaveApartment;
        Player.haveHouse = sv.saveHaveHouse;
        Player.lvlComfort = sv.saveLvlComfort;
        //��������� ��������
        Player.Shoes = sv.saveShoes;
        Player.ShoesWear = sv.saveShoesWear;
        Player.Clothes = sv.saveClothes;
        Player.ClothesWear = sv.saveClothesWear;
        Player.Fridge = sv.saveFridge;
        Player.haveSmartphone = sv.saveHaveSmartphone;
        Player.haveComputer = sv.saveHaveComputer;
        //���������
        Player.havePassport = sv.saveHavePassport;
        Player.haveSchool = sv.savehaveSchool;
        Player.haveDiplCollage = sv.saveHaveDiplCollage;
        Player.haveDiplVus = sv.saveHveDiplVus;
        Player.haveMagistr = sv.saveHaveMagistr;
        Player.haveAspir = sv.saveHaveAspir;
        //����
        Player.ex = sv.saveEx;
        Player.lvl = sv.saveLvl;
        Player.oldlvl = sv.saveOldlvl;
        Player.nextExpLvl = sv.saveNextExpLvl;
        Player.totalSkillPoint = sv.saveTotalSkillPoint;
        Player.freeSkillPoint = sv.saveFreeSkillPoint;
        //������
        //����-�����
        Player.haveGarden = sv.saveHaveGarden;
        Player.EatSubOnDay = sv.saveEatSubOnDay;
        Player.lvlSubForHealth = sv.saveLvlSubForHealth;
        Player.lvlSubForHapiness = sv.saveLvlSubForHapiness;
        //����������
        //��������
        Player.countBottle = sv.saveCountBottle;
        Player.countBerries = sv.saveCountBerries;
        Player.countCopper = sv.saveCountCopper;
        Player.countElectronics = sv.saveCountElectronics;
        Player.priceBottle = sv.savePriceBottle;
        Player.priceBerries = sv.savePriceBerries;
        Player.priceCopper = sv.savePriceCopper;
        Player.priceElectronics = sv.savePriceElectronics;
        //������
        Player.moneyPercentForBD = sv.saveMoneyForBD;
        Player.DeathBool = sv.saveDeathBool;
        Player.reloadingDaysCoal = sv.saveReloadingDaysCoal;
        Player.reloadingDaysVitamins = sv.saveReloadingDaysVitamins;
        //��������� ����������
        Player.RememberDaysOne = sv.saveRememberDaysOne; //��� ��� ����
        Player.RememberDaysTwo = sv.saveRememberDaysTwo; //��� ��������
                                                         //�����
        Player.actions = sv.saveActions;//������ ����� ������
        Player.countAction = sv.saveCountAction;

        //����
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
        public int saveMoneyForBD;
        public bool saveDeathBool;
        public int saveReloadingDaysCoal;
        public int saveReloadingDaysVitamins;
        //��������� ����������
        public int saveRememberDaysOne; //��� ��� ����
        public int saveRememberDaysTwo; //��� ��������
                                        //�����
        public Action[] saveActions;//������ ����� ������
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
        public string[] saveName;
        public int[] saveCost;
    }
}

