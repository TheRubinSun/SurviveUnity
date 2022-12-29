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
        stata += $"Дата: {Player.DataInMounth}.{Player.CurMonth}.{Player.CurYears}" + "\n";
        stata += $"Дата рождения: {Player.dataDayB}.{Player.monthB}.{Player.yearB}" + "\n";
        stata += $"Текущий уровень: {Player.lvl}  опыта {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"Название месяца: {Player.CurNameMonth}" + "\n";
        stata += $"Текущий сезон: {Player.CurNameSeason}" + "\n";
        stata += $"Всего пройденных дней: {Player.TotalDaysInGame}" + "\n";
        stata += $"Всего заработанно денег: {Player.totalMoney}" + "\n" + "\n";

        if (Player.haveHouse == true) stata += "Герой живет в своем доме" + "\n";
        else if (Player.haveApartment == true) stata += "У героя своя квартира" + "\n";
        else if (Player.haveGarage == true) stata += "Герой обустроил свой гараж" + "\n";
        else if (Player.BrokenCar == true) stata += "Герой спит в салоне своего авто (хоть и сломанного)" + "\n";
        else if (Player.haveTent == true) stata += "Герой переодически отдыхает в палатке" + "\n";
        else stata += "Герой спит на скамейке" + "\n";

        if (Player.Shoes > 0) stata += $"В обуви с износом: {Player.ShoesWear} дней в будущее" + "\n";
        else stata += "Обувь: босой" + "\n";
        if (Player.Clothes > 0) stata += $"Одет по вкусу с износом: {Player.ShoesWear} дней в будущее" + "\n";
        else stata += "Одежда: в обносках" + "\n";
        if (Player.haveSmartphone == true) stata += "Имеет смартфон" + "\n";
        if (Player.Fridge == true) stata += "Имеет холодильник" + "\n";

        if (Player.haveSchool == true) stata += "Есть школьный аттестат" + "\n";
        else if (Player.haveDiplCollage == true) stata += "Имеет диплом колледжа" + "\n";
        else if (Player.haveDiplVus == true) stata += "Имеет диплом бакалавра" + "\n";
        else if (Player.haveMagistr == true) stata += "Имеет диплом магистра" + "\n";
        else if (Player.haveAspir == true) stata += "Имеет диплом Аспиранта" + "\n";
        else stata += "Без образования" + "\n";

        statistics.text = stata;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
