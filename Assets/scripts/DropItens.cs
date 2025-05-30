using System.Collections.Generic;
using UnityEngine;

public class DropItens : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> items;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InstantiateItems();
            Destroy(gameObject);
        }
    }

    void InstantiateItems()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        int itemCount = Random.Range(1, items.Count + 1);

        for (int i = 0; i < itemCount; i++)
        {
            int itemIndex = Random.Range(0, items.Count);
            Instantiate(items[itemIndex], (transform.position + Vector3.up + Vector3.right + new Vector3Int(i, 0, 0)), Quaternion.identity);
        }
    }
}
