using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideWithObject : MonoBehaviour
{
    public string meteorite;
    public string planet;

    private FocusBar focusBarScript;

    private void Awake()
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
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (Input.GetKey(KeyCode.Space) && collider.tag == "Planet")
        {
            LandOnPlanet();
        }
    }

    void LandOnPlanet()
    {
        SceneManager.LoadScene(2);
    }
}
