using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object";
    public UnityEvent onInteract = new UnityEvent();
    public string GetInteractionText()
    {
        return interactionText;
    }
    public void Interact()
    {
        onInteract.Invoke();
    }
}
