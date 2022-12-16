using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarNeed : MonoBehaviour
{
    public Image barSailty;
    public Text textSailty;

    public Image barHealth;
    public Text textHealth;

    public Image barHappiness;
    public Text textHappiness;

    public Image barExp;
    public Text textExp;
    public GameObject lvlIcon;
    // Start is called before the first frame update
    void Start()
    {
        UpdateBars();
    }
    public void UpdateBars()
    {
        float sailty = ((float)Player.sailty/(float)Player.maxSailty);
        barSailty.fillAmount = sailty;
        textSailty.text = $"{Player.sailty}/{Player.maxSailty}";

        float health = ((float)Player.health/(float)Player.maxHealth);
        barHealth.fillAmount = health;
        textHealth.text = $"{Player.health}/{Player.maxHealth}";

        float happiness = ((float)Player.hapiness/(float)Player.maxHapiness);
        barHappiness.fillAmount = happiness;
        textHappiness.text = $"{Player.hapiness}/{Player.maxHapiness}";

        float exp = (((float)Player.ex)/(float)Player.nextExpLvl);
        barExp.fillAmount = exp;
        textExp.text = $"{Player.ex}/{Player.nextExpLvl}";
        UpdateLvlIcon();
    }
    void UpdateLvlIcon()
    {
        if(Player.lvl == 1)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl1");
        }
        else if (Player.lvl == 2)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl2");
        }
        else if (Player.lvl == 3)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl3");
        }
        else if (Player.lvl == 4)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl4");
        }
        else if (Player.lvl == 5)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl5");
        }
        else if (Player.lvl == 6)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl6");
        }
        else if (Player.lvl == 7)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl7");
        }
        else if (Player.lvl == 8)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl8");
        }
        else if (Player.lvl == 9)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl9");
        }
        else if (Player.lvl == 10)
        {
            lvlIcon.GetComponent<Animator>().Play("lvl10");
        }
    }
}
