using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int curMoney = 0;
    public int maxMoney = 10;

    public MoneyBar moneyBar;
    public MoneyBar resultsMoneyBar;

    void Start()
    {
        curMoney = maxMoney;
    }

    void Update()
    {
    }

    public void UpdateMoney(int points)
    {
        curMoney += points;
        if (curMoney > maxMoney)
        {
            curMoney = maxMoney;
        }
    }

    public void UpdateBar()
    {
        moneyBar.SetMoney(curMoney);
        resultsMoneyBar.SetMoney(curMoney);
    }
}
