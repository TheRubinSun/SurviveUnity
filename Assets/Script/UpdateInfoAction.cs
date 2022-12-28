using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfoAction : MonoBehaviour
{
    public delegate void UpdateDelegate();
    public static event UpdateDelegate UpdateInfo;

    public int numbActions;
    public Text nameActions;
    public Text countActions;

    public Button buyOne;
    public Button buyTen;
    public Button buyHundred;
    public Button sellOne;
    public Button sellTen;
    public Button sellHundred;
    void Start()
    {
        nameActions.text = Player.actions[numbActions].Name;
        UpdateCountInfo();

        buyOne.GetComponentInChildren<TextMeshProUGUI>().text = $"������ 1 ��.\n����: {Player.actions[numbActions].Cost}";
        buyTen.GetComponentInChildren<TextMeshProUGUI>().text = $"������ 10 ��.\n����: {Player.actions[numbActions].Cost * 10}";
        buyHundred.GetComponentInChildren<TextMeshProUGUI>().text = $"������ 100 ��.\n����: {Player.actions[numbActions].Cost * 100}";
        sellOne.GetComponentInChildren<TextMeshProUGUI>().text = $"������� 1 ��.";
        sellTen.GetComponentInChildren<TextMeshProUGUI>().text = $"������� 10 ��.";
        sellHundred.GetComponentInChildren<TextMeshProUGUI>().text = $"������� 100 ��.";
    }
    public void BuyOneActions()
    {
        if(Player.money >= Player.actions[numbActions].Cost)
        {
            Player.money -= Player.actions[numbActions].Cost;
            Player.countAction[numbActions]++;
            UpdateCountInfo();
        }
        else
        {
            buyOne.GetComponentInChildren<TextMeshProUGUI>().text = "��� �� ������� ������";
        }
    }
    public void BuyTenActions()
    {
        if (Player.money >= (Player.actions[numbActions].Cost * 10))
        {
            Player.money -= (Player.actions[numbActions].Cost * 10);
            Player.countAction[numbActions]+=10;
            UpdateCountInfo();
        }
        else
        {
            buyTen.GetComponentInChildren<TextMeshProUGUI>().text = "��� �� ������� ������";
        }
    }
    public void BuyHundredActions()
    {
        if (Player.money >= (Player.actions[numbActions].Cost * 100))
        {
            Player.money -= (Player.actions[numbActions].Cost * 100);
            Player.countAction[numbActions] += 100;
            UpdateCountInfo();
        }
        else
        {
            buyHundred.GetComponentInChildren<TextMeshProUGUI>().text = "��� �� ������� ������";
        }
    }
    public void SellOneActions()
    {
        if (Player.countAction[numbActions] >= 1)
        {
            Player.money += Player.actions[numbActions].Cost;
            Player.countAction[numbActions]--;
            UpdateCountInfo();
        }
        else
        {
            sellOne.GetComponentInChildren<TextMeshProUGUI>().text = "� ��� ���� ������� �����";
        }
    }
    public void SellTenActions()
    {
        if (Player.countAction[numbActions] >= 10)
        {
            Player.money += (Player.actions[numbActions].Cost*10);
            Player.countAction[numbActions]-=10;
            UpdateCountInfo();
        }
        else
        {
            sellTen.GetComponentInChildren<TextMeshProUGUI>().text = "� ��� ���� ������� �����";
        }
    }
    public void SellHundredActions()
    {
        if (Player.countAction[numbActions] >= 100)
        {
            Player.money += (Player.actions[numbActions].Cost * 100);
            Player.countAction[numbActions] -= 100;
            UpdateCountInfo();
        }
        else
        {
            sellHundred.GetComponentInChildren<TextMeshProUGUI>().text = "� ��� ���� ������� �����";
        }
    }
    public void UpdateCountInfo()
    {
        UpdateInfo.Invoke();
        countActions.text = $"� ��� {Player.countAction[numbActions]} ��.";
    }
}
