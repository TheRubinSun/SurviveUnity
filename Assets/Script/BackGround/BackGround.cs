using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    private Material material;
    private Vector2 offset = Vector2.zero;
    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }
    void Update()
    {
        offset.x += 0.1f * Time.deltaTime;
        material.SetTextureOffset("_MainTex",offset);
        //this.GetComponent<Transform>().position = new Vector3(this.transform.position.x + 0.1f, 0, -10f);
    }
}
