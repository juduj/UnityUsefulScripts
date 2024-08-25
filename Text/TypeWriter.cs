using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI store;
    public float waitTime = 0.1f;
    
    IEnumerator TypeWriterEffect()
    {
        store.text = text.text;
        
        text.text = "";

        foreach (char c in store.text.ToCharArray())
        {
            text.text += c.ToString();
            yield return new WaitForSeconds(waitTime); 
        }
    }

    void Start()
    {
        // Start the TypeWriterEffect coroutine when the script starts
        StartCoroutine(TypeWriterEffect());
    }
}
