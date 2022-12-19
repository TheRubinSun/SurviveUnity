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
        stata += $"Дата: {Player.DataInMounth}.{Player.CurMonth}.{Player.CurYears}" + "\n";
        stata += $"Дата рождения: {Player.dataDayB}.{Player.monthB}.{Player.yearB}" + "\n";
        stata += $"Текущий уровень: {Player.lvl}  опыта {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"Название месяца: {Player.CurNameMonth}" + "\n";
        stata += $"Текущий сезон: {Player.CurNameSeason}" + "\n";
        stata += $"Всего пройденных дней: {Player.TotalDaysInGame}" + "\n";
        stata += $"Всего заработанно денег: {Player.totalMoney}" + "\n";
        statistics.text = stata;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
