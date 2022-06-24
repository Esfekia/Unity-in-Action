using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopup : MonoBehaviour
{
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
    }

}
