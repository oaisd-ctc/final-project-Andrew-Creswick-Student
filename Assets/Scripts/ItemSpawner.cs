using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public ItemList itemList;
    public GameObject itemPrefab;
    private void Start()
    {
        itemList = FindAnyObjectByType<ItemList>();
        itemPrefab = itemList.ReturnRandom();
        if(itemPrefab != null)
        {
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
