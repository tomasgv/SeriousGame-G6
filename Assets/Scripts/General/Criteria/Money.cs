using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int curMoney = 0;
    public int maxMoney = 100;

    public MoneyBar moneyBar;

    void Start()
    {
        curMoney = maxMoney;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreaseMoney(10);
        }
    }

    public void DecreaseMoney(int points)
    {
        curMoney -= points;

        moneyBar.SetMoney(curMoney);
    }
}
