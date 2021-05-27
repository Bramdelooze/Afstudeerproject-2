using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnButtonPress : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GetInput())
            SceneManager.LoadScene(1);
    }

    bool GetInput()
    {
        if (Input.anyKey)
            return true;
        else
            return false;
    }
}
