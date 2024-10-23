using UnityEngine;


public class QuestManager : MonoBehaviour
{

    private static QuestManager instance;
    public QuestDataSO[] quests;

    private void Start()
    {
        int i = 0;
        foreach(QuestDataSO info in quests)
        {
            i++;
            Debug.Log($"Quest{i}: {info.QuestName}, {info.QuestDetail}");
        }    
    }

    public QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("QuestManager");
                    instance = obj.AddComponent<QuestManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}