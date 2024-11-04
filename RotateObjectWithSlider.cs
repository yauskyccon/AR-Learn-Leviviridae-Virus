using UnityEngine;
using UnityEngine.UI;

public class RotateObjectWithSlider : MonoBehaviour
{
    public GameObject Leviviridae;
    public Slider Slider;

    void Update()
    {
        // Get the slider value and use it to control the rotation of the AR object
        float rotationValue = Slider.value * 360f; // Convert slider value to degrees
        Leviviridae.transform.rotation = Quaternion.Euler(0f, rotationValue, 0f);
    }
}
