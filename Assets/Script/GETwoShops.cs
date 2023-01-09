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
            OutputInfoBuy(Player.PriceShoes,"���� �����");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {Player.PriceShoes} ������");
        }
    }
    public void BuyCloth()
    {
        if (Player.money >= Player.PriceClothes)
        {
            Player.Clothes += 1;
            Player.ClothesWear += ClothesWear;
            Player.money -= Player.PriceClothes;
            OutputInfoBuy(Player.PriceClothes,"������ �� �����");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {Player.PriceClothes} ������");
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
                OutputInfoBuy(Player.PriceSmartPhone,"��������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {Player.PriceSmartPhone} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� ��������");
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
                    OutputInfoBuy(Player.PriceFridge, "�����������");
                }
                else
                {
                    OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {Player.PriceFridge} ������");
                }
            }
            else
            {
                OutputInfoWarning($"��� ����� ����� ��� �������� ��� ��� ��� ������������");
            }

        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� �����������");
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
                OutputInfoBuy(Player.PriceTent, "�������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {Player.PriceTent} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� �������");
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
                OutputInfoBuy(Player.PriceBrokenCar, "��������� ������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {Player.PriceBrokenCar} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� ��������� ������");
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
                OutputInfoBuy(Player.PriceGarage, "�����");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {Player.PriceGarage} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� �����");
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
                OutputInfoBuy(Player.PriceApartament, "��������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {Player.PriceApartament} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� ��������");
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
                OutputInfoBuy(Player.PriceHouse, "���");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {Player.PriceHouse} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ��� ���� ���");
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
                OutputInfoWarning("�� ������� ������");
                ExecuteButton.Invoke();
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������� ������ �����: {Player.PriceCutBread} ������");
            }
        }
        else
        {
            OutputInfoWarning($"� ��� ���� ������");
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
        text += $"�� ������ {product}\n";
        text += $"�� ��������� {cost} ������";
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
