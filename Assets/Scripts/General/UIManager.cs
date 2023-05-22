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
    public PanelEndPeriod panelEndPeriod;

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
        panelEndPeriod.gameObject.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void GoToStateInGame()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(true);
        panelEndPeriod.gameObject.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void GoToStateEndPeriod()
    {
        // Update All comments
        panelEndPeriod.UpdateComment("Innovation", (int)Player.instance.innovation.innovationBar.innovationBar.value, Player.instance.innovation.curInnovation);
        panelEndPeriod.UpdateComment("Finance", (int)Player.instance.money.moneyBar.moneyBar.value, Player.instance.money.curMoney);
        panelEndPeriod.UpdateComment("Popularity", (int)Player.instance.people.peopleBar.peopleBar.value, Player.instance.people.curPeople);
        panelEndPeriod.UpdateComment("Political alliance", (int)Player.instance.political.politicalBar.politicalBar.value, Player.instance.political.curPolitical);
        panelEndPeriod.UpdateComment("Environment", (int)Player.instance.environment.environmentBar.environmentBar.value, Player.instance.environment.curEnvironment);

        /*
        Player.instance.money.UpdateBar();
        Player.instance.innovation.UpdateBar();
        Player.instance.environment.UpdateBar();
        Player.instance.people.UpdateBar();
        Player.instance.political.UpdateBar();
        */

        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(false);
        panelEndPeriod.gameObject.SetActive(true);
        panelGameOver.SetActive(false);
    }

    public void GoToStateGameOver()
    {
        panelWelcomePage.SetActive(false);
        panelInGame.gameObject.SetActive(false);
        panelEndPeriod.gameObject.SetActive(false);
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
