using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string Scene;

    // Attach this script to your button
    public Button yourButton;

    void Start()
    {
        // Add a listener to your button
        yourButton.onClick.AddListener(ChangeSceneOnClick);
    }

    void ChangeSceneOnClick()
    {
        // Change the scene when the button is clicked
        SceneManager.LoadScene(Scene);
    }
}
