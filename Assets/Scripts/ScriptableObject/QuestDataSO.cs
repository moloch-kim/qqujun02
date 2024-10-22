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
