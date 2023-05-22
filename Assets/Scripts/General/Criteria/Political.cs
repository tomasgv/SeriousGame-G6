using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Political : MonoBehaviour
{
    public int curPolitical = 0;
    public int maxPolitical = 10;

    public PoliticalBar politicalBar;
    public PoliticalBar resultsPoliticalBar;

    void Start()
    {
        curPolitical = maxPolitical;
    }

    void Update()
    {
    }

    public void UpdatePolitical(int points)
    {
        curPolitical += points;
        if (curPolitical > maxPolitical)
        {
            curPolitical = maxPolitical;
        }
        UpdateBar();
    }

    public void UpdateBar()
    {
        politicalBar.SetPolitical(curPolitical);
        resultsPoliticalBar.SetPolitical(curPolitical);
    }
}
