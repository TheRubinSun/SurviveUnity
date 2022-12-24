using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckEvents : MonoBehaviour
{
    public GameObject deathWindow;
    public GameObject bithDayWindow;
    public GameObject priceWindow;
    public Transform parent;
    private void OnEnable()
    {
        ActionsButtons.OneAction += CheckAction;
        ActionsButtons.OneAction += CheckDay;
        GameEvents.OpenEvent += DisplayPrice;
    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= CheckAction;
        ActionsButtons.OneAction -= CheckDay;
        GameEvents.OpenEvent -= DisplayPrice;
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
        else if(Player.hapiness < 1)
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
        string temptext = $"У вас день рождения!\nВаш подарок:\n{(int)(Player.totalMoney/100 * Player.moneyPercentForBD)} денег";
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
        string temptext = $"1 бутылка = {Player.priceBottle} руб.\n1 кг ягод = {Player.priceBerries} руб.\n1 кг меди = {Player.priceCopper} руб.\n1 электроника = {Player.priceElectronics} руб.\n";
        GameObject.Find("PriceText").GetComponent<Text>().text = temptext;
    }
    public void CloseDisplayPrice()
    {
        Destroy(GameObject.Find("PriceBG(Clone)"));
    }


    public delegate void DelDeath();
    public static event DelDeath EventDeath;
    public void OkeyDeath()
    {
        Destroy(GameObject.Find("Death BG(Clone)"));
        EventDeath.Invoke();
        SceneManager.LoadScene("StartGame");
    }
}
