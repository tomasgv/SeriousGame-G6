using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Political : MonoBehaviour
{
    public int curPolitical = 0;
    public int maxPolitical = 100;

    public PoliticalBar politicalBar;

    void Start()
    {
        curPolitical = maxPolitical;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreasePolitical(10);
        }
    }

    public void DecreasePolitical(int points)
    {
        curPolitical -= points;

        politicalBar.SetPolitical(curPolitical);
    }
}
