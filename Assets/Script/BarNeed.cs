using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
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
    public SpriteRenderer lvlIconRender;
    public SpriteAtlas lvlsIconAtals;

    // Start is called before the first frame update
    private void OnEnable()
    {
        ActionsButtons.OneAction += UpdateBars;
        ActionsButtons.OneAction += UpdateLvlIcon;
    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= UpdateBars;
        ActionsButtons.OneAction -= UpdateLvlIcon;
    }
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

        float happiness = ((float)Player.happiness/(float)Player.maxHappiness);
        barHappiness.fillAmount = happiness;
        textHappiness.text = $"{Player.happiness}/{Player.maxHappiness}";

        float exp = (((float)Player.ex)/(float)Player.nextExpLvl);
        barExp.fillAmount = exp;
        textExp.text = $"{Player.ex}/{Player.nextExpLvl}";
    }
    void UpdateLvlIcon()
    {
        switch(Player.lvl)
        {
            case 1:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("1");
                    break;
                }
            case 2:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("2");
                    break;
                }
            case 3:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("3");
                    break;
                }
            case 4:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("4");
                    break;
                }
            case 5:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("5");
                    break;
                }
            case 6:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("6");
                    break;
                }
            case 7:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("7");
                    break;
                }
            case 8:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("8");
                    break;
                }
            case 9:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("9");
                    break;
                }
            case 10:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("10");
                    break;
                }
            default:
                {
                    lvlIconRender.sprite = lvlsIconAtals.GetSprite("10");
                    break;
                }
        }
    }
}
