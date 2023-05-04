using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innovation : MonoBehaviour
{
    public int curInnovation = 0;
    public int maxInnovation = 100;

    public InnovationBar innovationBar;

    void Start()
    {
        curInnovation = maxInnovation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreaseInnovation(10);
        }
    }

    public void DecreaseInnovation(int points)
    {
        curInnovation -= points;

        innovationBar.SetInnovation(curInnovation);
    }
}
