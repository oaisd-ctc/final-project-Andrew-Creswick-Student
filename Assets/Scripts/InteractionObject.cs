using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object";
    [SerializeField] private Door door;
    public UnityEvent onInteract = new UnityEvent();
    
    bool IsDoor = false;
    private void Start()
    {
        door = GetComponent<Door>();
        if (door)
        {
            IsDoor = true;
        }
    }
    public string GetInteractionText()
    {
        return interactionText;
    }
    public void Interact()
    {
        if (IsDoor==false) {
            onInteract.Invoke();
        }
        else
        {
            if(door.IsOpen)
            {
                door.Close();
            } else
            {
                door.Open(transform.position);
            }
            
        }
    }
}
