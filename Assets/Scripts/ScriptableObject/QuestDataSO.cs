using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest Data", menuName = "Quest/QuestDataSO")]
public class QuestDataSO : ScriptableObject
{
    [Header("QuestDataSO Info")]
    public string QuestName;
    public string QuestDetail;
    public int QuestRequiredLevel;
    public string QuestNPCName;
    public List<GameObject> QuestPrerequisites; // GameObject ¼öÁ¤

}

[CreateAssetMenu(fileName = "New Monster Quest Data", menuName = "Quest/MonsterQuestDataSO")]
public class MonsterQuestDataSO : QuestDataSO
{
    [Header("MonsterQuest Detail")]
    public string TargetName;
    public int TargetCount;

}

[CreateAssetMenu(fileName = "New Encounter Quest Data", menuName = "Quest/EncounterQuestDataSO")]
public class EncounterQuestDataSO : QuestDataSO
{
    [Header("EncounterQuest Detail")]
    public Transform TriggerPoint;
    public Event EncounterEvent;
}