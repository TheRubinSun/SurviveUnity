using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsButtons : MonoBehaviour
{
    [SerializeField] private BarNeed barNeedScript;
    [SerializeField] private TimeStata timeStataScript;
    [SerializeField] private Face faceScript;
    [SerializeField] private MainLogic mainLogicScript;

    // Start is called before the first frame update
    void Start()
    {
    }
 
    // Update is called once per frame
    void Update()
    {
        

    }
    
    public void AddAction()
    {
        MainLogic.players[0].AddActions();
        UpdateAfterAction();
    }
    private void UpdateAfterAction()
    {
        mainLogicScript.AllUpdate();
        barNeedScript.UpdateBars();
        timeStataScript.UpdateTime();
        faceScript.UpdateFace();
        mainLogicScript.AllUpdate();
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
        Player.lvlBread = 1;
        AddAction();
    }
   
}
