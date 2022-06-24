using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // reference the Text object in the scene to set the text property
    [SerializeField] TMP_Text scoreLabel;

    [SerializeField] SettingsPopup settingsPopup;
    private int score;

    private void OnEnable()
    {
        // declare which method responds to the ENEMY_HIT event.
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnDisable()
    {
        // when an object is deactivated, remove the listener to avoid errors.
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    void Start()
    {
        // close the menu pop-up when the game starts
        settingsPopup.Close();

        // initialize the score to zero and display it on the UI
        score = 0;
        scoreLabel.text = score.ToString();
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

    private void OnEnemyHit()
    {
        // increase the score in response to the event
        score += 1;
        scoreLabel.text = score.ToString();
    }
}
