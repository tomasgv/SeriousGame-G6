using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopularityBar : MonoBehaviour
{
    public Slider popularityBar;
    public Popularity playerPopularity;

    private void Start()
    {
        playerPopularity = GameObject.FindGameObjectWithTag("Player").GetComponent<Popularity>();
        popularityBar = GetComponent<Slider>();
        popularityBar.maxValue = playerPopularity.maxPopularity;
        popularityBar.value = playerPopularity.maxPopularity;
    }

    public void SetPopularity(int value)
    {
        popularityBar.value = value;
    }
}