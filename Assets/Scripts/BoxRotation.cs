using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxRotation : MonoBehaviour
{
    public static BoxRotation instance;
    public int segundos = 5;


    void Update()
    {
        transform.Rotate(new Vector3(0f, 180f, 0f) * Time.deltaTime);
    }
    
    // Update is called once per frame
    public void Counteruno()
    {
        segundos -= 1;
        if(segundos == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void Counterdos()
    {
        segundos -= 1;
        if(segundos == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Countertres()
    {
        segundos -= 1;
        if(segundos == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
