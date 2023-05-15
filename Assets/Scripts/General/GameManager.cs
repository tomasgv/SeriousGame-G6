using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int currentDay;
    public int currentWeek;

    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
        currentWeek = 1;
        UIManager.instance.SetDate(currentWeek, currentDay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDay()
    {
        currentDay++;
        Debug.Log("Day: " + currentDay);
        UIManager.instance.SetDate(currentWeek, currentDay);
    }
}
