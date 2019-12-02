using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
