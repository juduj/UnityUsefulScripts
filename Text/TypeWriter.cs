using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//
// BEFORE USING THIS SCRIPT CREATE ANOTHER TEXT OBJECT AND SET THE FONT SIZE TO ZERO
//

public class TypeWriter : MonoBehaviour
{
    public TextMeshProUGUI text;

    // I don't think you need this but I 
    // needed a way to store the text before I cleared it out
    public TextMeshProUGUI store;

    // Time before the next letter is written
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
