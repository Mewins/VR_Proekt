using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtich : MonoBehaviour
{
    public GameObject svet;
    public GameObject codeText;
    bool isActive=true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            if (isActive) 
            { 
                svet.SetActive(false); 
                codeText.SetActive(true); 
            }
            else
            { 
                svet.SetActive(true); 
                codeText.SetActive(false); 
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (isActive)
            {
                svet.SetActive(false);
                codeText.SetActive(true);
            }
            else
            {
                svet.SetActive(true);
                codeText.SetActive(false);
            }
        }
    }
}
