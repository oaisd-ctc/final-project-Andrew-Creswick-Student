using KinematicCharacterController.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] Door door;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<InputHandlerNoMovement>(out InputHandlerNoMovement controller) || other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            if(!door.IsOpen)
            {
                door.Open(other.transform.position);
            }
        }
        //Debug.Log("Got Hit by a collider");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<InputHandlerNoMovement>(out InputHandlerNoMovement controller) || other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            if (door.IsOpen)
            {
                door.Close();
            }
        }
    }
}
