using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //��������
    public static string Name { get;set;}
    public static int dayB { get; set; }//�� 365
    public static int dataDayB { get;set;}//���� � ������ ��
    public static int monthB { get; set; }
    public static int yearB { get; set; }
    public static int yearsOld { get; set; }
    //���������
    public static int eyes { get; set; }
    public static int hair { get; set; }
    public static int colorhair { get; set; }
    public static int head { get; set; }
    public static int mouth { get; set; }
    public static int nose { get; set; }
    public static int beard { get; set; }
    //�����
    public static int sailty { get; set; }
    public static int health { get; set; }
    public static int happiness { get; set; }
    public static int maxSailty { get; set; }
    public static int maxHealth { get; set; }
    public static int maxHappiness { get; set; }
    //������
    public static int power { get; set; }
    public static int powerNav { get; set; }
    public static int intellect { get; set; }
    public static int intelNav { get; set; }
    public static int handAggility { get; set; }
    public static int handAggNav { get; set; }


    public static int reputation { get; set; }
    public static int lvlBread { get; set; }
    public static int motivation { get; set; }
    //����� � ����������
    public static int CurActionDay { get; set; }//������� �������� 1/3
    public static int CounterActionsDay { get; set; }//������� ��������
    public static int CurDay { get; set; }//������� ����
    public static int DataInMounth { get; set; }//���� � ������
    public static int TotalDaysInGame { get; set; }//����� ���� � ����
    public static int CurYears { get; set; }//������� ���
    public static int CurMonth { get; set; }//������� �����
    public static string CurNameMonth { get; set; }//�������� �������� ������
    public static string CurNameSeason { get; set; }//�������� �������� ������
    //��������� ��������
    public static int money { get; set; }
    public static int totalMoney { get; set; }
    public static int tempMoney { get; set; }
    //��������� �����
    public static bool haveTent { get; set; }
    public static bool BrokenCar { get; set; }
    public static bool haveGarage { get; set; }
    public static bool haveApartment { get; set; }
    public static bool haveHouse { get; set; }
    public static int lvlComfort { get; set; }
    //��������� ��������
    public static int Shoes { get; set;}
    public static int ShoesWear { get; set; }
    public static int Clothes { get; set; }
    public static int ClothesWear { get; set; }
    public static bool haveSmartphone { get;set;}
    public static bool Fridge { get; set; }
    public static bool haveComputer { get;set;}
    //���������
    public static bool havePassport { get;set;}
    public static bool haveSchool { get;set;}
    public static bool haveDiplCollage { get;set;}
    public static bool haveDiplVus { get;set;}
    public static bool haveMagistr { get;set;}
    public static bool haveAspir { get; set; }
    //����
    public static int ex { get;set;}
    public static int lvl { get;set;}
    public static int oldlvl { get;set;}
    public static float nextExpLvl { get;set;}
    public static int totalSkillPoint { get;set;}
    public static int freeSkillPoint { get;set;}
    //������
    //����-�����
    public static int haveGarden { get;set;}
    public static int EatSubOnDay { get;set;}
    public static int lvlSubForHealth { get;set;}
    public static int lvlSubForHapiness { get;set;}
    //����������
    //��������
    public static int countBottle { get;set;}
    public static int priceBottle { get; set; }
    public static int countBerries { get;set;}
    public static int priceBerries { get; set; }
    public static int countCopper { get;set;}
    public static int priceCopper { get; set; }
    public static int countElectronics { get;set;}
    public static int priceElectronics { get; set; }
    //������
    public static int moneyPercentForBD { get;set;}
    public static bool DeathBool { get;set;}
    public static int reloadingDaysCoal { get;set;}
    public static int reloadingDaysVitamins { get;set;}
    //��������� ����������
    public static int RememberDaysOne { get;set;} //��� ��� ����
    public static int RememberDaysTwo { get;set;} //��� ��������
    //�����

    public static Action [] actions { get; set; }//������ ����� ������
    public static int[] countAction { get; set; }//����� � ������


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
        //��������
        {
            Name = name_;
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
            happiness = 100;
            maxSailty = 100;
            maxHealth = 100;
            maxHappiness = 100;
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
            BrokenCar = false;
            haveGarage = false;
            haveApartment = false;
            haveApartment = false;
            haveHouse = false;

            lvlComfort = 0;
        }
        //��������� ��������
        {
            Shoes = 0;
            ShoesWear = 0;
            Clothes = 0;
            ClothesWear = 0;
            Fridge = false;
            haveSmartphone = false;
            haveComputer = false;
        }
        //���������
        {
            havePassport = false;
            haveSchool = false;
            haveDiplCollage = false;
            haveDiplVus = false;
            haveMagistr = false;
            haveAspir = false;

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
            EatSubOnDay = 0;
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
            moneyPercentForBD = 5;//������ �� ���� ��������
            DeathBool = true;//��� ��������
            reloadingDaysCoal = 0;
            reloadingDaysVitamins = 0;
        }
        //��������� ����������
        {
            RememberDaysOne = -3;//��� ��� ����
            RememberDaysTwo = -3;//��� ��������
        }
        //�����
        {
            actions = new Action[5];//������ ����� ������
            countAction = new int[5];
        }
    }
}
