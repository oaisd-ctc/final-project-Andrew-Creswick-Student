using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Events;
public class DetectItem : MonoBehaviour
{
    [SerializeField] private string itemTagToDetect = "";
    public UnityEvent OnObjectDetected = new UnityEvent();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(itemTagToDetect))
        {
            OnObjectDetected.Invoke();
            Destroy(other.gameObject);
        }
    }
}
