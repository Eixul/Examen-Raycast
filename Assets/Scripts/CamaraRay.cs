using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaraRay : MonoBehaviour
{
    public Camera camara;
    public int timer = 5;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Raytest();
        }
    }
    
    void Raytest()
    {
        Ray ray = camara.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity));
        {
            Debug.DrawLine(camara.transform.position, hit.point);
	        if(hit.transform.gameObject.layer == 7)
            {
                Debug.Log("HitThatSh");
                SceneManager.LoadScene(3);
                BoxRotation.instance.Countertres();
            }
        }
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(camara.transform.position, hit.point);
	        if(hit.transform.gameObject.layer == 6)
            {
                Debug.Log("HitThatSh");
                SceneManager.LoadScene(2);
            }
        }
        if(Physics.Raycast(ray, out hit, Mathf.Infinity));
        {
            Debug.DrawLine(camara.transform.position, hit.point);
	        if(hit.transform.gameObject.layer == 3)
            {
                Debug.Log("HitThatSh");
            }
        }
        
    }
}
