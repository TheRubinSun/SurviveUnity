using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaEvNeeds : MonoBehaviour
{
    public delegate void DisButtonWork();
    public static event DisButtonWork ExecuteButton;

    public Text info;
    string text;

    int cost;
    int sailty;
    int health;
    int happines;
    int reputatuion;
    int bottle;

    void Start()
    {
        
    }
    public void EatSlops()
    {
        if(Player.sailty<Player.maxSailty)
        {
            cost = 0;
            sailty = Random.Range(5, 20);
            health = Random.Range(2, 8);
            happines = Random.Range(6, 12);
            bottle = Random.Range(3, 8);
            reputatuion = Random.Range(10, 40);

            PlayerSet(0, -sailty, health, -happines, -reputatuion, bottle);
            OutputInfoEat("Вы поели помои с мусорок", 0, sailty, health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("Вы уже сыты!");
        }
    }
    public void TryToStealFood()
    {
        if (Player.sailty < Player.maxSailty)
        {
            string message = "";
            cost = 0;
            if (Random.Range(0, 3) < 1)
            {
                message = "Вам удалось украсть еду";
                sailty = Random.Range(20, 40);
                health = Random.Range(2, 4);
                happines = Random.Range(3, 8);
                reputatuion = Random.Range(10, 40);
            }
            else
            {
                message = "Вы не смогли украсть еду";
                sailty = 0;
                health = Random.Range(2, 8);
                happines = Random.Range(6, 12);
                reputatuion = Random.Range(40, 200);
            }
            bottle = 0;
            PlayerSet(0, sailty, -health, -happines,-reputatuion, bottle);
            OutputInfoEat(message, 0, sailty, health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("Вы уже сыты!");
        }
    }
    public void BrewNoodles()
    {
        if (Player.sailty < Player.maxSailty)
        {
            cost = 50;
            if (Player.money >= cost)
            {
                sailty = 15;
                health = 4;
                PlayerSet(cost, sailty, -health, 0, 0, 0);
                OutputInfoEat("Вы поели заварную лапшу", cost, sailty, -health, 0, 0, 0);
            }
            else
            {
                NoMessage($"Вам не хватает денег на ресторан\n необходимо: {cost} Моулей");
            }
        }
        else
        {
            NoMessage("Вы уже сыты!");
        }
    }
    public void BuyFastFood()
    {
        if (Player.sailty < Player.maxSailty)
        {
            cost = 250;
            if (Player.money >= cost)
            {
                sailty = 50;
                health = 1;
                happines = 15;
                PlayerSet(cost, sailty, -health, happines, 0, 0);
                OutputInfoEat("Вы поели фаст-фуд", cost, sailty, -health, happines, 0, 0);
            }
            else
            {
                NoMessage($"Вам не хватает денег на ресторан\n необходимо: {cost} Моулей");
            }
        }
        else
        {
            NoMessage("Вы уже сыты!");
        }
    }
    public void EatRestaurant()
    {
        if (Player.sailty < Player.maxSailty)
        {
            cost = 3500;
            if (Player.money >= cost)
            {
                happines = 50;
                PlayerSet(cost, Player.maxSailty, 0, happines, 0, 0);
                OutputInfoEat("Вы поели в ресторане", cost, Player.maxSailty, 0, happines, 0, 0);
            }
            else
            {
                NoMessage($"Вам не хватает денег на ресторан\n необходимо: {cost} Моулей");
            }
        }
        else
        {
            NoMessage("Вы уже сыты!");
        }
    }
    public void FoodOnWeek()
    {
        cost = 8000;
        if(Player.Fridge == true)
        {
            if(Player.money >= cost)
            {
                Player.money -= cost;
                Player.EatSubOnDay += 7;
                NoMessage($"Вы приобрели подписку на 7 дней\nТеперь у вас действует подписка в сумме на {Player.EatSubOnDay}\n-{cost} Моулей\n Вы ежедневно получаете +50 к сытости");
            }
            else
            {
                NoMessage($"Вам нехватает денег!\nНеобходимо: {cost}");
            }
        }
        else
        {
            NoMessage("Вам негде хранить еду, купите холодильник");
        }
    }
    public void FoodOnMonth()
    {
        cost = 40000;
        if (Player.Fridge == true)
        {
            if (Player.money >= cost)
            {
                Player.money -= cost;
                Player.EatSubOnDay += 31;
                NoMessage($"Вы приобрели подписку на 31 дней\nТеперь у вас действует подписка в сумме на {Player.EatSubOnDay}\n-{cost} Моулей\n Вы ежедневно получаете +50 к сытости");
            }
            else
            {
                NoMessage($"Вам нехватает денег!\nНеобходимо: {cost}");
            }
        }
        else
        {
            NoMessage("Вам негде хранить еду, купите холодильник");
        }
    }
    //===============================================================================================================
    public void HealRubbish()
    {
        if (Player.health < Player.maxHealth)
        {
            cost = 0;
            sailty = Random.Range(4, 9);
            health = Random.Range(5, 20);
            happines = Random.Range(3, 10);
            bottle = Random.Range(3, 8);
            reputatuion = Random.Range(10, 40);

            PlayerSet(0, -sailty, health, -happines,-reputatuion, bottle);
            OutputInfoEat("Вы полечились с мусорок", 0, -sailty, health, -happines, -reputatuion, bottle);
        }
        else
        {
            NoMessage("Вы уже здоровы!");
        }
    }
    public void BuyCoal()
    {
        if (Player.health < Player.maxHealth)
        {
            if(Player.reloadingDaysCoal == 0)
            {
                cost = 15;
                if (Player.money >= cost)
                {
                    sailty = Random.Range(4, 7);
                    health = 10;
                    happines = Random.Range(2, 5);
                    bottle = 0;
                    reputatuion = 0;
                    Player.reloadingDaysCoal += 3;
                    PlayerSet(cost, -sailty, health, -happines, -reputatuion, bottle);
                    OutputInfoEat("Вы съели акт. уголь", cost, -sailty, health, -happines, -reputatuion, bottle);
                }
            }
            else
            {
                NoMessage("Уголь можно принимать\nодин раз в три дня!");
            }

        }
        else
        {
            NoMessage("Вы уже здоровы!");
        }
    }
    public void BuyVitamins()
    {
        if (Player.health < Player.maxHealth)
        {
            if (Player.reloadingDaysVitamins == 0)
            {
                cost = 40;
                if (Player.money >= cost)
                {
                    sailty = 3;
                    health = 15;
                    bottle = 0;
                    reputatuion = 0;
                    Player.reloadingDaysVitamins += 3;
                    PlayerSet(cost, sailty, health, -happines, -reputatuion, bottle);
                    OutputInfoEat("Вы съели акт. уголь", cost, sailty, health, -happines, -reputatuion, bottle);
                }
            }
            else
            {
                NoMessage("Витамины можно принимать\nодин раз в три дня!");
            }

        }
        else
        {
            NoMessage("Вы уже здоровы!");
        }
    }
    public void HealingAtHealer()
    {
        if (Player.health < Player.maxHealth)
        {
            cost = 300;
            if (Player.money >= cost)
            {
                sailty = 2;
                health = 35;
                happines = Random.Range(2, 5);
                bottle = 0;
                reputatuion = 0;
                PlayerSet(cost, -sailty, health, -happines, -reputatuion, bottle);
                OutputInfoEat("Вы лечились у целителя", cost, -sailty, health, -happines, -reputatuion, bottle);
            }
        }
        else
        {
            NoMessage("Вы уже здоровы!");
        }
    }
    public void HealingHospital()
    {
        if (Player.health < Player.maxHealth)
        {
            cost = 1500;
            if (Player.money >= cost)
            {
                sailty = 0;
                health = Player.maxHealth;
                happines = 0;
                bottle = 0;
                reputatuion = 0;
                PlayerSet(cost, -sailty, health, -happines, -reputatuion, bottle);
                OutputInfoEat("Вы лечились в больнице", cost, -sailty, health, -happines, -reputatuion, bottle);
            }
        }
        else
        {
            NoMessage("Вы уже здоровы!");
        }
    }
    //===============================================================================================================
    public void PlayCarts()
    {
        if (Player.happiness < Player.maxHappiness)
        {
            cost = 0;
            sailty = -4;
            health = Random.Range(2, 4);
            happines = Random.Range(5, 20);
            bottle = Random.Range(1, 5);
            reputatuion = Random.Range(10, 30);

            PlayerSet(0, -sailty, -health, happines, reputatuion, bottle);
            OutputInfoEat("Вы поиграли в карты", 0, -sailty, -health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("Вы уже счастливы!");
        }
    }
    public void BuyJournal()
    {
        if (Player.happiness < Player.maxHappiness)
        {
            cost = 50;
            if (Player.money >= cost)
            {
                happines = 15;
                PlayerSet(cost, 0, 0, happines, 0, bottle);
                OutputInfoEat("Вы купили журнал", cost, 0, 0, happines, 0, bottle);
            }
            else
            {
                NoMessage($"Вам не хватает денег на журнал\n необходимо: {cost} Моулей");
            }
        }
        else
        {
            NoMessage("Вы уже счастливы!");
        }
    }
    public void GoToCinema()
    {
        if ((Player.happiness < Player.maxHappiness) && (Player.reputation > 5000))
        {
            cost = 200;
            if (Player.money >= cost)
            {
                happines = 50;
                reputatuion = 20;
                PlayerSet(cost, 0, 0, happines, 0, bottle);
                OutputInfoEat("Вы сходили в кино", cost, 0, 0, happines, reputatuion, bottle);
            }
            else
            {
                NoMessage($"Вам не хватает денег на кино\n необходимо: {cost} Моулей");
            }
        }
        else
        {
            if (Player.reputation < 5000)
                NoMessage("У вас слишком маленькая репутация\nНужно 5000 репутации");
            else
                NoMessage("Вы уже счастливы!");

        }
    }
    //===============================================================================================================
    void OutputInfoEat(string message,int cost, int sailty,int health,int happines,int reputation,int bottle)
    {
        string text = "";
        text += message+"\n";
        if (cost > 0) text += $"Вы потратили: {cost} Моулей\n";
        text += $"Выша сытость: {(sailty>0?'+':'-')}{sailty}";
        if (health > 0) text += $"\tВаше здоровье: {(health > 0 ? '+' : '-')}{health}\n";
        if (happines > 0) text += $"Ваше счастье: {(happines > 0 ? '+' : '-')}{happines}\n";
        if (reputation > 0) text += $"Ваша репутация: {(reputation > 0 ? '+' : '-')}{reputation}\n";
        if (bottle > 0) text += $"Вы нашли: {bottle} бутылок\n";
        info.text = text;
    }
    void NoMessage(string message)
    {
        info.text = message;
    }
    void JustMessage()
    {
        info.text = "Данное действия пока не доступно";
    }
    void PlayerSet(int money,int sailty,int health,int happines,int reputation,int bottle)
    {
        Player.money -= money;
        Player.sailty += sailty;
        Player.health += health;
        Player.happiness += happines;
        Player.reputation += reputation;
        Player.countBottle+= bottle;
        ExecuteButton.Invoke();
    }

}
