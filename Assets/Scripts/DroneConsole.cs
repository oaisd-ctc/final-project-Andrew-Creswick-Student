using KinematicCharacterController.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneConsole : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Camera playerCamera;
    [SerializeField] ExamplePlayer playerMovementInputs;
    [SerializeField] CarBehaviour car;
    [SerializeField] Camera carCamera;
    [SerializeField] InputHandlerNoMovement standardInput;
    [SerializeField] public bool ControllingDrone = false;
    [SerializeField] public bool CanControlDrone = true;
    
    public void TakeControl()
    {
        if(!ControllingDrone && CanControlDrone)
        {
            player.SetActive(false);
            playerCamera.gameObject.SetActive(false);
            playerMovementInputs.enabled = true;
            car.enabled = true;
            carCamera.enabled = true;
            ControllingDrone = true;
            standardInput.ControllingDrone = true;
        }
        else
        {
            player.SetActive(true);
            playerCamera.gameObject.SetActive(true);
            playerMovementInputs.enabled=true;
            car.enabled = false;
            carCamera.enabled = false;
            ControllingDrone = false;
            standardInput.ControllingDrone = false;
        }
    }
}
