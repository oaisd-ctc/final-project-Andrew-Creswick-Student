using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    [SerializeField] private GameObject[] itemList;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    public GameObject ReturnRandom()
    {
        if(itemList.Length > 0)
        {
            int RandomOption = Random.Range(0, itemList.Length);
            return itemList[RandomOption];
        } else
        {
            return null;
        }
        

    }
}
