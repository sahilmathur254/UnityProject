using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 class LoadNewGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button newGame;
        void Start()
    {
        newGame.onClick.AddListener(loadGame);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadGame()
    {
        SceneManager.LoadScene("UnityARKitScene");
    }
}
