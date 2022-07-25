using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objpool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        objpool = this;

        for(int i = 0; i <10; i++)
        {
            GameObject temPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(temPrefab);
            temPrefab.gameObject.SetActive(false);
        }
    }

    public void InsertQueue(GameObject pobj)
    {
        queue.Enqueue(pobj);
        pobj.gameObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject temPrefab = queue.Dequeue();
        temPrefab.gameObject.SetActive(true);

        return temPrefab;

    }
}
