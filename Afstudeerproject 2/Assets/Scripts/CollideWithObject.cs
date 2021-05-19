using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideWithObject : MonoBehaviour
{
    public string meteorite;
    public string planet;

    private FocusBar focusBarScript;

    private void Start()
    {
        focusBarScript = FindObjectOfType<FocusBar>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == meteorite)
        {
            Destroy(collider.gameObject);
            //gameObject.SetActive(false);
            focusBarScript.MoveSlider(-4);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space) && other.tag == "Planet")
        {
            //Land on planet
            print("Landing initiated");
            SceneManager.LoadScene(1);
        }
    }
}
