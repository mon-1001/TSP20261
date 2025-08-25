using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;


public class Uints : MonoBehaviour
{
    //variables de control 
    static int currentIndex = 0;
    //variables de objetos 
    [SerializeField]
   public List<string> message;
    [SerializeField]
    public TextMeshProUGUI texts;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentIndex = 0;

    }

    public void CycleText()
    {
        currentIndex = (currentIndex + 1) % message.Count;
        UpdateText();

    }

    public void UpdateText()
    {
        if (message.Count>0 && texts != null)
        {
            texts.text = message[currentIndex];
        }
    }
   
}
