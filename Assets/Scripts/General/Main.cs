using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public enum STATE { WELCOME_PAGE, IN_GAME, GAME_OVER };

    public STATE state;

    public UIManager uiManager;
    public Player player;

    private static Main _instance;
    public static Main instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<Main>();
            }
            return _instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Main is starting"); // can be LogWarning to show in a different color
        uiManager.GoToStateWelcome();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.WELCOME_PAGE:
                UpdateWelcome();
                break;
            case STATE.IN_GAME:
                UpdateInGame();
                break;
        }
        
    }

    void UpdateWelcome()
    {
        // nothing here yet
    }

    void UpdateInGame()
    {
        //nothing here yet
    }

    public void LaunchGame (int numLevel)
    {
        state = STATE.IN_GAME;
        uiManager.GoToStateInGame();
    }

    public void EnnemiesAllGone ()
    {
        state = STATE.GAME_OVER;
    }
}
