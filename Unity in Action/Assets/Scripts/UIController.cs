using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // reference the Text object in the scene to set the text property
    [SerializeField] TMP_Text scoreLabel;

    [SerializeField] SettingsPopup settingsPopup;
   
    void Start()
    {
        // close the menu pop-up when the game starts
        settingsPopup.Close();
    }
      
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings()
    {
        //Debug.Log("open settings");
        // replace the debug text with the pop-up's method
        settingsPopup.Open();

    }
    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
}
