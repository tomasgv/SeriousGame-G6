using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public int curPeople = 0;
    public int maxPeople = 100;

    public PeopleBar peopleBar;

    void Start()
    {
        curPeople = maxPeople;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreasePeople(10);
        }
    }

    public void DecreasePeople(int points)
    {
        curPeople -= points;

        peopleBar.SetPeople(curPeople);
    }
}
