using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerNoMovement : MonoBehaviour
{
    PlayerInteraction playerInteractionB;
    // Start is called before the first frame update
    void Start()
    {
       playerInteractionB = GetComponent<PlayerInteraction>();  
    }

    // Update is called once per frame
    void Update()
    {
        HandleInteractionInputB();
    }
    void HandleInteractionInputB()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            playerInteractionB.TryInteract();
        }
    }
}
