using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchResources : MonoBehaviour
{
    [SerializeField] ActionsButtons actionsButtonsScript;
    public Text info;
    string text;
    public void SearchUrn()
    {
        int bottle = Random.Range(3, 8);
        int copper = Random.Range(0, 2);
        int chance = Random.Range(0, 15);
        int electronics = 0;
        if (chance > 13) electronics = 1;

        int sailty = Random.Range(7, 11);
        int health = Random.Range(3, 6);
        int happines = Random.Range(6, 13);

        Player.countBottle += bottle;
        Player.countCopper += copper;
        Player.countElectronics += electronics;
        Player.sailty -= sailty;
        Player.health -= health;
        Player.hapiness -= happines;

        OutputInfo(bottle, copper, electronics, sailty, health, happines);
        actionsButtonsScript.AddAction();
    }
    public void SearchDumb()
    {
        int bottle = Random.Range(6, 12);
        int copper = Random.Range(0, 8);
        int chance = Random.Range(0, 15);
        int electronics = 0;
        while(chance<3)
        {
            chance = Random.Range(0, 15);
            electronics++;
        }

        int sailty = Random.Range(25, 40);
        int health = Random.Range(16, 25);
        int happines = Random.Range(30, 46);

        Player.countBottle += bottle;
        Player.countCopper += copper;
        Player.countElectronics += electronics;
        Player.sailty -= sailty;
        Player.health -= health;
        Player.hapiness -= happines;

        OutputInfo(bottle, copper, electronics, sailty, health, happines);
        actionsButtonsScript.AddAction();
    }
    void OutputInfo(int bottle, int copper, int electronics, int sailty, int health, int happines)
    {
        text = "";
        text += $"Итог:\n+{bottle} бутылок\n";
        if (copper > 0) text += $"+{((float)copper)/10} кг. меди\n";
        if (electronics > 0) text += $"+{electronics} электроника\n";
        text += $"-{sailty} к сытости\n";
        text += $"-{health} к здоровью\n";
        text += $"-{happines} к счатью\n";
        info.text = text;
    }
}
