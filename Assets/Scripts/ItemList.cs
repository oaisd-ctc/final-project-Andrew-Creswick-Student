using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public DynamicArray<GameObject> itemList;
    // Start is called before the first frame update
    void Start()
    {
        CollectItems();
        
    }
    public void ReturnRandom()
    {
        int number = Random.Range(1,itemList.count);
    }
    private void CollectItems()
    {
        itemList = new DynamicArray<GameObject>();
        for(int i = 0; i < transform.childCount; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            itemList.Add(child);
        }
    }
}
