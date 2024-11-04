using UnityEngine;
using UnityEngine.UI;

public class TextInteraction : MonoBehaviour
{
    public Text Prevention;
    public AudioClip unpause;

    private bool isTextVisible = false;

    void Update()
    {
        // Check for user tap
        if (Input.GetMouseButtonUp(0))
        {
            // Raycast to check if the user tapped on the AR object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Toggle visibility of the text
                isTextVisible = !isTextVisible;

                // Show or hide the UI text
                if (Prevention != null)
                {
                    Prevention.gameObject.SetActive(isTextVisible);
                }

                // Play a tap sound
                if (unpause != null)
                {
                    AudioSource.PlayClipAtPoint(unpause, transform.position);
                }
            }
        }
    }
}
