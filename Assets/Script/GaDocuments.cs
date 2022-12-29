using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaDocuments : MonoBehaviour
{
    public delegate void DisButtonWork();
    public static event DisButtonWork ExecuteButton;
    public Text info;

    int costPassport;
    int costAttSchool;
    int costCollege;
    int costBakal;
    int costMagis;
    int costAspir;
    // Start is called before the first frame update
    void Start()
    {
        costPassport = 7000;
        costAttSchool = 30000;
        costCollege = 210000;
        costBakal = 800000;
        costMagis = 1600000;
        costAspir = 4000000;
    }
    public void BuyPassport()
    {
        if (Player.money >= costPassport)
        {
            Player.havePassport = true;
            Player.money -= costPassport;
            OutputInfoBuy(costPassport, "�� ������������ �������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������������� �������� �����: {costPassport} ������");
        }
    }
    public void BuyAttSchool()
    {
        if (Player.money >= costAttSchool)
        {
            Player.haveSchool = true;
            Player.money -= costAttSchool;
            OutputInfoBuy(costAttSchool, "�� �������� �������� �����������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n��� ��������� ��������� �����������: {costAttSchool} ������");
        }
    }
    public void BuyDipCollege()
    {
        if (Player.money >= costCollege)
        {
            Player.haveDiplCollage = true;
            Player.money -= costCollege;
            OutputInfoBuy(costCollege, "�� ��������� � ��������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� � ��������: {costCollege} ������");
        }
    }
    public void BuyDipBakal()
    {
        if (Player.money >= costBakal)
        {
            Player.haveDiplVus = true;
            Player.money -= costBakal;
            OutputInfoBuy(costBakal, "�� ��������� �� ���������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� �� ���������: {costBakal} ������");
        }
    }
    public void BuyMagistrl()
    {
        if (Player.money >= costMagis)
        {
            Player.haveMagistr = true;
            Player.money -= costMagis;
            OutputInfoBuy(costMagis, "�� ��������� �� ��������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� �� ��������: {costMagis} ������");
        }
    }
    public void BuyAspir()
    {
        if (Player.money >= costAspir)
        {
            Player.haveAspir = true;
            Player.money -= costAspir;
            OutputInfoBuy(costAspir, "�� ��������� � �����������");
        }
        else
        {
            OutputInfoWarning($"��� ��������� �����\n�������� � �����������: {costAspir} ������");
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
}
