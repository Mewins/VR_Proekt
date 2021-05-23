using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenSafe : MonoBehaviour
{
    public Animator doorAnim;
    public TextMeshProUGUI text;
    [SerializeField] private string password = "3384";
    private string enteredValue = string.Empty;
    public void Add(int a)
    {
        enteredValue += a.ToString();
        UpdateText();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Open();
        }
    }

    public void Check()
    {
        if(enteredValue==password)
        {
            Open();
        }
    }

    public void UpdateText()
    {
        text.text = enteredValue;
    }

    public void Open()
    {
        doorAnim.SetTrigger("Open");
    }
}
