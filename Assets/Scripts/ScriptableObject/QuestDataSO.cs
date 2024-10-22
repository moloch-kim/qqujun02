using System.Collections.Generic;
using UnityEngine;

public class QuestDataSO : ScriptableObject
{
    [Header("QuestDataSO Info")]
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<GameObject> QuestPrerequisites; // GameObject ¼öÁ¤

}

public class MonsterQuestDataSO : QuestDataSO
{
    [Header("MonsterQuest Detail")]
    public string TargetName;
    public int TargetCount;

}

public class EncounterQuestDataSO : QuestDataSO
{
    [Header("EncounterQuest Detail")]
    public Transform TriggerPoint;
    public Event EncounterEvent;
}