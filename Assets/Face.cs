using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

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
        spriteRendererHead.sprite = spriteAtlasHead.GetSprite($"Head {MainLogic.players[0].GetHead()}");
        spriteRendererHair.sprite = spriteAtlasHair.GetSprite($"Hair {MainLogic.players[0].GetHair()}");
        spriteRendererNose.sprite = spriteAtlasNose.GetSprite($"Nose {MainLogic.players[0].GetNose()}");
        spriteRendererMouth.sprite = spriteAtlasMouth.GetSprite($"Mouth {MainLogic.players[0].GetMouth()}");
        spriteRendererEye.sprite = spriteAtlasEye.GetSprite($"Eye {MainLogic.players[0].GetEye()}");
        spriteRendererBeard.sprite = spriteAtlasBeard.GetSprite($"Beard {MainLogic.players[0].GetLvlBread()}");
        
    }


}
