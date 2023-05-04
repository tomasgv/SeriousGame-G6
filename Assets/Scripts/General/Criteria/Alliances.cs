using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliances : MonoBehaviour
{
    public int curAlliances = 0;
    public int maxAlliances = 100;

    public AlliancesBar alliancesBar;

    void Start()
    {
        curAlliances = maxAlliances;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreaseAlliances(10);
        }
    }

    public void DecreaseAlliances(int points)
    {
        curAlliances -= points;

        alliancesBar.SetAlliances(curAlliances);
    }
}
