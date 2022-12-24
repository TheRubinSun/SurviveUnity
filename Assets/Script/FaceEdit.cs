using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.U2D;

public class FaceEdit : MonoBehaviour
{
    public SpriteAtlas spriteAtlasHead;
    public SpriteRenderer spriteRendererHead;
    int curHead;
    int countHead;

    public SpriteAtlas spriteAtlasHair;
    public SpriteRenderer spriteRendererHair;
    int curHair;
    int countHair;

    public SpriteAtlas spriteAtlasNose;
    public SpriteRenderer spriteRendererNose;
    int curNose;
    int countNose;

    public SpriteAtlas spriteAtlasMouth;
    public SpriteRenderer spriteRendererMouth;
    int curMouth;
    int countMouth;

    public SpriteAtlas spriteAtlasEye;
    public SpriteRenderer spriteRendererEye;
    int curEye;
    int countEye;

    public SpriteAtlas spriteAtlasBeard;
    public SpriteRenderer spriteRendererBeard;
    int curBeard;
    int countBeard;
    
    private void Start()
    {
        curHead = 1;
        curHair = 1;
        curNose = 1;
        curMouth = 1;
        curEye = 1;
        curBeard = 1;

        countHead = spriteAtlasHead.spriteCount;
        countHair = spriteAtlasHair.spriteCount;
        countNose = spriteAtlasNose.spriteCount;
        countMouth = spriteAtlasMouth.spriteCount;
        countEye = spriteAtlasEye.spriteCount;
        countBeard = spriteAtlasBeard.spriteCount;

        GameObject.Find("HeadText").GetComponent<Text>().text = "Форма лица" + $"\n{curHead}/{countHead}";
        GameObject.Find("HairText").GetComponent<Text>().text = "Прическа" + $"\n{curHair}/{countHair}";
        GameObject.Find("NoseText").GetComponent<Text>().text = "Нос" + $"\n{curNose}/{countNose}";
        GameObject.Find("MouthText").GetComponent<Text>().text = "Рот" + $"\n{curMouth}/{countMouth}";
        GameObject.Find("EyeText").GetComponent<Text>().text = "Глаза" + $"\n{curEye}/{countEye}";
        GameObject.Find("BeardText").GetComponent<Text>().text = "Борода" + $"\n{curBeard}/{countBeard}";
        UpdateAll();
    }
    void UpdateAll()
    {
        UpdateEye();
        UpdateHead();
        UpdateNose();
        UpdateMouth();
        UpdateHair();
        UpdateBeard();
    }
    void Update()
    {
        if (GameObject.Find("TextName").GetComponent<Text>().text != "")
        {
            GameObject.Find("Placeholder").GetComponent<Text>().text = "";
        }
        else
        {
            GameObject.Find("Placeholder").GetComponent<Text>().text = "Введите сюда имя";
        }
    }
    void UpdateHead()
    {
        for (int i = 1; i <= countHead; i++)//1
        {
            if (i == curHead)
            {
                spriteRendererHead.sprite = spriteAtlasHead.GetSprite("Head " + i);
                GameObject.Find("HeadText").GetComponent<Text>().text = "Форма лица" + $"\n{curHead}/{countHead}";
            }
        }
    }
    void UpdateHair()
    {
        for (int i = 1; i <= countHair; i++)//2
        {
            if (i == curHair)
            {
                spriteRendererHair.sprite = spriteAtlasHair.GetSprite("Hair " + i);
                GameObject.Find("HairText").GetComponent<Text>().text = "Прическа" + $"\n{curHair}/{countHair}";
            }
        }
    }
    void UpdateNose()
    {
        for (int i = 1; i <= countNose; i++)//3
        {
            if (i == curNose)
            {
                spriteRendererNose.sprite = spriteAtlasNose.GetSprite("Nose " + i);
                GameObject.Find("NoseText").GetComponent<Text>().text = "Нос" + $"\n{curNose}/{countNose}";
            }
        }
    }
    void UpdateMouth()
    {
        for (int i = 1; i <= countMouth; i++)//4
        {
            if (i == curMouth)
            {
                spriteRendererMouth.sprite = spriteAtlasMouth.GetSprite("Mouth " + i);
                GameObject.Find("MouthText").GetComponent<Text>().text = "Рот" + $"\n{curMouth}/{countMouth}";
            }
        }
    }
    void UpdateEye()
    {
        for (int i = 1; i <= countEye; i++)//5
        {
            if (i == curEye)
            {
                spriteRendererEye.sprite = spriteAtlasEye.GetSprite("Eye " + i);
                GameObject.Find("EyeText").GetComponent<Text>().text = "Глаза" + $"\n{curEye}/{countEye}";
            }
        }
    }
    void UpdateBeard()
    {
        for (int i = 1; i <= countBeard; i++)//6
        {
            if (i == curBeard)
            {
                spriteRendererBeard.sprite = spriteAtlasBeard.GetSprite("Beard "+i);
                //beardObj.GetComponent<Animator>().Play(($"Beard{i}"));
                GameObject.Find("BeardText").GetComponent<Text>().text = "Beard" + $"\n{curBeard}/{countBeard}";
            }
        }
    }
    public void plusHead()//Лицо
    {
        if(curHead < countHead)
        {
            curHead++;
        }
        else
        {
            curHead = 1;
        }
        UpdateHead();
    }
    public void minusHead()
    {
        if (curHead > 1)
        {
            curHead--;
        }
        else
        {
            curHead = countHead;
        }
        UpdateHead();
    }
    public void plusHair()//Волосы
    {
        if (curHair < countHair)
        {
            curHair++;
        }
        else
        {
            curHair = 1;
        }
        UpdateHair();
    }
    public void minusHair()
    {
        if (curHair > 1)
        {
            curHair--;
        }
        else
        {
            curHair = countHair;
        }
        UpdateHair();
    }
    public void plusNose()//Нос
    {
        if (curNose < countNose)
        {
            curNose++;
        }
        else
        {
            curNose = 1;
        }
        UpdateNose();
    }
    public void minusNose()
    {
        if (curNose > 1)
        {
            curNose--;
        }
        else
        {
            curNose = countNose;
        }
        UpdateNose();
    }
    public void plusMouth()//Рот
    {
        if (curMouth < countMouth)
        {
            curMouth++;
        }
        else
        {
            curMouth = 1;
        }
        UpdateMouth();
    }
    public void minusMouth()
    {
        if (curMouth > 1)
        {
            curMouth--;
        }
        else
        {
            curMouth = countMouth;
        }
        UpdateMouth();
    }
    public void plusEye()//Глаза
    {
        if (curEye < countEye)
        {
            curEye++;
        }
        else
        {
            curEye = 1;
        }
        UpdateEye();
    }
    public void minusEye()
    {
        if (curEye > 1)
        {
            curEye--;
        }
        else
        {
            curEye = countEye;
        }
        UpdateEye();
    }
    public void plusBeard()//Борода
    {
        if (curBeard < countBeard)
        {
            curBeard++;
        }
        else
        {
            curBeard = 1;
        }
        UpdateBeard();
    }
    public void ChangeText()
    {
        if(GameObject.Find("TextName").GetComponent<Text>().text != "")
        {
            GameObject.Find("Placeholder").GetComponent<Text>().text = "";
        }
        else
        {
            GameObject.Find("Placeholder").GetComponent<Text>().text = "Введите сюда имя";
        }
    }
    public void minusBeard()
    {
        if (curBeard > 1)
        {
            curBeard--;
        }
        else
        {
            curBeard = countBeard;
        }
        UpdateBeard();
    }

    public void Okey()
    {
        Player.priceBottle = Random.Range(2, 9);
        Player.priceBerries = Random.Range(100, 400);
        Player.priceCopper = Random.Range(250, 401);
        Player.priceElectronics = Random.Range(800, 2000);

        string name = GameObject.Find("TextName").GetComponent<Text>().text;

        MainLogic.CreatePlayer(name, curEye, curHair, 1, curHead, curMouth, curNose, curBeard);
        SceneManager.LoadScene("Street");
        //DontDestroyOnLoad();
    }
}
