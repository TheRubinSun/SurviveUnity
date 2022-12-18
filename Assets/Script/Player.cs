using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //��������
    public static string name = "";
    public static int dayB;//�� 365
    public static int dataDayB;//���� � ������ ��
    public static int monthB;
    public static int yearB;
    public static int yearsOld;
    //���������
    public static int eyes;
    public static int hair;
    public static int colorhair;
    public static int head;
    public static int mouth;
    public static int nose;
    public static int beard;
    //�����
    public static int sailty;
    public static int health;
    public static int hapiness;
    public static int maxSailty;
    public static int maxHealth;
    public static int maxHapiness;
    //������
    public static int power;
    public static int powerNav;
    public static int intellect;
    public static int intelNav;
    public static int handAggility;
    public static int handAggNav;


    public static int reputation;
    public static int lvlBread;
    public static int motivation;
    //����� � ����������
    public static int CurActionDay;//������� �������� 1/3
    public static int CounterActionsDay;//������� ��������
    public static int CurDay;//������� ����
    public static int DataInMounth;//���� � ������
    public static int TotalDaysInGame;//����� ���� � ����
    public static int CurYears;//������� ���
    public static int CurMonth;//������� �����
    public static string CurNameMonth;//�������� �������� ������
    public static string CurNameSeason;//�������� �������� ������
    //��������� ��������
    public static int money;
    public static int totalMoney;
    public static int tempMoney;
    //��������� �����
    public static bool haveTent;
    public static bool haveGarage;
    public static bool haveSmallApartment;
    public static bool haveBigApartment;
    public static bool haveHouse;
    public static int lvlComfort;
    //��������� ��������
    public static bool haveSmartphone;
    public static bool haveComputer;
    //���������
    public static bool havePassport;
    public static bool haveShcoolAt;
    public static bool haveDiplCollage;
    public static bool haveDiplVus;
    public static bool haveMagistr;
    //����
    public static int ex;
    public static int lvl;
    public static int oldlvl;
    public static float nextExpLvl;
    public static int totalSkillPoint;
    public static int freeSkillPoint;
    //������
    //����-�����
    public static int haveGarden;
    public static int lvlSubForEat;
    public static int lvlSubForHealth;
    public static int lvlSubForHapiness;
    //����������
    //��������
    public static int countBottle;
    public static int countBerries;
    public static int countCopper;
    public static int countElectronics;
    //������
    public static int moneyForBD;
    public static bool DeathBool;
    //��������� ����������
    public static int RememberDaysOne; //��� ��� ����
    public static int RememberDaysTwo; //��� ��������
    //�����
    public static int [] CountPromotio = new int[5];//������ ����� ������


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
        //��������
        {
            name = name_;
            dayB = dayB_;
            monthB = 0;
            yearB = yearB_;
            yearsOld = yearsOld_;
        }
        //���������
        {
            eyes = eyes_;
            hair = hair_;
            colorhair = colorhair_;
            head = head_;
            mouth = mouth_;
            nose = nose_;
            beard = beard_;
        }
        //�����
        {
            sailty = 100;
            health = 100;
            hapiness = 100;
            maxSailty = 100;
            maxHealth = 100;
            maxHapiness = 100;
        }
        //������
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
        //����� � ����������
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
        //��������� ��������
        {
            money = money_;
            totalMoney = 0;
            tempMoney = money_;
        }
        //��������� �����
        {
            haveTent = false;
            haveGarage = false;
            haveSmallApartment = false;
            haveBigApartment = false;
            haveHouse = false;

            lvlComfort = 0;
        }
        //��������� ��������
        {
            haveSmartphone = false;
            haveComputer = false;
        }
        //���������
        {
            havePassport = false;
            haveShcoolAt = false;
            haveDiplCollage = false;
            haveDiplVus = false;
            haveMagistr = false;

        }
        //����
        {
            ex = 0;
            lvl = 1;
            oldlvl = 1;
            nextExpLvl = 100;
            totalSkillPoint = 0;
            freeSkillPoint = 0;
        }
        //������
        {

        }
        //����-�����
        {
            haveGarden = 0;
            lvlSubForEat = 0;
            lvlSubForHealth = 0;
            lvlSubForHapiness = 0;

        }
        //����������
        {

        }
        //��������
        {
            countBottle = 0;
            countBerries = 0;
            countCopper = 0;
            countElectronics = 0;
        }
        //������
        {
            moneyForBD = 10;//������ �� ���� ��������
            DeathBool = true;//��� ��������
        }
        //��������� ����������
        {
            RememberDaysOne = -3;//��� ��� ����
            RememberDaysTwo = -3;//��� ��������
        }
        //�����
        {
            CountPromotio = new int[5];//������ ����� ������
        }

        
    }
}
