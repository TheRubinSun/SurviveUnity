using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    public void Start()
    {
        AllUpdate();
    }
    private void OnEnable()
    {
        ActionsButtons.OneAction += AllUpdate;
    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= AllUpdate;
    }
    public void AllUpdate()
    {
        //Player.CurMonth = ThisMounth(Player.CurDay);
        ThisMounth();
        MaxNeeds();
        DayCycle();
        TimdeDay();
        CountedMoney();
        CounterActDay();
        LvlUP();
        ExpCouned();
        
    }
    static int DayInMonth;
    public static void ThisMounth()
    {
        //=====================================================================================================================================
        //����������� ������
        if (Player.CurDay < 32)//������ 31
        {
            Player.CurMonth = 1;
            Player.DataInMounth = Player.CurDay;
            Player.CurNameSeason = "����";
        }
        else if (Player.CurDay > 31 && Player.CurDay <= 59)//������� 28
        {
            Player.CurMonth = 2;
            Player.DataInMounth = Player.CurDay - 31;
            Player.CurNameSeason = "����";
        }
        else if (Player.CurDay > 59 && Player.CurDay <= 90)//���� 31
        {
            Player.CurMonth = 3;
            Player.DataInMounth = Player.CurDay - 59;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 90 && Player.CurDay <= 120)//������ 30
        {
            Player.CurMonth = 4;
            Player.DataInMounth = Player.CurDay - 90;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 120 && Player.CurDay <= 151)//��� 31
        {
            Player.CurMonth = 5;
            Player.DataInMounth = Player.CurDay - 120;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 151 && Player.CurDay <= 181)//���� 30
        {
            Player.CurMonth = 6;
            Player.DataInMounth = Player.CurDay - 151;
            Player.CurNameSeason = "����";
        }
        else if (Player.CurDay > 181 && Player.CurDay <= 213)//���� 31
        {
            Player.CurMonth = 7;
            Player.DataInMounth = Player.CurDay - 181;
            Player.CurNameSeason = "����";
        }
        else if (Player.CurDay > 213 && Player.CurDay <= 243)//������ 31
        {
            Player.CurMonth = 8;
            Player.DataInMounth = Player.CurDay - 213;
            Player.CurNameSeason = "����";
        }
        else if (Player.CurDay > 243 && Player.CurDay <= 273)//�������� 30
        {
            Player.CurMonth = 9;
            Player.DataInMounth = Player.CurDay - 243;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 273 && Player.CurDay <= 304)//������� 31
        {
            Player.CurMonth = 10;
            Player.DataInMounth = Player.CurDay - 273;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 304 && Player.CurDay <= 334)//������ 30 
        {
            Player.CurMonth = 11;
            Player.DataInMounth = Player.CurDay - 304;
            Player.CurNameSeason = "�����";
        }
        else if (Player.CurDay > 334 && Player.CurDay <= 365)//������� 31
        {
            Player.CurMonth = 12;
            Player.DataInMounth = Player.CurDay - 334;
            Player.CurNameSeason = "����";
        }
        ///��
        if (Player.dayB < 32)
        {
            Player.dataDayB = Player.dayB;
            Player.monthB = 1;
        }
        else if (Player.dayB > 31 && Player.dayB <= 59)//������� 28
        {
            Player.dataDayB = Player.dayB-31;
            Player.monthB = 2;
        }
        else if (Player.dayB > 59 && Player.dayB <= 90)//���� 31
        {
            Player.dataDayB = Player.dayB-59;
            Player.monthB = 3;
        }
        else if (Player.dayB > 90 && Player.dayB <= 120)//������ 30
        {
            Player.dataDayB = Player.dayB-90;
            Player.monthB = 4;
        }
        else if (Player.dayB > 120 && Player.dayB <= 151)//��� 31
        {
            Player.dataDayB = Player.dayB-120;
            Player.monthB = 5;
        }
        else if (Player.dayB > 151 && Player.dayB <= 181)//���� 30
        {
            Player.dataDayB = Player.dayB-151;
            Player.monthB = 6;
        }
        else if (Player.dayB > 181 && Player.dayB <= 213)//���� 31
        {
            Player.dataDayB = Player.dayB-181;
            Player.monthB = 7;
        }
        else if (Player.dayB > 213 && Player.dayB <= 243)//������ 31
        {
            Player.dataDayB = Player.dayB-213;
            Player.monthB = 8;
        }
        else if (Player.dayB > 243 && Player.dayB <= 273)//�������� 30
        {
            Player.dataDayB = Player.dayB-243;
            Player.monthB = 9;
        }
        else if (Player.dayB > 273 && Player.dayB <= 304)//������� 31
        {
            Player.dataDayB = Player.dayB-273;
            Player.monthB = 10;
        }
        else if (Player.dayB > 304 && Player.dayB <= 334)//������ 30 
        {
            Player.dataDayB = Player.dayB-304;
            Player.monthB = 11;
        }
        else if (Player.dayB > 334 && Player.dayB <= 365)//������� 31
        {
            Player.dataDayB = Player.dayB-334;
            Player.monthB = 12;
        }
        Player.CurNameMonth = NameMonth(Player.CurMonth);
    }
    //=====================================================================================================================================
    //�������� ������
    public static string NameMonth(int month)
    {
        string namemonth;
        switch (month)
        {
            case 1:
                { namemonth = "������"; break; }
            case 2:
                { namemonth = "�������"; break; }
            case 3:
                { namemonth = "����"; break; }
            case 4:
                { namemonth = "������"; break; }
            case 5:
                { namemonth = "���"; break; }
            case 6:
                { namemonth = "����"; break; }
            case 7:
                { namemonth = "����"; break; }
            case 8:
                { namemonth = "������"; break; }
            case 9:
                { namemonth = "��������"; break; }
            case 10:
                { namemonth = "�������"; break; }
            case 11:
                { namemonth = "������"; break; }
            case 12:
                { namemonth = "�������"; break; }
            default:
                { namemonth = "Error";break;}
        }
        return namemonth;
    }
    //=====================================================================================================================================
    //������ ������������
    void MaxNeeds()
    {
        if (Player.sailty > Player.maxSailty)
        {
            Player.sailty = Player.maxSailty;
        }
        if (Player.health > Player.maxHealth)
        {
            Player.health = Player.maxHealth;
        }
        if (Player.hapiness > Player.maxHapiness)
        {
            Player.hapiness = Player.maxHapiness;
        }
    }
    //=====================================================================================================================================
    //����� ���
    void DayCycle()
    {
        if(Player.CurDay<366)
        {

        }
        else
        {
            Player.CurDay -= 365;
            Player.CurYears++;
        }
    }
    //=====================================================================================================================================
    //����� ���
    void TimdeDay()
    {
        if(Player.CurActionDay >= 3)
        {
            Player.CurActionDay -= 3;
            Player.TotalDaysInGame++;
            Player.CurDay++;

            Player.priceBottle = Random.Range(2, 9);
            Player.priceBerries = Random.Range(100, 400);
            Player.priceCopper = Random.Range(250, 401);
            Player.priceElectronics = Random.Range(800, 2000);

            if (Player.haveGarden > 0 && Player.sailty < Player.maxSailty)//���� ���� ������
            {
                Player.sailty += Player.haveGarden * 3;//3 * �� ���-�� �������� �� 1 ����
            }
            if (Player.lvlBread < 6) Player.lvlBread++;
        }
        
    }

    //=====================================================================================================================================
    //������� ���� �����
    
    void CountedMoney()
    {
        /*
        if(Player.money > Player.tempMoney)
        {
            Player.totalMoney += Player.money - Player.tempMoney; //������� ��������
            Player.tempMoney = Player.money;//�������
        }
        else
        {
            Player.tempMoney = Player.money;//���� ������ ���������
        }
        */
    }
    //=====================================================================================================================================
    //������� ���� ��������
    void CounterActDay()
    {
        Player.CounterActionsDay = (Player.TotalDaysInGame-1) * 3 + Player.CurActionDay;
    }
    //=====================================================================================================================================
    //���� �������� ���������
    void HappyBirdhDay()
    {
        if(Player.TotalDaysInGame % 365 == 0)
        {
            Player.CurDay++;
            Player.TotalDaysInGame++;
            ///////////////////////////////////////
        }
    }
    void ExpCouned()
    {
        Player.ex = Player.CounterActionsDay + (Player.totalMoney/100);
    }
    static int b = 0;//������ ��� �������� �����
    static bool prov = false;
    static bool prov2 = false;
    void LvlUP()
    {
        if(Player.ex >= Player.nextExpLvl)
        {
            Player.lvl++;
            Player.ex -= (int)Player.nextExpLvl;
            Player.nextExpLvl = (int)(Player.nextExpLvl + (Player.nextExpLvl * 1.3f));
        }
        if(Player.lvl > Player.oldlvl)
        {
            Player.freeSkillPoint++;
            Player.oldlvl++;
        }
        if (Player.freeSkillPoint - Player.totalSkillPoint > b)//���� ���� ����������� �� �������� ��������
        {
            b++;
            //LvlUP();
            //WindowsWait();
        }
        if(prov == true)//������ ���� �������� �������
        {
            //Message(info);
            prov = false;
        }
    }

    //=====================================================================================================================================
    //�������� ��������� 
    public static List<Player> players = new List<Player>();
    public void CreatePlayer(string name,int eyes,int hair,int colorhair,int face,int mounth,int noise, int beard)
    {
        int money = 800;
        int dayB = Random.Range(1, 365);
        int curDay = dayB;
        //int monthB = ;
        int yearB = 1980;
        int yearsOld = Player.CurYears-yearB;
        players.Add(new Player(name, dayB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard, curDay, money));
        //Player player = new Player(name,dayB, monthB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard,curDay, money);
    }
}
