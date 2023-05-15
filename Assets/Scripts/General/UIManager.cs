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
    public GameObject panelEndPeriod;

    // Actor UI
    public GameObject ActorName;
    public GameObject ActorDialog;
    public GameObject ActorImage;

    public GameObject RightKeyText;
    public GameObject LeftKeyText;

    // Date Text
    public GameObject Date;
    public GameObject ResultsDate;

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

    public void GoToStateWelcome()
    {
        panelWelcomePage.SetActive(true);
        panelInGame.gameObject.SetActive(false);
        panelEndPeriod.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void GoToStateInGame()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(true);
        panelEndPeriod.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void GoToStateEndPeriod()
    {
        Player.instance.money.UpdateBar();
        Player.instance.innovation.UpdateBar();
        Player.instance.environment.UpdateBar();
        Player.instance.people.UpdateBar();
        Player.instance.political.UpdateBar();

        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(false);
        panelEndPeriod.SetActive(true);
        panelGameOver.SetActive(false);
    }

    public void GoToStateGameOver()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(false);
        panelEndPeriod.SetActive(false);
        panelGameOver.SetActive(true);
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

    public void SetResultsDate(int week)
    {
        TextMeshProUGUI ResultsDate1 = ResultsDate.GetComponent<TextMeshProUGUI>();
        ResultsDate1.text = "Week " + week;
    }
}
