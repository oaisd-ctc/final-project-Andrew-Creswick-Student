using KinematicCharacterController.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] Door door;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<InputHandlerNoMovement>(out InputHandlerNoMovement controller))
        {
            if(!door.IsOpen)
            {
                door.Open(other.transform.position);
            }
        }
        Debug.Log("Got Hit by a collider");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<InputHandlerNoMovement>(out InputHandlerNoMovement controller))
        {
            if (door.IsOpen)
            {
                door.Close();
            }
        }
    }
}
