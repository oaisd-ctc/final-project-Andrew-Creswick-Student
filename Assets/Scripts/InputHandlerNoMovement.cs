using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerNoMovement : MonoBehaviour
{
    public bool ControllingDrone = false;
    [SerializeField] PlayerInteraction playerInteractionB;
    [SerializeField] DroneConsole control;
    // Start is called before the first frame update
    void Start()
    {
        if (playerInteractionB == null)
        {
            playerInteractionB = GetComponent<PlayerInteraction>();
        }
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (ControllingDrone)
            {
                Debug.Log("Removed control of the drone");
                control.TakeControl();
            }
        }
    }
}
