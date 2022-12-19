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
        if (File.Exists(path))//��� �������� ��������� ���� �� ����
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));//��������� ��� ������ 
            Load();
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
        Player.name = sv.saveName;
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
        Player.hapiness = sv.saveHapiness;
        Player.maxSailty = sv.saveMaxSailty;
        Player.maxHealth = sv.saveMaxHealth;
        Player.maxHapiness = sv.saveMaxHapiness;
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
        Player.haveGarage = sv.saveHaveGarage;
        Player.haveSmallApartment = sv.saveHaveSmallApartment;
        Player.haveBigApartment = sv.saveHaveBigApartment;
        Player.haveHouse = sv.saveHaveHouse;
        Player.lvlComfort = sv.saveLvlComfort;
        //��������� ��������
        Player.haveSmartphone = sv.saveHaveSmartphone;
        Player.haveComputer = sv.saveHaveComputer;
        //���������
        Player.havePassport = sv.saveHavePassport;
        Player.haveShcoolAt = sv.saveHaveShcoolAt;
        Player.haveDiplCollage = sv.saveHaveDiplCollage;
        Player.haveDiplVus = sv.saveHveDiplVus;
        Player.haveMagistr = sv.saveHaveMagistr;
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
        Player.lvlSubForEat = sv.saveLvlSubForEat;
        Player.lvlSubForHealth = sv.saveLvlSubForHealth;
        Player.lvlSubForHapiness = sv.saveLvlSubForHapiness;
        //����������
        //��������
        Player.countBottle = sv.saveCountBottle;
        Player.countBerries = sv.saveCountBerries;
        Player.countCopper = sv.saveCountCopper;
        Player.countElectronics = sv.saveCountElectronics;
        //������
        Player.moneyForBD = sv.saveMoneyForBD;
        Player.DeathBool = sv.saveDeathBool;
        //��������� ����������
        Player.RememberDaysOne = sv.saveRememberDaysOne; //��� ��� ����
        Player.RememberDaysTwo = sv.saveRememberDaysTwo; //��� ��������
                                                         //�����
        Player.CountPromotio = sv.saveCountPromotio;//������ ����� ������


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
        public int saveHapiness;
        public int saveMaxSailty;
        public int saveMaxHealth;
        public int saveMaxHapiness;
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
        public bool saveHaveGarage;
        public bool saveHaveSmallApartment;
        public bool saveHaveBigApartment;
        public bool saveHaveHouse;
        public int saveLvlComfort;
        //��������� ��������
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
        public int saveLvlSubForEat;
        public int saveLvlSubForHealth;
        public int saveLvlSubForHapiness;
        //����������
        //��������
        public int saveCountBottle;
        public int saveCountBerries;
        public int saveCountCopper;
        public int saveCountElectronics;
        //������
        public int saveMoneyForBD;
        public bool saveDeathBool;
        //��������� ����������
        public int saveRememberDaysOne; //��� ��� ����
        public int saveRememberDaysTwo; //��� ��������
                                        //�����
        public int[] saveCountPromotio = new int[5];//������ ����� ������
    }
}
