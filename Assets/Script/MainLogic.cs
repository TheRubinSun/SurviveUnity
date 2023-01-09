using System.Collections;
using System.Collections.Generic;
using System.Web;
using UnityEngine;
using static CheckEvents;

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
        ExpCouned();
        LvlUP();
        
        
    }
    static int DayInMonth;
    public static void ThisMounth()
    {
        //=====================================================================================================================================
        //Определение месяца
        if (Player.CurDay < 32)//Январь 31
        {
            Player.CurMonth = 1;
            Player.DataInMounth = Player.CurDay;
            Player.CurNameSeason = "Зима";
        }
        else if (Player.CurDay > 31 && Player.CurDay <= 59)//Февраль 28
        {
            Player.CurMonth = 2;
            Player.DataInMounth = Player.CurDay - 31;
            Player.CurNameSeason = "Зима";
        }
        else if (Player.CurDay > 59 && Player.CurDay <= 90)//Март 31
        {
            Player.CurMonth = 3;
            Player.DataInMounth = Player.CurDay - 59;
            Player.CurNameSeason = "Весна";
        }
        else if (Player.CurDay > 90 && Player.CurDay <= 120)//Апрель 30
        {
            Player.CurMonth = 4;
            Player.DataInMounth = Player.CurDay - 90;
            Player.CurNameSeason = "Весна";
        }
        else if (Player.CurDay > 120 && Player.CurDay <= 151)//Май 31
        {
            Player.CurMonth = 5;
            Player.DataInMounth = Player.CurDay - 120;
            Player.CurNameSeason = "Весна";
        }
        else if (Player.CurDay > 151 && Player.CurDay <= 181)//Июнь 30
        {
            Player.CurMonth = 6;
            Player.DataInMounth = Player.CurDay - 151;
            Player.CurNameSeason = "Лето";
        }
        else if (Player.CurDay > 181 && Player.CurDay <= 213)//Июль 31
        {
            Player.CurMonth = 7;
            Player.DataInMounth = Player.CurDay - 181;
            Player.CurNameSeason = "Лето";
        }
        else if (Player.CurDay > 213 && Player.CurDay <= 243)//Август 31
        {
            Player.CurMonth = 8;
            Player.DataInMounth = Player.CurDay - 213;
            Player.CurNameSeason = "Лето";
        }
        else if (Player.CurDay > 243 && Player.CurDay <= 273)//Сентябрь 30
        {
            Player.CurMonth = 9;
            Player.DataInMounth = Player.CurDay - 243;
            Player.CurNameSeason = "Осень";
        }
        else if (Player.CurDay > 273 && Player.CurDay <= 304)//Октябрь 31
        {
            Player.CurMonth = 10;
            Player.DataInMounth = Player.CurDay - 273;
            Player.CurNameSeason = "Осень";
        }
        else if (Player.CurDay > 304 && Player.CurDay <= 334)//Ноябрь 30 
        {
            Player.CurMonth = 11;
            Player.DataInMounth = Player.CurDay - 304;
            Player.CurNameSeason = "Осень";
        }
        else if (Player.CurDay > 334 && Player.CurDay <= 365)//Декабрь 31
        {
            Player.CurMonth = 12;
            Player.DataInMounth = Player.CurDay - 334;
            Player.CurNameSeason = "Зима";
        }
        ///ДР
        if (Player.dayB < 32)
        {
            Player.dataDayB = Player.dayB;
            Player.monthB = 1;
        }
        else if (Player.dayB > 31 && Player.dayB <= 59)//Февраль 28
        {
            Player.dataDayB = Player.dayB-31;
            Player.monthB = 2;
        }
        else if (Player.dayB > 59 && Player.dayB <= 90)//Март 31
        {
            Player.dataDayB = Player.dayB-59;
            Player.monthB = 3;
        }
        else if (Player.dayB > 90 && Player.dayB <= 120)//Апрель 30
        {
            Player.dataDayB = Player.dayB-90;
            Player.monthB = 4;
        }
        else if (Player.dayB > 120 && Player.dayB <= 151)//Май 31
        {
            Player.dataDayB = Player.dayB-120;
            Player.monthB = 5;
        }
        else if (Player.dayB > 151 && Player.dayB <= 181)//Июнь 30
        {
            Player.dataDayB = Player.dayB-151;
            Player.monthB = 6;
        }
        else if (Player.dayB > 181 && Player.dayB <= 213)//Июль 31
        {
            Player.dataDayB = Player.dayB-181;
            Player.monthB = 7;
        }
        else if (Player.dayB > 213 && Player.dayB <= 243)//Август 31
        {
            Player.dataDayB = Player.dayB-213;
            Player.monthB = 8;
        }
        else if (Player.dayB > 243 && Player.dayB <= 273)//Сентябрь 30
        {
            Player.dataDayB = Player.dayB-243;
            Player.monthB = 9;
        }
        else if (Player.dayB > 273 && Player.dayB <= 304)//Октябрь 31
        {
            Player.dataDayB = Player.dayB-273;
            Player.monthB = 10;
        }
        else if (Player.dayB > 304 && Player.dayB <= 334)//Ноябрь 30 
        {
            Player.dataDayB = Player.dayB-304;
            Player.monthB = 11;
        }
        else if (Player.dayB > 334 && Player.dayB <= 365)//Декабрь 31
        {
            Player.dataDayB = Player.dayB-334;
            Player.monthB = 12;
        }
        Player.CurNameMonth = NameMonth(Player.CurMonth);
    }
    //=====================================================================================================================================
    //Название месяца
    public static string NameMonth(int month)
    {
        string namemonth;
        switch (month)
        {
            case 1:
                { namemonth = "Январь"; break; }
            case 2:
                { namemonth = "Февраль"; break; }
            case 3:
                { namemonth = "Март"; break; }
            case 4:
                { namemonth = "Апрель"; break; }
            case 5:
                { namemonth = "Май"; break; }
            case 6:
                { namemonth = "Июнь"; break; }
            case 7:
                { namemonth = "Июль"; break; }
            case 8:
                { namemonth = "Август"; break; }
            case 9:
                { namemonth = "Сентябрь"; break; }
            case 10:
                { namemonth = "Октябрь"; break; }
            case 11:
                { namemonth = "Ноябрь"; break; }
            case 12:
                { namemonth = "Декабрь"; break; }
            default:
                { namemonth = "Error";break;}
        }
        return namemonth;
    }
    //=====================================================================================================================================
    //Предел потребностей
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
        if (Player.happiness > Player.maxHappiness)
        {
            Player.happiness = Player.maxHappiness;
        }
    }
    //=====================================================================================================================================
    //Новый год
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
    //Время дня
    void TimdeDay()
    {
        if(Player.CurActionDay >= 3)
        {
            Player.CurActionDay -= 3;
            Player.TotalDaysInGame++;
            Player.CurDay++;


            //Ежедневные изменения
            Player.priceBottle = Random.Range(2, 9);
            Player.priceBerries = Random.Range(100, 400);
            Player.priceCopper = Random.Range(250, 401);
            Player.priceElectronics = Random.Range(500, 1000);

            if (Player.haveGarden > 0 && Player.sailty < Player.maxSailty)//Если есть огород
            {
                Player.sailty += Player.haveGarden * 3;//3 * на кол-во огородов за 1 день
            }
            if (Player.lvlBread < 6) Player.lvlBread++;

            if (Player.EatSubOnDay > 0 && Player.sailty < Player.maxSailty)
            {
                Player.sailty += 50;
                Player.EatSubOnDay--;
            }

            for(int i = 0;i<Player.actions.Length;i++)
            {
                Player.actions[i].Cost = Invest.NewPrice(Player.actions[i].Cost);
            }
            if(Player.reloadingDaysCoal>0)
            {
                Player.reloadingDaysCoal--;
            }
            if (Player.reloadingDaysVitamins > 0)
            {
                Player.reloadingDaysVitamins--;
            }
        }
        
    }

    //=====================================================================================================================================
    //Подсчет всех денег
    
    void CountedMoney()
    {
        /*
        if(Player.money > Player.tempMoney)
        {
            Player.totalMoney += Player.money - Player.tempMoney; //Разницу прироста
            Player.tempMoney = Player.money;//Равняем
        }
        else
        {
            Player.tempMoney = Player.money;//Если деньги потратили
        }
        */
    }
    //=====================================================================================================================================
    //Подсчет всех действий
    void CounterActDay()
    {
        Player.CounterActionsDay = (Player.TotalDaysInGame-1) * 3 + Player.CurActionDay;
    }
    //=====================================================================================================================================
    //День рождения персонажа
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
        //LvlUP();
    }
    public static event Delagate EventLvlUp;
    public static bool pumpedUp = false;
    void LvlUP()
    {
        if(Player.ex >= Player.nextExpLvl)
        {
            Player.lvl++;
            Player.ex -= (int)Player.nextExpLvl;
            Player.nextExpLvl = (int)(Player.nextExpLvl + (Player.nextExpLvl * 1.2f));
        }
        if(Player.lvl > Player.oldlvl)
        {
            Player.freeSkillPoint++;
            Player.oldlvl++;
        }
        if (Player.freeSkillPoint > 0)//Если есть скиллПоинты то прокачка талантов
        {
            if(pumpedUp == false)
            {
                EventLvlUp.Invoke();
                
                pumpedUp = true;
            }
            
            //LvlUP();
            //WindowsWait();
        }

    }

    //=====================================================================================================================================
    //Создание персонажа 
    
    static string CreateRandomNameAction()
    {
        string nameAction = "";
        string[] arrayFirstName = new string[] { "Вне зоны", "Рик","The зад","Galaxy","Mable","Bouble","Pocket","Smart","Brother"};
        string[] arraySecondName = new string[] { "Tea", "и Морти","Экспресс","Imperia","и яиц","Edition","and sister"};
        nameAction += arrayFirstName[Random.Range(0, arrayFirstName.Length)];
        nameAction += " ";
        nameAction += arraySecondName[Random.Range(0, arraySecondName.Length)];
        return nameAction;
    }
    static int SetCostAction(int action)
    {
        if (action != 0) return (int)(Player.actions[action - 1].Cost * Random.Range(1.3f, 1.7f));
        else return Random.Range(55, 75);
    }
    
    public static List<Player> players = new List<Player>();
    public static void CreatePlayer(string name,int eyes,int hair,int colorhair,int face,int mounth,int noise, int beard)
    {
        int money = 800;
        int dayB = Random.Range(1, 365);
        int curDay = dayB;
        //int monthB = ;
        int yearB = 1980;
        int yearsOld = Player.CurYears-yearB;
        if (name == "g919g")
            players.Add(new Player(name, dayB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard, curDay, 9999999,100,100,100,10000000));
        else if(name == "God1000")
            players.Add(new Player(name, dayB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard, curDay, money, 1000, 1000, 1000,0));
        else if (name == "GTitanG")
            players.Add(new Player(name, dayB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard, curDay, 9999999, 1000, 1000, 1000, 10000000));
        else
            players.Add(new Player(name, dayB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard, curDay, money,100,100,100,0));
        //Player player = new Player(name,dayB, monthB, yearB, yearsOld, eyes, hair, colorhair, face, mounth, noise, beard,curDay, money);
        for(int i = 0; i < Player.actions.Length;i++)
        {
            Player.actions[i] = new Action(CreateRandomNameAction(), SetCostAction(i));
        }
    }
}
