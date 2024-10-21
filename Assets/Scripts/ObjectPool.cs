using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

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
