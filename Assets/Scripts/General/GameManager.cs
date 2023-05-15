using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int currentDay;
    public int currentWeek;
    public List<Decision> decisionList;

    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
        currentWeek = 1;
        UIManager.instance.SetDate(currentWeek, currentDay);
        decisionList = new List<Decision>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDay()
    {
        if (currentDay == 5)
        {
            UIManager.instance.GoToStateEndPeriod();
            UIManager.instance.SetResultsDate(currentWeek);
            
        } else
        {
            currentDay++;
            UIManager.instance.SetDate(currentWeek, currentDay);
            DecisionCardManager.instance.GetRandomDecisionCard();
            
        }
        
    }

    public void NextWeek()
    {
        if(IsGameOver())
        {
            UIManager.instance.GoToStateGameOver();
        } else
        {
            currentDay = 1;
            currentWeek++;
            UIManager.instance.GoToStateInGame();
            UIManager.instance.SetDate(currentWeek, currentDay);
        }
    }

    private bool IsGameOver()
    {
        return Player.instance.money.curMoney <= 0 || Player.instance.innovation.curInnovation <= 0 || Player.instance.people.curPeople <= 0 || Player.instance.environment.curEnvironment <= 0 || Player.instance.political.curPolitical <= 0;
    }

    public void UpdateValues(int decisionIndex)
    {
        DecisionCard currentCard = DecisionCardManager.instance.currentCard;

        Player.instance.money.UpdateMoney(currentCard.answers[decisionIndex].values.money);
        Player.instance.innovation.UpdateInnovation(currentCard.answers[decisionIndex].values.innovation);
        Player.instance.people.UpdatePeople(currentCard.answers[decisionIndex].values.people);
        Player.instance.environment.UpdateEnvironment(currentCard.answers[decisionIndex].values.environment);
        Player.instance.political.UpdatePolitical(currentCard.answers[decisionIndex].values.political);

        Decision newDecision = gameObject.AddComponent<Decision>();
        newDecision.decision = decisionIndex;
        newDecision.cardId = currentCard.id;

        decisionList.Add(newDecision);
        Debug.Log("Decisions taken: " + decisionList.Count);
        Debug.Log("id:" + newDecision.cardId + ", decision:" + newDecision.decision);
    }


}
