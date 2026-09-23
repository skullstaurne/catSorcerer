using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class restartEndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onStartClick()
    {
        SceneManager.LoadScene("testLVL");


        //SceneManager.LoadScene("howToPlay");



        // SceneManager.LoadScene("mainMenu");



    }

    public void backToMenu()
    {



        SceneManager.LoadScene("mainMenu");



    }

    public void restart()
    {
        SceneManager.LoadScene("testLVL");


        //SceneManager.LoadScene("howToPlay");



        // SceneManager.LoadScene("mainMenu");



    }



    public void onExitClick()
    {
    #if UNITY_EDITOR


        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    #endif
    }

}
