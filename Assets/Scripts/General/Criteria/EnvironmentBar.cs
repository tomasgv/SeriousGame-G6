using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentBar : MonoBehaviour
{
    public Slider environmentBar;
    public Environment playerEnvironment;

    private void Start()
    {
        playerEnvironment = GameObject.FindGameObjectWithTag("Player").GetComponent<Environment>();
        environmentBar = GetComponent<Slider>();
        environmentBar.maxValue = playerEnvironment.maxEnvironment;
        environmentBar.value = playerEnvironment.maxEnvironment;
    }

    public void SetEnvironment(int value)
    {
        environmentBar.value = value;
    }
}