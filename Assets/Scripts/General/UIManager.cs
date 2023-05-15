using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelWelcomePage;
    public PanelInGame panelInGame;
    public GameObject panelGameOver;

    // Actor UI
    public GameObject ActorName;
    public GameObject ActorDialog;
    public GameObject ActorImage;

    public GameObject RightKeyText;
    public GameObject LeftKeyText;

    // Date Text
    public GameObject Date;

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

    public void SetCardText(string actorName, string actorDialog, string rightKeyText, string leftKeyText)
    {
        TextMeshProUGUI ActorName1 = ActorName.GetComponent<TextMeshProUGUI>();
        ActorName1.text = actorName;

        TextMeshProUGUI ActorDialog1 = ActorDialog.GetComponent<TextMeshProUGUI>();
        ActorDialog1.text = actorDialog;

        Image ActorImage1 = ActorImage.GetComponent<Image>();
        string dataPath = "characters/" + actorName;
        Sprite actorSprite = Resources.Load<Sprite>(dataPath);

        ActorImage1.sprite = actorSprite;

        TextMeshProUGUI RightKeyText1 = RightKeyText.GetComponent<TextMeshProUGUI>();
        RightKeyText1.text = rightKeyText;

        TextMeshProUGUI LeftKeyText1 = LeftKeyText.GetComponent<TextMeshProUGUI>();
        LeftKeyText1.text = leftKeyText;
    }

    public void SetDate(int week, int day)
    {
        TextMeshProUGUI Date1 = Date.GetComponent<TextMeshProUGUI>();
        Date1.text = "Week " + week + ", Day " + day;
    }
}
