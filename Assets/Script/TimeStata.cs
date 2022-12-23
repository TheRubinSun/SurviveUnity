using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.U2D;

public class TimeStata : MonoBehaviour
{
    //public GameObject TimeIcon;
    public Text TextTime;
    public SpriteAtlas timeDayAtlas;
    public SpriteRenderer spriteRendererTime;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTime();
    }
    private void OnEnable()
    {
        ActionsButtons.OneAction += UpdateTime;
    }
    private void OnDisable()
    {
        ActionsButtons.OneAction -= UpdateTime;
    }

    // Update is called once per frame
    public void UpdateTime()
    {
        if (Player.CurActionDay == 0)
        {
            spriteRendererTime.sprite = timeDayAtlas.GetSprite("12");
            TextTime.text = "1/3";
            TextTime.color = new Color(255, 255, 255);
        }
        else if (Player.CurActionDay == 1)
        {
            spriteRendererTime.sprite = timeDayAtlas.GetSprite("11");
            TextTime.text = "2/3";
            TextTime.color = new Color(0, 0, 0);
        }
        else if (Player.CurActionDay == 2)
        {
            spriteRendererTime.sprite = timeDayAtlas.GetSprite("13");
            TextTime.text = "3/3";
            TextTime.color = new Color(255, 255, 255);
        }

    }
}
