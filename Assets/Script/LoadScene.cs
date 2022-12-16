using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
    }
    public void LoadProfile()
    {
        SceneManager.LoadScene("Profil");
    }
    public void LoadStreet()
    {
        SceneManager.LoadScene("Street");
    }
}
