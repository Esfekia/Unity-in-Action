using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] Slider speedSlider;
    private void Start()
    {
        // get command has both the value to get, as well as the default value
        // in case speed was not saved previously.
        speedSlider.value = PlayerPrefs.GetFloat("Speed", 1);
    }


    // turn the object on to open the window
    public void Open()
    {
        gameObject.SetActive(true);
    }

    // deactivate this object to close the window

    public void Close()
    {
        gameObject.SetActive(false);
    }

    // triggers when the user types in the input field
    public void OnSubmitName(string name)
    {
        Debug.Log(name);
    }

    // triggers when the user adjusts the slider

    public void OnSpeedValue(float speed)
    {
        Debug.Log($"Speed: {speed}");

        // save it for future play sessions
        PlayerPrefs.SetFloat("Speed", speed);
    }

}
