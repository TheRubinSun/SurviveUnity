using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Statistika : MonoBehaviour
{
    public Text statistics;
    void Start()
    {
        string stata = "";
        stata += Player.name + "\n";
        stata += $"����: {Player.DataInMounth}.{Player.CurMonth}.{Player.CurYears}" + "\n";
        stata += $"���� ��������: {Player.dataDayB}.{Player.monthB}.{Player.yearB}" + "\n";
        stata += $"������� �������: {Player.lvl}  ����� {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"�������� ������: {Player.CurNameMonth}" + "\n";
        stata += $"������� �����: {Player.CurNameSeason}" + "\n";
        stata += $"����� ���������� ����: {Player.TotalDaysInGame}" + "\n";
        stata += $"����� ����������� �����: {Player.totalMoney}" + "\n";
        statistics.text = stata;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
