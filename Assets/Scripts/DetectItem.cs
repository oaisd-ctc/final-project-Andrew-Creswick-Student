using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Events;
public class DetectItem : MonoBehaviour
{
    [SerializeField] private string itemTagToDetect = "";
    public UnityEvent OnObjectDetected = new UnityEvent();
    public GameManager gameManager;
    private Item item;
    private int goldAmount = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(itemTagToDetect))
        {
            OnObjectDetected.Invoke();
            Destroy(other.gameObject);
            item = other.gameObject.GetComponent<Item>();
            goldAmount = item.itemType.value;
            if (gameManager != null)
            {
                gameManager.ChangeGoldAmount(goldAmount);
            }
        }
    }
}
