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
            OutputInfoBuy(costShoes,"���� �����");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {costShoes} ������");
        }
    }
    public void BuyCloth()
    {
        if (Player.money >= costClothes)
        {
            Player.Clothes += 1;
            Player.ClothesWear += ClothesWear;
            Player.money -= costClothes;
            OutputInfoBuy(costClothes,"������ �� �����");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {costClothes} ������");
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
                OutputInfoBuy(costSmartPhone,"��������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {costSmartPhone} ������");
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
                if (Player.money >= costFridge)
                {
                    Player.Fridge = true;
                    Player.money -= costFridge;
                    OutputInfoBuy(costFridge, "�����������");
                }
                else
                {
                    OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {costFridge} ������");
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
            if (Player.money >= costTent)
            {
                Player.haveTent = true;
                Player.money -= costTent;
                OutputInfoBuy(costTent, "�������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ����� �����: {costTent} ������");
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
            if (Player.money >= costBrokenCar)
            {
                Player.BrokenCar = true;
                Player.money -= costBrokenCar;
                OutputInfoBuy(costBrokenCar, "��������� ������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {costBrokenCar} ������");
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
            if (Player.money >= costGarage)
            {
                Player.haveGarage = true;
                Player.money -= costGarage;
                OutputInfoBuy(costGarage, "��������� ������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {costGarage} ������");
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
            if (Player.money >= costApartment)
            {
                Player.haveApartment = true;
                Player.money -= costApartment;
                OutputInfoBuy(costApartment, "��������");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {costApartment} ������");
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
            if (Player.money >= costHouse)
            {
                Player.haveHouse = true;
                Player.money -= costHouse;
                OutputInfoBuy(costHouse, "���");
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������ ������������ �����: {costHouse} ������");
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
            if (Player.money >= costCutBeard)
            {
                Player.lvlBread = 1;
                Player.money -= costCutBeard;
                OutputInfoWarning("�� ������� ������");
                ExecuteButton.Invoke();
            }
            else
            {
                OutputInfoWarning($"��� ��������� �����\n������� ������ �����: {costCutBeard} ������");
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
}
