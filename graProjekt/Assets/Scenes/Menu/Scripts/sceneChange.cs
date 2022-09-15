using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string path = "Scenes/game/Game";

    public void goToGame()
    {
        SceneManager.LoadScene(path, LoadSceneMode.Single);
    }
}
