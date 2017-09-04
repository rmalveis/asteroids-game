using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class scoreScript : MonoBehaviour
{
    public int Score = 0;
    private GUIText _guiText;

    // Use this for initialization
    void Start()
    {
        _guiText = GetComponent<GUIText>();
    }

    // Update is called once per frame
    void Update()
    {
        _guiText.text = "Score: " + Score;
    }
}