using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIMANAGER uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateMoney(float moneyToAdd)
    {
        money += moneyToAdd;
    }
}
