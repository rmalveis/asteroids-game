using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 30;
        var lblTitle = new Rect(50, 30, 270, 30);
        var btnFirstPhase = new Rect(50, 100, buttonWidth, buttonHeight);
        var btnQuit = new Rect(50, 150, buttonWidth, buttonHeight);
        var btnCredits = new Rect(20, 300, 250, 50);

        GUI.Label(lblTitle, "Menu Principal - Jogo de Nave com o Unity3D");
        GUI.Label(btnCredits, "Adaptaçao de Ribamar FS dos tutoriais do Equilibre Cursos e lessmilk.com");

        if (GUI.Button(btnFirstPhase, "Primeira Fase"))
        {
            SceneManager.LoadScene("fase1");
        }

        if (GUI.Button(btnQuit, "Sair"))
        {
            Application.Quit();
        }
    }
}