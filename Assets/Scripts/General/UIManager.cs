using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelWelcomePage;
    public PanelInGame panelInGame;
    public GameObject panelGameOver;

    private static UIManager _instance;
    public static UIManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }
            return _instance;
        }
    }

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
        panelInGame.gameObject.SetActive(false);
    }

    public void GoToStateInGame()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(true);
    }
}
