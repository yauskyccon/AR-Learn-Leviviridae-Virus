using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class HyperlinkHandler : MonoBehaviour, IPointerClickHandler
{
    // Reference to the UI Text component
    public Text uiText;

    // URL to redirect the user to
    private string hyperlinkURL = "https://viralzone.expasy.org/163";

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial text with the clickable word
        uiText.text = "Leviviridae Family";

        // Add a click event listener
        AddEventTriggerListener(uiText.gameObject, EventTriggerType.PointerClick, OnLinkClick);
    }

    // Handle the click on the link
    public void OnLinkClick(BaseEventData eventData)
    {
        // Open the hyperlink URL
        Application.OpenURL(hyperlinkURL);
    }

    // Correct implementation of IPointerClickHandler
    public void OnPointerClick(PointerEventData eventData)
    {
        // Handle pointer click if needed
    }

    // Helper method to add an EventTrigger listener
    private void AddEventTriggerListener(GameObject go, EventTriggerType eventType, UnityAction<BaseEventData> callback)
    {
        EventTrigger trigger = go.GetComponent<EventTrigger>();
        if (trigger == null)
        {
            trigger = go.AddComponent<EventTrigger>();
        }

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = eventType;
        entry.callback.AddListener((eventData) => callback.Invoke((BaseEventData)eventData));
        trigger.triggers.Add(entry);
    }
}

