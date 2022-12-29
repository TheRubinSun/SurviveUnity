using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckEvents : MonoBehaviour
{
    public delegate void Delagate();
    public static event Delagate EventDeath;


    public GameObject deathWindow;
    public GameObject bithDayWindow;
    public GameObject priceWindow;
    public GameObject lvlUpWindow;
    public Transform parent;
    private void OnEnable()
    {
        ActionsButtons.OneAction += CheckAction;
        ActionsButtons.OneAction += CheckDay;
        GameEvents.OpenEvent += DisplayPrice;
        MainLogic.EventLvlUp += LvlUp;
    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= CheckAction;
        ActionsButtons.OneAction -= CheckDay;
        GameEvents.OpenEvent -= DisplayPrice;
        MainLogic.EventLvlUp -= LvlUp;
    }
    void CheckAction()
    {
        if(Player.sailty < 1)
        {
            Death("Вы умерли из-за голода");
        }
        else if(Player.health < 1)
        {
            int i = Random.Range(0, 5);
            switch(i)
            {
                case 0:
                    {
                        Death("У вас случилася инфаркт");
                        break;
                    }
                case 1:
                    {
                        Death("Вы умерли из-за отсутсвия леченя");
                        break;
                    }
                case 2:
                    {
                        Death("Вы умерли от болезни");
                        break;
                    }
                default:
                    {
                        Death("Вы умерли из-за простуды");
                        break;
                    }
            }
        }
        else if(Player.happiness < 1)
        {
            Death("Вам показалась жизнь ужасной");
        }
    }

    void CheckDay()
    {
        if(Player.TotalDaysInGame % 365 == 0 && Player.CurActionDay == 1)
        {
            Player.CurDay++;
            Player.TotalDaysInGame++;
            BirthDay();
        }
    }
    void Death(string deathName)
    {
        Instantiate(deathWindow, parent);
        GameObject.Find("TextDeath").GetComponent<Text>().text = deathName;
    }
    void BirthDay()
    {
        Instantiate(bithDayWindow, parent);
        string temptext = $"У вас день рождения!\nВаш подарок:\n{(int)(Player.totalMoney/100 * Player.moneyPercentForBD)} Моулей";
        GameObject.Find("TextBirthDay").GetComponent<Text>().text = temptext;
    }
    public void GiveMoneyForBD()
    {
        Player.money += (int)(Player.totalMoney / 100 * Player.moneyPercentForBD);
        Destroy(GameObject.Find("BG BirthDay(Clone)"));
    }

    public void DisplayPrice()
    {
        Instantiate(priceWindow, parent);

        string temptext = $"<<Сегодня>>\n1 бутылка = {Player.priceBottle} Моулей\n1 кг ягод = {Player.priceBerries} Моулей\n1 кг меди = {Player.priceCopper} Моулей\n1 электроника = {Player.priceElectronics} Моулей\n";
        GameObject.Find("PriceText").GetComponent<Text>().text = temptext;
    }
    public void CloseDisplayPrice()
    {
        Destroy(GameObject.Find("PriceBG(Clone)"));
    }


    public void OkeyDeath()
    {
        Destroy(GameObject.Find("Death BG(Clone)"));
        EventDeath.Invoke();
        SceneManager.LoadScene("StartGame");
    }

    public void SailtyUp()
    {
        Player.maxSailty += 25;
        Player.sailty = Player.maxSailty;
        CloseLvlUpWindow();

    }

    public delegate void DelLvlUp();
    public static event DelLvlUp UpdateInfoAfterLvl;
    public void LvlUp()
    {
        Instantiate(lvlUpWindow, parent);
        Invoke("CloseTimerWindow", 1f);
    }
    public void CloseTimerWindow()
    {
        Destroy(GameObject.Find("Timer"));
    }
    public void HealthUp()
    {
        Player.maxHealth += 25;
        Player.health = Player.maxHealth;
        CloseLvlUpWindow();
    }
    public void HappinessUp()
    {
        Player.maxHappiness += 25;
        Player.happiness = Player.maxHappiness;
        CloseLvlUpWindow();
    }
    public void BonysBDUp()
    {
        Player.moneyPercentForBD += 2;
        CloseLvlUpWindow();
    }
    void CloseLvlUpWindow()
    {
        Player.freeSkillPoint--;
        Player.totalSkillPoint++;
        MainLogic.pumpedUp = false;
        UpdateInfoAfterLvl.Invoke();
        Destroy(GameObject.Find("LvlUpBG(Clone)"));
    }
}
