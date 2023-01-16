using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistika : MonoBehaviour
{
    public Text statistics;
    Color32 greyMy = new Color32(56, 56, 56, 255);
    Color32 whiteMy = new Color32(255, 255, 255, 255);
    Color32 whiteYellowMy = new Color32(255, 245, 190, 255);
    void Start()
    {

        string stata = "";
        //������
        stata = "<color=#88B2FF>���: </color>" + "<color=#0960FF>" + Player.Name + "\n</color>";
        stata += "\n";
        stata += "<color=#E32222>������</color>" + "\n";

        stata += "<color=#FF8888>";
        if (Player.haveHouse == true) stata += "����� ����� � ����� ����" + "\n";
        else if (Player.haveApartment == true) stata += "� ����� ���� ��������" + "\n";
        else if (Player.haveGarage == true) stata += "����� ��������� ���� �����" + "\n";
        else if (Player.BrokenCar == true) stata += "����� ���� � ������ ������ ���� (���� � ����������)" + "\n";
        else if (Player.haveTent == true) stata += "����� ������������ �������� � �������" + "\n";
        else stata += "����� ���� �� ��������" + "\n";
        stata += "</color>";

        //�����������
        stata += "\n";
        stata += "<color=#03CB9F>�����������:" + "\n</color>";

        stata += "<color=#88FFE5>";
        if (Player.haveAspir == true) stata += "����� ������ ���������" + "\n";
        else if (Player.haveMagistr == true) stata += "����� ������ ��������" + "\n";
        else if (Player.haveDiplVus == true) stata += "����� ������ ���������" + "\n";
        else if (Player.haveDiplCollage == true) stata += "����� ������ ��������" + "\n";
        else if (Player.haveSchool == true) stata += "���� �������� ��������" + "\n";
        else stata += "��� �����������" + "\n";
        stata += "</color>";

        //����
        stata += "\n";
        stata += "<color=#FD8A00>���������:" + "\n</color>";

        stata += "<color=#FFC988>";
        if (Player.Shoes > 0) stata += $"� ����� � �������: {Player.ShoesWear} ���� � �������" + "\n";
        else stata += "�����: �����" + "\n";
        if (Player.Clothes > 0) stata += $"���� �� ����� � �������: {Player.ShoesWear} ���� � �������" + "\n";
        else stata += "������: � ��������" + "\n";
        if (Player.haveSmartphone == true) stata += "����� ��������" + "\n";
        if (Player.Fridge == true) stata += "����� �����������" + "\n";
        stata += "</color>";

        //���������
        stata += "\n";
        stata += "<color=#8DD724>���������:" + "\n</color>";

        stata += "<color=#CEFF88>";
        stata += $"���� ������: {Player.lvlBread}\n";
        stata += $"���������: {Player.reputation}\n";
        stata += $"�������� ���������: {Player.freeSkillPoint}\n";
        stata += $"����� ���������� ��������: {Player.freeSkillPoint}\n";
        stata += "</color>";

        //����������
        stata += "\n";
        stata += "<color=#0960FF>����������:" + "\n</color>";

        stata += "<color=#88B2FF>";
        stata += $"����: {((Player.DataInMounth / 10 == 0) ? ("0" + Player.DataInMounth) : Player.DataInMounth)}.{((Player.CurMonth / 10 == 0) ? ("0" + Player.CurMonth) : Player.CurMonth)}.{Player.CurYears}" + "\n";
        stata += $"���� ��������: {((Player.dataDayB / 10 == 0) ? ("0" + Player.dataDayB) : Player.dataDayB)}.{((Player.monthB / 10 == 0) ? ("0" + Player.monthB) : Player.monthB)}.{Player.yearB}" + "\n";
        stata += $"������� �������: {Player.lvl}  ����� {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"������� �����: {Player.CurNameMonth}" + "\n";
        stata += $"������� �����: {Player.CurNameSeason}" + "\n";
        stata += $"����� ���������� ����: {Player.TotalDaysInGame}" + "\n";
        stata += $"����� ����������� �����: {Player.totalMoney}" + "\n" + "\n";
        stata += "</color>";

        stata += "\n";
        stata += "\n";

        stata += "<color=#FFF590>������: </color>" + "<color=#FBFF02>"+ Application.version + "</color>";
        statistics.text = stata;


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
