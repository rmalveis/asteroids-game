using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class scoreScript : MonoBehaviour
{
    public int Score = 0;
    public GUIText ScoreGuiText;
    public GUIText RecordGuiText;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Score > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", Score);
        }
        ScoreGuiText.fontStyle = FontStyle.Bold;
        RecordGuiText.fontStyle = FontStyle.Bold;
        ScoreGuiText.fontSize = 18;
        RecordGuiText.fontSize = 18;
        ScoreGuiText.text = "Score :" + Score;
        RecordGuiText.text = "Record: " + PlayerPrefs.GetInt("Record");

        ScoreGuiText.text = "Score: " + Score;
    }
}