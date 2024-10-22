using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize;

    void Start()
    {
        for ( int i = 0; i < poolSize; i++)
        {
            GameObject go = Instantiate(prefab);
            go.SetActive(false);
        }
    }

    public GameObject Get()
    {
        foreach (GameObject go in pool)
        {
            if (!go.activeInHierarchy)
            {
                go.SetActive(true);
                return go;
            }
        }
        return null;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
    }
}

public class ObjectPoolManager : MonoBehaviour
{
    private Dictionary<string, ObjectPool> pools = new Dictionary<string, ObjectPool>();

    public GameObject Get(string key)
    {
        if (pools.ContainsKey(key))
        {
            return pools[key].Get();
        }
        else
        {
            Debug.LogError("해당 키의 오브젝트 풀이 존재하지 않습니다: " + key);
            return null;
        }
    }
    public void Release(string key, GameObject obj)
    {
        if (pools.ContainsKey(key))
        {
            pools[key].Release(obj);
        }
        else
        {
            Debug.LogError("해당 키의 오브젝트 풀이 존재하지 않습니다: " + key);
        }
    }
}