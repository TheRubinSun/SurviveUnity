using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GETwoShops : MonoBehaviour
{
    public delegate void DisButtonWork();
    public static event DisButtonWork ExecuteButton;
    public Text info;
    string text;

    int costShoes;
    int shoesWear;
    int costClothes;
    int ClothesWear;
    int costSmartPhone;
    int costFridge;
    int costTent;
    int costBrokenCar;
    int costGarage;
    int costApartment;
    int costHouse;
    int costCutBeard;
    public void Start()
    {
        costShoes = 1000;
        shoesWear = 31;
        costClothes = 5000;
        ClothesWear = 31;
        costSmartPhone = 30000;
        costFridge = 70000;

        costTent = 5000;
        costBrokenCar = 35000;
        costGarage = 300000;
        costApartment = 1500000;
        costHouse = 8000000;

        costCutBeard = 100;
    }
    //=========================================================================================================================
    public void BuyShoes()
    {
        if(Player.money >= costShoes)
        {
            Player.Shoes += 1;
            Player.ShoesWear += shoesWear;
            Player.money -= costShoes;
            OutputInfoBuy(costShoes,"пару обуви");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {costShoes} Моулей");
        }
    }
    public void BuyCloth()
    {
        if (Player.money >= costClothes)
        {
            Player.Clothes += 1;
            Player.ClothesWear += ClothesWear;
            Player.money -= costClothes;
            OutputInfoBuy(costClothes,"одежду по вкусу");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {costClothes} Моулей");
        }
    }
    public void BuySmartphone()
    {
        if(Player.haveSmartphone != true)
        {
            if (Player.money >= costSmartPhone)
            {
                Player.haveSmartphone = true;
                Player.money -= costSmartPhone;
                OutputInfoBuy(costSmartPhone,"смартфон");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {costSmartPhone} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть смартфон");
        }
    }
    public void BuyFridge()
    {
        if (Player.Fridge != true)
        {
            if (Player.haveGarage == true || Player.haveApartment == true || Player.haveHouse)
            {
                if (Player.money >= costFridge)
                {
                    Player.Fridge = true;
                    Player.money -= costFridge;
                    OutputInfoBuy(costFridge, "холодильник");
                }
                else
                {
                    OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {costFridge} Моулей");
                }
            }
            else
            {
                OutputInfoWarning($"Вам нужен гараж или квартира или дом для холодильника");
            }

        }
        else
        {
            OutputInfoWarning($"У вас уже есть холодильник");
        }
    }
    //=========================================================================================================================
    public void BuyTent()
    {
        if (Player.haveTent != true)
        {
            if (Player.money >= costTent)
            {
                Player.haveTent = true;
                Player.money -= costTent;
                OutputInfoBuy(costTent, "палатка");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {costTent} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть палатка");
        }
    }
    public void BuyBrokenCar()
    {
        if (Player.BrokenCar != true)
        {
            if (Player.money >= costBrokenCar)
            {
                Player.BrokenCar = true;
                Player.money -= costBrokenCar;
                OutputInfoBuy(costBrokenCar, "сломанная машина");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {costBrokenCar} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть сломанная машина");
        }
    }
    public void BuyGarage()
    {
        if (Player.haveGarage != true)
        {
            if (Player.money >= costGarage)
            {
                Player.haveGarage = true;
                Player.money -= costGarage;
                OutputInfoBuy(costGarage, "сломанная машина");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {costGarage} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть гараж");
        }
    }
    public void BuyApartment()
    {
        if (Player.haveApartment != true)
        {
            if (Player.money >= costApartment)
            {
                Player.haveApartment = true;
                Player.money -= costApartment;
                OutputInfoBuy(costApartment, "квартира");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {costApartment} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть квартира");
        }
    }
    public void BuyHouse()
    {
        if (Player.haveHouse != true)
        {
            if (Player.money >= costHouse)
            {
                Player.haveHouse = true;
                Player.money -= costHouse;
                OutputInfoBuy(costHouse, "дом");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {costHouse} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас уже есть дом");
        }
    }
    //=========================================================================================================================
    public void CutBeard()
    {
        if (Player.lvlBread > 1)
        {
            if (Player.money >= costCutBeard)
            {
                Player.lvlBread = 1;
                Player.money -= costCutBeard;
                OutputInfoWarning("Вы побрили бороду");
                ExecuteButton.Invoke();
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nПобрить бороду стоит: {costCutBeard} Моулей");
            }
        }
        else
        {
            OutputInfoWarning($"У вас нету бороды");
        }
    }
    //=========================================================================================================================
    void OutputInfoWarning(string warning)
    {
        info.text = warning;
    }
    void OutputInfoBuy(int cost, string product)
    {
        ExecuteButton.Invoke();
        string text = "";
        text += $"Вы купили {product}\n";
        text += $"Вы потратили {cost} Моулей";
        info.text = text;
    }
}
