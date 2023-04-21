using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelWelcomePage;
    public GameObject panelInGame;
    public GameObject panelGameOver;

    public void LaunchLevel2()
    {
        Main main = FindObjectOfType<Main>();
        if (main != null)
        {
            main.LaunchGame(2);
        }
    }

    public void GoToStateWelcome()
    {
        panelWelcomePage.SetActive(true);
        panelInGame.SetActive(false);
    }

    public void GoToStateInGame()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.SetActive(true);
    }
}
