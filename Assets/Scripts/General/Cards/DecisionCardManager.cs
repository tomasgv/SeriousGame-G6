using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DecisionCardManager : MonoBehaviour
{
    public CardList cardList;
    public DecisionCard currentCard;

    private static DecisionCardManager _instance;
    public static DecisionCardManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<DecisionCardManager>();
            }
            return _instance;
        }
    }


    void Start()
    {
        string filePath = Application.dataPath + "/Cards.json";
        string jsonString = File.ReadAllText(filePath);
        Debug.Log("text:" + jsonString);
        cardList = JsonUtility.FromJson<CardList>(jsonString);
    }

    public void GetRandomDecisionCard()
    {
        int index = Random.Range(0, cardList.decisionCards.Count);

        currentCard = cardList.decisionCards[index];
        cardList.decisionCards.RemoveAt(index);

        Debug.Log("cards:" + cardList.decisionCards.Count);

        string rightKeyText = currentCard.answers[0].content;
        string leftKeyText = currentCard.answers[1].content;

        // Set UI Card text
        UIManager.instance.SetCardText(currentCard.actor, currentCard.content, rightKeyText, leftKeyText);
    }
}