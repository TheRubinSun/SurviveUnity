using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ActionsButtons : MonoBehaviour
{
    public delegate void DelAdd();
    public static event DelAdd OneAction;

    //[SerializeField] private BarNeed barNeedScript;
    //[SerializeField] private TimeStata timeStataScript;
    //[SerializeField] private Face faceScript;
    //[SerializeField] private MainLogic mainLogicScript;
    //[SerializeField] private PlayerPanel playerPanelScript;
    
    void Start()
    {
        OneAction?.Invoke();
    }
 
    private void OnEnable()
    {
        GameEvents.ExecuteButton += AddAction;

    }
    private void OnDisable()
    {
        GameEvents.ExecuteButton -= AddAction;
    }

    public void AddAction()
    {
        Player.CurActionDay++;
        //UpdateAfterAction();
        OneAction?.Invoke();
    }
    private void UpdateAfterAction()
    {
        //mainLogicScript.AllUpdate();
        //barNeedScript.UpdateBars();
        //timeStataScript.UpdateTime();
        //faceScript.UpdateFace();
        //mainLogicScript.AllUpdate();
        //playerPanelScript.UpdateInfo();
    }
    public void AddActions(int count)
    {
        for (int i = 0; i < count; i++) AddAction();
    }
    public void AddDay()
    {
        AddActions(3);
        UpdateAfterAction();
    }
    public void SailtyEdit()
    {
        Player.sailty -= 10;
        AddAction();
    }
    public void HealthEdit()
    {
        Player.health -= 10;
        AddAction();
    }
    public void HappinessEdit()
    {
        Player.hapiness -= 10;
        AddAction();
    }
    public void CutBread()
    {
        Player.lvlBread = 0;
        AddAction();
    }


   
}
