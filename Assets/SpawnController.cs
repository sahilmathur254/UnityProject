using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{

    public GameObject Zombie;
    public Button startBtn;

    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(startInvoke);
    }

    // Update is called once per frame
    void startInvoke()
    {
        InvokeRepeating("spawn", 0f, 5f);
    }

    void spawn()
    {
        Vector3 position = new Vector3(Random.Range(-10f, 10f), Random.Range(-3f, 3f), Random.Range(-10f, 10f));
        Instantiate(Zombie,position,Quaternion.Euler(0,0,0));
    }
}
