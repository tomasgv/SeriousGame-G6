using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public int curPeople = 0;
    public int maxPeople = 10;

    public PeopleBar peopleBar;
    public PeopleBar resultsPeopleBar;

    void Start()
    {
        curPeople = maxPeople;
    }

    void Update()
    {
    }

    public void UpdatePeople(int points)
    {
        curPeople += points;
        if (curPeople > maxPeople)
        {
            curPeople = maxPeople;
        }
    }

    public void UpdateBar()
    {
        peopleBar.SetPeople(curPeople);
        resultsPeopleBar.SetPeople(curPeople);
    }
}
