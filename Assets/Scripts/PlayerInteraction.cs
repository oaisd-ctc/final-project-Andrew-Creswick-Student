using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float maxDistance = 5f;
    [SerializeField] private Text interactableName;
    private InteractionObject targetInteraction;
    [SerializeField] Transform Camera;
    [SerializeField] bool UseFancyText;
    [SerializeField] TextMeshPro FancyText;
    private void Start()
    {
        if (UseFancyText)
        {
            interactableName.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Camera.transform.position;
        Vector3 direction = Camera.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;
        if (Physics.Raycast(origin, direction, out raycastHit, maxDistance))
        {
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
            
        }
        if (targetInteraction && targetInteraction.enabled)
        {
            interactionText = targetInteraction.GetInteractionText();
        }
        if (targetInteraction == null)
        {
            FancyText.gameObject.SetActive(false);
        }
        setInteractableNameText(interactionText);
        if (UseFancyText)
        {
            FancyText.transform.position = raycastHit.point - (raycastHit.point - Camera.position).normalized * 0.01f;
            FancyText.transform.rotation = Quaternion.LookRotation((raycastHit.point - Camera.position).normalized);
        }
        
    }
    private void setInteractableNameText(string newText)
    {
        if (interactableName && interactableName.gameObject.activeSelf)
        {
            interactableName.text = newText;
        }
        else
        {
            FancyText.text = newText;
        }
        if (!FancyText.IsActive() && UseFancyText)
        {
            FancyText.gameObject.SetActive(true);
        }
    }
    public void TryInteract()
    {
        if (targetInteraction && targetInteraction.enabled)
        {
            targetInteraction.Interact();
        }
    }
}
