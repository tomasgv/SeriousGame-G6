using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleBar : MonoBehaviour
{
    public Slider peopleBar;
    public People playerPeople;

    private void Start()
    {
        playerPeople = GameObject.FindGameObjectWithTag("Player").GetComponent<People>();
        peopleBar = GetComponent<Slider>();
        peopleBar.maxValue = playerPeople.maxPeople;
        peopleBar.value = playerPeople.maxPeople;
    }

    public void SetPeople(int value)
    {
        peopleBar.value = value;
    }
}