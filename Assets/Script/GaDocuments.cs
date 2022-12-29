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
            OutputInfoBuy(costPassport, "Вы восстановили паспорт");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nВосстановление паспорта стоит: {costPassport} Моулей");
        }
    }
    public void BuyAttSchool()
    {
        if (Player.money >= costAttSchool)
        {
            Player.haveSchool = true;
            Player.money -= costAttSchool;
            OutputInfoBuy(costAttSchool, "Вы получили школьное образование");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nДля получения школьного образования: {costAttSchool} Моулей");
        }
    }
    public void BuyDipCollege()
    {
        if (Player.money >= costCollege)
        {
            Player.haveDiplCollage = true;
            Player.money -= costCollege;
            OutputInfoBuy(costCollege, "Вы отучились в колледже");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nВыучится в колледже: {costCollege} Моулей");
        }
    }
    public void BuyDipBakal()
    {
        if (Player.money >= costBakal)
        {
            Player.haveDiplVus = true;
            Player.money -= costBakal;
            OutputInfoBuy(costBakal, "Вы отучились на бакалавра");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nВыучится на бакалавра: {costBakal} Моулей");
        }
    }
    public void BuyMagistrl()
    {
        if (Player.money >= costMagis)
        {
            Player.haveMagistr = true;
            Player.money -= costMagis;
            OutputInfoBuy(costMagis, "Вы отучились на магистра");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nВыучится на магистра: {costMagis} Моулей");
        }
    }
    public void BuyAspir()
    {
        if (Player.money >= costAspir)
        {
            Player.haveAspir = true;
            Player.money -= costAspir;
            OutputInfoBuy(costAspir, "Вы отучились в аспирантуре");
        }
        else
        {
            OutputInfoWarning($"Вам нехватает денег\nВыучится в аспирантуре: {costAspir} Моулей");
        }
    }
    void OutputInfoWarning(string text)
    {
        info.text = text;
    }
    void OutputInfoBuy(int cost,string text)
    {
        ExecuteButton.Invoke();
        info.text = $"{text}\nЗа {cost} Моулей";
    }
}
