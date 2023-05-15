using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DecisionCardManager : MonoBehaviour
{
    public CardList cardList;

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
        Debug.Log("Count:" + cardList.decisionCards.Count);
        Debug.Log("Index:" + index);
        DecisionCard currentCard = cardList.decisionCards[index];

        string rightKeyText = currentCard.answers[0].content;
        string leftKeyText = currentCard.answers[1].content;

        // Set UI Card text
        UIManager.instance.SetCardText(currentCard.actor, currentCard.content, rightKeyText, leftKeyText);


    }
}