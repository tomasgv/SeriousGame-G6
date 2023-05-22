using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public int curEnvironment = 0;
    public int maxEnvironment = 10;

    public EnvironmentBar environmentBar;
    public EnvironmentBar resultsEnvironmentBar;


    void Start()
    {
        curEnvironment = maxEnvironment;
    }

    void Update()
    {
    }

    public void UpdateEnvironment(int points)
    {
        curEnvironment += points;
        if (curEnvironment > maxEnvironment)
        {
            curEnvironment = maxEnvironment;
        }
        UpdateBar();
    }

    public void UpdateBar()
    {
        environmentBar.SetEnvironment(curEnvironment);
        resultsEnvironmentBar.SetEnvironment(curEnvironment);
    }

}
