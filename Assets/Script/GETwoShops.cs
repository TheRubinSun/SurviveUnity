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

    int shoesWear;
    int ClothesWear;

    public void Start()
    {
        //Player.PriceShoes = 1000;
        shoesWear = 31;
        //PriceClothes = 5000;
        ClothesWear = 31;
        //Player.PriceSmartPhone = 30000;
        //Player.PriceFridge = 70000;

        //Player.PriceTent = 5000;
        //Player.PriceBrokenCar = 35000;
        //Player.PriceGarage = 300000;
        //Player.PriceApartament = 1500000;
        //Player.PriceHouse = 8000000;

        //Player.PriceCutBread = 100;
    }
    //=========================================================================================================================
    public void BuyShoes()
    {
        if(Player.money >= Player.PriceShoes)
        {
            Player.Shoes += 1;
            Player.ShoesWear += shoesWear;
            Player.money -= Player.PriceShoes;
            OutputInfoBuy(Player.PriceShoes,"пару обуви");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {Player.PriceShoes} Моулей");
        }
    }
    public void BuyCloth()
    {
        if (Player.money >= Player.PriceClothes)
        {
            Player.Clothes += 1;
            Player.ClothesWear += ClothesWear;
            Player.money -= Player.PriceClothes;
            OutputInfoBuy(Player.PriceClothes,"одежду по вкусу");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {Player.PriceClothes} Моулей");
        }
    }
    public void BuySmartphone()
    {
        if(Player.haveSmartphone != true)
        {
            if (Player.money >= Player.PriceSmartPhone)
            {
                Player.haveSmartphone = true;
                Player.money -= Player.PriceSmartPhone;
                OutputInfoBuy(Player.PriceSmartPhone,"смартфон");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {Player.PriceSmartPhone} Моулей");
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
                if (Player.money >= Player.PriceFridge)
                {
                    Player.Fridge = true;
                    Player.money -= Player.PriceFridge;
                    OutputInfoBuy(Player.PriceFridge, "холодильник");
                }
                else
                {
                    OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {Player.PriceFridge} Моулей");
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
            if (Player.money >= Player.PriceTent)
            {
                Player.haveTent = true;
                Player.money -= Player.PriceTent;
                OutputInfoBuy(Player.PriceTent, "палатку");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанный товар стоит: {Player.PriceTent} Моулей");
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
            if (Player.money >= Player.PriceBrokenCar)
            {
                Player.BrokenCar = true;
                Player.money -= Player.PriceBrokenCar;
                OutputInfoBuy(Player.PriceBrokenCar, "сломанную машину");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {Player.PriceBrokenCar} Моулей");
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
            if (Player.money >= Player.PriceGarage)
            {
                Player.haveGarage = true;
                Player.money -= Player.PriceGarage;
                OutputInfoBuy(Player.PriceGarage, "гараж");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {Player.PriceGarage} Моулей");
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
            if (Player.money >= Player.PriceApartament)
            {
                Player.haveApartment = true;
                Player.money -= Player.PriceApartament;
                OutputInfoBuy(Player.PriceApartament, "квартиру");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {Player.PriceApartament} Моулей");
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
            if (Player.money >= Player.PriceHouse)
            {
                Player.haveHouse = true;
                Player.money -= Player.PriceHouse;
                OutputInfoBuy(Player.PriceHouse, "дом");
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nДанная недвижимость стоит: {Player.PriceHouse} Моулей");
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
            if (Player.money >= Player.PriceCutBread)
            {
                Player.lvlBread = 1;
                Player.money -= Player.PriceCutBread;
                OutputInfoWarning("Вы побрили бороду");
                ExecuteButton.Invoke();
            }
            else
            {
                OutputInfoWarning($"Вам нехватает денег\nПобрить бороду стоит: {Player.PriceCutBread} Моулей");
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
    public delegate void DelOpenShops();
    public static event DelOpenShops MarketEvent;
    public static event DelOpenShops PropertyEvent;
    public static event DelOpenShops CareEvent;
    public void OpenDisplayPriceMarket()
    {
        MarketEvent.Invoke();
    }
    public void OpenDisplayPriceProperty()
    {
        PropertyEvent.Invoke();
    }
    public void OpenDisplayPriceCare()
    {
        CareEvent.Invoke();
    }
}
