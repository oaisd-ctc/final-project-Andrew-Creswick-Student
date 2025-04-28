using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MouseDrag))]
public class Item : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    public Item_SO itemType;
    [SerializeField] private bool itemFalling = false;
    [SerializeField] private float FallingThreshold = -10f;
    [SerializeField] private float FallingTime = 0f;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(rigidbody.velocity.y < FallingThreshold)
        {
            itemFalling = true;
        } else
        {
            itemFalling = false;
        }
        if(itemFalling)
        {
            //When this object is falling.
            FallingTime += Time.deltaTime;
        }
        else
        {
            FallingTime = 0f;
        }
        
    }
}
