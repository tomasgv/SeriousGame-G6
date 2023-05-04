using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlliancesBar : MonoBehaviour
{
    public Slider alliancesBar;
    public Alliances playerAlliances;

    private void Start()
    {
        playerAlliances = GameObject.FindGameObjectWithTag("Player").GetComponent<Alliances>();
        alliancesBar = GetComponent<Slider>();
        alliancesBar.maxValue = playerAlliances.maxAlliances;
        alliancesBar.value = playerAlliances.maxAlliances;
    }

    public void SetAlliances(int value)
    {
        alliancesBar.value = value;
    }
}