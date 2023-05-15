using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innovation : MonoBehaviour
{
    public int curInnovation = 0;
    public int maxInnovation = 10;

    public InnovationBar innovationBar;
    public InnovationBar resultsInnovationBar;


    void Start()
    {
        curInnovation = maxInnovation;
    }

    void Update()
    {
    }

    public void UpdateInnovation(int points)
    {
        curInnovation += points;
        if(curInnovation > maxInnovation)
        {
            curInnovation = maxInnovation;
        }
    }

    public void UpdateBar()
    {
        innovationBar.SetInnovation(curInnovation);
        resultsInnovationBar.SetInnovation(curInnovation);
    }
}
