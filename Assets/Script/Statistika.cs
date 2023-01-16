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
        //Жилище
        stata = "<color=#88B2FF>Имя: </color>" + "<color=#0960FF>" + Player.Name + "\n</color>";
        stata += "\n";
        stata += "<color=#E32222>Жилище</color>" + "\n";

        stata += "<color=#FF8888>";
        if (Player.haveHouse == true) stata += "Герой живет в своем доме" + "\n";
        else if (Player.haveApartment == true) stata += "У героя своя квартира" + "\n";
        else if (Player.haveGarage == true) stata += "Герой обустроил свой гараж" + "\n";
        else if (Player.BrokenCar == true) stata += "Герой спит в салоне своего авто (хоть и сломанного)" + "\n";
        else if (Player.haveTent == true) stata += "Герой переодически отдыхает в палатке" + "\n";
        else stata += "Герой спит на скамейке" + "\n";
        stata += "</color>";

        //Образование
        stata += "\n";
        stata += "<color=#03CB9F>Образование:" + "\n</color>";

        stata += "<color=#88FFE5>";
        if (Player.haveAspir == true) stata += "Имеет диплом Аспиранта" + "\n";
        else if (Player.haveMagistr == true) stata += "Имеет диплом магистра" + "\n";
        else if (Player.haveDiplVus == true) stata += "Имеет диплом бакалавра" + "\n";
        else if (Player.haveDiplCollage == true) stata += "Имеет диплом колледжа" + "\n";
        else if (Player.haveSchool == true) stata += "Есть школьный аттестат" + "\n";
        else stata += "Без образования" + "\n";
        stata += "</color>";

        //Вещи
        stata += "\n";
        stata += "<color=#FD8A00>Имущество:" + "\n</color>";

        stata += "<color=#FFC988>";
        if (Player.Shoes > 0) stata += $"В обуви с износом: {Player.ShoesWear} дней в будущее" + "\n";
        else stata += "Обувь: босой" + "\n";
        if (Player.Clothes > 0) stata += $"Одет по вкусу с износом: {Player.ShoesWear} дней в будущее" + "\n";
        else stata += "Одежда: в обносках" + "\n";
        if (Player.haveSmartphone == true) stata += "Имеет смартфон" + "\n";
        if (Player.Fridge == true) stata += "Имеет холодильник" + "\n";
        stata += "</color>";

        //Состояние
        stata += "\n";
        stata += "<color=#8DD724>Состояние:" + "\n</color>";

        stata += "<color=#CEFF88>";
        stata += $"Уров бороды: {Player.lvlBread}\n";
        stata += $"Репутация: {Player.reputation}\n";
        stata += $"Доступно улучшений: {Player.freeSkillPoint}\n";
        stata += $"Всего прокаченно талантов: {Player.freeSkillPoint}\n";
        stata += "</color>";

        //Информация
        stata += "\n";
        stata += "<color=#0960FF>Информация:" + "\n</color>";

        stata += "<color=#88B2FF>";
        stata += $"Дата: {((Player.DataInMounth / 10 == 0) ? ("0" + Player.DataInMounth) : Player.DataInMounth)}.{((Player.CurMonth / 10 == 0) ? ("0" + Player.CurMonth) : Player.CurMonth)}.{Player.CurYears}" + "\n";
        stata += $"Дата рождения: {((Player.dataDayB / 10 == 0) ? ("0" + Player.dataDayB) : Player.dataDayB)}.{((Player.monthB / 10 == 0) ? ("0" + Player.monthB) : Player.monthB)}.{Player.yearB}" + "\n";
        stata += $"Текущий уровень: {Player.lvl}  опыта {Player.ex}/{Player.nextExpLvl}" + "\n";
        stata += $"Текущий месяц: {Player.CurNameMonth}" + "\n";
        stata += $"Текущий сезон: {Player.CurNameSeason}" + "\n";
        stata += $"Всего пройденных дней: {Player.TotalDaysInGame}" + "\n";
        stata += $"Всего заработанно денег: {Player.totalMoney}" + "\n" + "\n";
        stata += "</color>";

        stata += "\n";
        stata += "\n";

        stata += "<color=#FFF590>Версия: </color>" + "<color=#FBFF02>"+ Application.version + "</color>";
        statistics.text = stata;


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
