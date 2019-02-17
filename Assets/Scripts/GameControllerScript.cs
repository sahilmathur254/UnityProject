using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public GameObject bloodyScreen;
    public Text healthText;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {

        if(health<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void zombieAtttack(bool zombieIsThere)
    {
        bloodyScreen.gameObject.SetActive(true);
        StartCoroutine(Wait2Seconds());
        health -= 5;

        string stringhealth = (health).ToString();
        healthText.text = "" + stringhealth;

        IEnumerator Wait2Seconds()
        {
            yield return new WaitForSeconds(2f);
            bloodyScreen.gameObject.SetActive(false);
        }
    }
}
