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
            health = Random.Range(-2, -8);
            happines = Random.Range(-6, -12);
            bottle = Random.Range(3, 8);
            reputatuion = Random.Range(-10, -40);

            PlayerSet(0, sailty, health, happines, reputatuion, bottle);
            OutputInfoEat("�� ����� ����� � �������", 0, sailty, health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("�� ��� ����!");
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
                message = "��� ������� ������� ���";
                sailty = Random.Range(20, 40);
                health = Random.Range(-2, -4);
                happines = Random.Range(-3, -8);
                reputatuion = Random.Range(-10, -40);
            }
            else
            {
                message = "�� �� ������ ������� ���";
                sailty = 0;
                health = Random.Range(2, 8);
                happines = Random.Range(6, 12);
                reputatuion = Random.Range(40, 200);
            }
            bottle = 0;
            PlayerSet(0, sailty, health, happines,reputatuion, bottle);
            OutputInfoEat(message, 0, sailty, health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("�� ��� ����!");
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
                health = -4;
                PlayerSet(cost, sailty, health, 0, 0, 0);
                OutputInfoEat("�� ����� �������� �����", cost, sailty, health, 0, 0, 0);
            }
            else
            {
                NoMessage($"��� �� ������� ����� �� ��������\n ����������: {cost} ������");
            }
        }
        else
        {
            NoMessage("�� ��� ����!");
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
                health = -1;
                happines = 15;
                PlayerSet(cost, sailty, health, happines, 0, 0);
                OutputInfoEat("�� ����� ����-���", cost, sailty, health, happines, 0, 0);
            }
            else
            {
                NoMessage($"��� �� ������� ����� �� ��������\n ����������: {cost} ������");
            }
        }
        else
        {
            NoMessage("�� ��� ����!");
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
                OutputInfoEat("�� ����� � ���������", cost, Player.maxSailty, 0, happines, 0, 0);
            }
            else
            {
                NoMessage($"��� �� ������� ����� �� ��������\n ����������: {cost} ������");
            }
        }
        else
        {
            NoMessage("�� ��� ����!");
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
                JustMessage($"�� ��������� �������� �� 7 ����\n������ � ��� ��������� �������� � ����� �� {Player.EatSubOnDay}\n-{cost} ������\n �� ��������� ��������� +50 � �������");
            }
            else
            {
                NoMessage($"��� ��������� �����!\n����������: {cost}");
            }
        }
        else
        {
            NoMessage("��� ����� ������� ���, ������ �����������");
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
                JustMessage($"�� ��������� �������� �� 31 ����\n������ � ��� ��������� �������� � ����� �� {Player.EatSubOnDay}\n-{cost} ������\n �� ��������� ��������� +50 � �������");
            }
            else
            {
                NoMessage($"��� ��������� �����!\n����������: {cost}");
            }
        }
        else
        {
            NoMessage("��� ����� ������� ���, ������ �����������");
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
            OutputInfoEat("�� ���������� � �������", 0, -sailty, health, -happines, -reputatuion, bottle);
        }
        else
        {
            NoMessage("�� ��� �������!");
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
                    sailty = Random.Range(-4, -7);
                    health = 10;
                    happines = Random.Range(-2, -5);
                    bottle = 0;
                    reputatuion = 0;
                    Player.reloadingDaysCoal += 3;
                    PlayerSet(cost, sailty, health, happines, reputatuion, bottle);
                    OutputInfoEat("�� ����� ���. �����", cost, sailty, health, happines, reputatuion, bottle);
                }
            }
            else
            {
                NoMessage("����� ����� ���������\n���� ��� � ��� ���!");
            }

        }
        else
        {
            NoMessage("�� ��� �������!");
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
                    PlayerSet(cost, sailty, health, happines, reputatuion, bottle);
                    OutputInfoEat("�� ����� ���. �����", cost, sailty, health, happines, reputatuion, bottle);
                }
            }
            else
            {
                NoMessage("�������� ����� ���������\n���� ��� � ��� ���!");
            }

        }
        else
        {
            NoMessage("�� ��� �������!");
        }
    }
    public void HealingAtHealer()
    {
        if (Player.health < Player.maxHealth)
        {
            cost = 300;
            if (Player.money >= cost)
            {
                sailty = -2;
                health = 35;
                happines = Random.Range(-2, -5);
                bottle = 0;
                reputatuion = 0;
                PlayerSet(cost, sailty, health, happines, reputatuion, bottle);
                OutputInfoEat("�� �������� � ��������", cost, sailty, health, happines,-reputatuion, bottle);
            }
        }
        else
        {
            NoMessage("�� ��� �������!");
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
                PlayerSet(cost, sailty, health, happines, reputatuion, bottle);
                OutputInfoEat("�� �������� � ��������", cost, sailty, health, happines, reputatuion, bottle);
            }
        }
        else
        {
            NoMessage("�� ��� �������!");
        }
    }
    //===============================================================================================================
    public void PlayCarts()
    {
        if (Player.happiness < Player.maxHappiness)
        {
            cost = 0;
            sailty = -4;
            health = Random.Range(-2, -4);
            happines = Random.Range(5, 20);
            bottle = Random.Range(1, 5);
            reputatuion = Random.Range(10, 30);

            PlayerSet(0, sailty, health, happines, reputatuion, bottle);
            OutputInfoEat("�� �������� � �����", 0, sailty, health, happines, reputatuion, bottle);
        }
        else
        {
            NoMessage("�� ��� ���������!");
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
                OutputInfoEat("�� ������ ������", cost, 0, 0, happines, 0, bottle);
            }
            else
            {
                NoMessage($"��� �� ������� ����� �� ������\n ����������: {cost} ������");
            }
        }
        else
        {
            NoMessage("�� ��� ���������!");
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
                OutputInfoEat("�� ������� � ����", cost, 0, 0, happines, reputatuion, bottle);
            }
            else
            {
                NoMessage($"��� �� ������� ����� �� ����\n ����������: {cost} ������");
            }
        }
        else
        {
            if (Player.reputation < 5000)
                NoMessage("� ��� ������� ��������� ���������\n����� 5000 ���������");
            else
                NoMessage("�� ��� ���������!");

        }
    }
    //===============================================================================================================
    void OutputInfoEat(string message,int cost, int sailty,int health,int happines,int reputation,int bottle)
    {
        string text = "";
        text += message+"\n";
        if (cost != 0) text += $"�� ���������: {cost} ������\n";
        text += $"���� �������: {(sailty>0?'+':' ')}{sailty}\n";
        if (health != 0) text += $"\t���� ��������: {(health > 0 ? '+' : ' ')}{health}\n";
        if (happines != 0) text += $"���� �������: {(happines > 0 ? '+' : ' ')}{happines}\n";
        if (reputation != 0) text += $"���� ���������: {(reputation > 0 ? '+' : ' ')}{reputation}\n";
        if (bottle != 0) text += $"�� �����: {bottle} �������\n";
        info.text = text;
    }
    void NoMessage(string message)
    {
        info.text = message;
    }
    void JustMessage(string message)
    {
        info.text = message;
        ExecuteButton.Invoke();
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
