using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class gameController : MonoBehaviour
{

    public plrController plrController;
    public Canvas GameOverCanvas;
    public Canvas youWinCanvas;
    public TMP_Text scoreN;
    // Start is called before the first frame update
    private void Awake()
    {

        if(plrController != null){

            plrController.plrIsDead += whenPlayerDies; //subs to plrisdead eventt

        }
        if (GameOverCanvas.gameObject.activeSelf)
        {

            GameOverCanvas.gameObject.SetActive(false);
        }
    }

    void whenPlayerDies(){

        GameOverCanvas.gameObject.SetActive(true);
        //scoreN.text = " " + Math.Round(Time.timeSinceLevelLoad, 2);

        if(plrController != null){

            plrController.plrIsDead -= whenPlayerDies; //unsubs

        }

    }

    public void RetryButton(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }


    public void onExitClick()
    {
    #if UNITY_EDITOR


        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    #endif
    }



}
