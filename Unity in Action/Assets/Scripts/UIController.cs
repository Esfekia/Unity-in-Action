using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // reference the Text object in the scene to set the text property
    [SerializeField] TMP_Text scoreLabel;
   
    void Start()
    {
        
    }
      
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings()
    {
        Debug.Log("open settings");
    }
    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
}
