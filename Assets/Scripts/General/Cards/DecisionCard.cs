using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class DecisionCard
{
    public string id;
    public List<List<string>> dependency;
    public string actor;
    public float prob;
    public string content;
    public List<Answer> answers;
}

