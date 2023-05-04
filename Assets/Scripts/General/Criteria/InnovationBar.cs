using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InnovationBar : MonoBehaviour
{
    public Slider innovationBar;
    public Innovation playerInnovation;

    private void Start()
    {
        playerInnovation = GameObject.FindGameObjectWithTag("Player").GetComponent<Innovation>();
        innovationBar = GetComponent<Slider>();
        innovationBar.maxValue = playerInnovation.maxInnovation;
        innovationBar.value = playerInnovation.maxInnovation;
    }

    public void SetInnovation(int value)
    {
        innovationBar.value = value;
    }
}