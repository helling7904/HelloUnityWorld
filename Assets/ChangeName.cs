using UnityEngine;
using System.Collections;
using TMPro;

public class ChangeName: MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText("Hello World! My Name is Holden Elling"); 
        }
    }
}