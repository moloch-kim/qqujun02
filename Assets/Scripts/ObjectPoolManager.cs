using UnityEngine;
using System.Collections.Generic;

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