using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBar : MonoBehaviour
{
    public Slider moneyBar;
    public Money playerMoney;

    private void Start()
    {
        playerMoney = GameObject.FindGameObjectWithTag("Player").GetComponent<Money>();
        moneyBar = GetComponent<Slider>();
        moneyBar.maxValue = playerMoney.maxMoney;
        moneyBar.value = playerMoney.maxMoney;
    }

    public void SetMoney(int value)
    {
        moneyBar.value = value;
    }
}