using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public int curEnvironment = 0;
    public int maxEnvironment = 100;

    public EnvironmentBar environmentBar;

    void Start()
    {
        curEnvironment = maxEnvironment;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreaseEnvironment(10);
        }
    }

    public void DecreaseEnvironment(int points)
    {
        curEnvironment -= points;

        environmentBar.SetEnvironment(curEnvironment);
    }
}
