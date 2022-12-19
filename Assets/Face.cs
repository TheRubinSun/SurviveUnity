using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Face : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UpdateFace();
    }
    
    public SpriteAtlas spriteAtlasHead;
    public SpriteRenderer spriteRendererHead;

    public SpriteAtlas spriteAtlasHair;
    public SpriteRenderer spriteRendererHair;   

    public SpriteAtlas spriteAtlasNose;
    public SpriteRenderer spriteRendererNose;

    public SpriteAtlas spriteAtlasMouth;
    public SpriteRenderer spriteRendererMouth;

    public SpriteAtlas spriteAtlasEye;
    public SpriteRenderer spriteRendererEye;

    public SpriteAtlas spriteAtlasBeard;
    public SpriteRenderer spriteRendererBeard;

    public void UpdateFace()
    {
        spriteRendererHead.sprite = spriteAtlasHead.GetSprite($"Head {Player.GetHead()}");
        spriteRendererHair.sprite = spriteAtlasHair.GetSprite($"Hair {Player.GetHair()}");
        spriteRendererNose.sprite = spriteAtlasNose.GetSprite($"Nose {Player.GetNose()}");
        spriteRendererMouth.sprite = spriteAtlasMouth.GetSprite($"Mouth {Player.GetMouth()}");
        spriteRendererEye.sprite = spriteAtlasEye.GetSprite($"Eye {Player.GetEye()}");
        spriteRendererBeard.sprite = spriteAtlasBeard.GetSprite($"Beard {Player.GetLvlBread()}");
        
    }


}
