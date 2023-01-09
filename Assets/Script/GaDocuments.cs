using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaDocuments : MonoBehaviour
{
    public delegate void DisButtonWork();
    public static event DisButtonWork ExecuteButton;
    public Text info;


    // Start is called before the first frame update
    void Start()
    {
        //Player.PricePassport = 7000;
        //Player.PriceSchoolEd = 30000;
        //Player.PriceColledge = 210000;
        //Player.PriceBakal = 800000;
        //Player.PriceMagis = 1600000;
        //Player.PriceAsper = 4000000;
    }
    public void BuyPassport()
    {
        if (Player.money >= Player.PricePassport)
        {
            Player.havePassport = true;
            Player.money -= Player.PricePassport;
            OutputInfoBuy(Player.PricePassport, "�� ������������ �������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������������� �������� �����: {Player.PricePassport} ������");
        }
    }
    public void BuyAttSchool()
    {
        if (Player.money >= Player.PriceSchoolEd)
        {
            Player.haveSchool = true;
            Player.money -= Player.PriceSchoolEd;
            OutputInfoBuy(Player.PriceSchoolEd, "�� �������� �������� �����������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n��� ��������� ��������� �����������: {Player.PriceSchoolEd} ������");
        }
    }
    public void BuyDipCollege()
    {
        if (Player.money >= Player.PriceColledge)
        {
            Player.haveDiplCollage = true;
            Player.money -= Player.PriceColledge;
            OutputInfoBuy(Player.PriceColledge, "�� ��������� � ��������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� � ��������: {Player.PriceColledge} ������");
        }
    }
    public void BuyDipBakal()
    {
        if (Player.money >= Player.PriceBakal)
        {
            Player.haveDiplVus = true;
            Player.money -= Player.PriceBakal;
            OutputInfoBuy(Player.PriceBakal, "�� ��������� �� ���������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� �� ���������: {Player.PriceBakal} ������");
        }
    }
    public void BuyMagistrl()
    {
        if (Player.money >= Player.PriceMagis)
        {
            Player.haveMagistr = true;
            Player.money -= Player.PriceMagis;
            OutputInfoBuy(Player.PriceMagis, "�� ��������� �� ��������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� �� ��������: {Player.PriceMagis} ������");
        }
    }
    public void BuyAspir()
    {
        if (Player.money >= Player.PriceAsper)
        {
            Player.haveAspir = true;
            Player.money -= Player.PriceAsper;
            OutputInfoBuy(Player.PriceAsper, "�� ��������� � �����������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� � �����������: {Player.PriceAsper} ������");
        }
    }
    void OutputInfoWarning(string text)
    {
        info.text = text;
    }
    void OutputInfoBuy(int cost,string text)
    {
        ExecuteButton.Invoke();
        info.text = $"{text}\n�� {cost} ������";
    }
    public delegate void DelOpenDoc();
    public static event DelOpenDoc OpenEventDoc;
    public void OpenDisplayPriceDocuments()
    {
        OpenEventDoc.Invoke();
    }
}
