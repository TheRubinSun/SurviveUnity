using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistika : MonoBehaviour
{
    public Text statistics;
    void Start()
    {
        string stata = "";
        stata += Player.Name + "\n";
        stata += $"����: {Player.DataInMounth}.{Player.CurMonth}.{Player.CurYears}" + "\n";
        stata += $"���� ��������: {Player.dataDayB}.{Player.monthB}.{Player.yearB}" + "\n";
        stata += $"������� �������: {Player.lvl}  ����� {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"�������� ������: {Player.CurNameMonth}" + "\n";
        stata += $"������� �����: {Player.CurNameSeason}" + "\n";
        stata += $"����� ���������� ����: {Player.TotalDaysInGame}" + "\n";
        stata += $"����� ����������� �����: {Player.totalMoney}" + "\n" + "\n";

        if (Player.haveHouse == true) stata += "����� ����� � ����� ����" + "\n";
        else if (Player.haveApartment == true) stata += "� ����� ���� ��������" + "\n";
        else if (Player.haveGarage == true) stata += "����� ��������� ���� �����" + "\n";
        else if (Player.BrokenCar == true) stata += "����� ���� � ������ ������ ���� (���� � ����������)" + "\n";
        else if (Player.haveTent == true) stata += "����� ������������ �������� � �������" + "\n";
        else stata += "����� ���� �� ��������" + "\n";

        if (Player.Shoes > 0) stata += $"� ����� � �������: {Player.ShoesWear} ���� � �������" + "\n";
        else stata += "�����: �����" + "\n";
        if (Player.Clothes > 0) stata += $"���� �� ����� � �������: {Player.ShoesWear} ���� � �������" + "\n";
        else stata += "������: � ��������" + "\n";
        if (Player.haveSmartphone == true) stata += "����� ��������" + "\n";
        if (Player.Fridge == true) stata += "����� �����������" + "\n";

        if (Player.haveSchool == true) stata += "���� �������� ��������" + "\n";
        else if (Player.haveDiplCollage == true) stata += "����� ������ ��������" + "\n";
        else if (Player.haveDiplVus == true) stata += "����� ������ ���������" + "\n";
        else if (Player.haveMagistr == true) stata += "����� ������ ��������" + "\n";
        else if (Player.haveAspir == true) stata += "����� ������ ���������" + "\n";
        else stata += "��� �����������" + "\n";

        statistics.text = stata;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
