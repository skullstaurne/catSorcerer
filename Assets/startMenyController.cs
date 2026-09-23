using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class startMenyController : MonoBehaviour
{

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



    public void onExitClick() {
#if UNITY_EDITOR


        UnityEditor.EditorApplication.isPlaying = false;

#else
        Application.Quit();

#endif
    }

    void update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
