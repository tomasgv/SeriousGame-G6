using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popularity : MonoBehaviour
{
    public int curPopularity = 0;
    public int maxPopularity = 100;

    public PopularityBar popularityBar;

    void Start()
    {
        curPopularity = maxPopularity;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DecreasePopularity(10);
        }
    }

    public void DecreasePopularity(int points)
    {
        curPopularity -= points;

        popularityBar.SetPopularity(curPopularity);
    }
}
