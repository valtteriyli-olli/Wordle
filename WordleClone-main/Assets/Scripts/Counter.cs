using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
  
{
    public int text;
    public TMP_Text textelement;
    public string textvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text = GameObject.Find("GameManager").GetComponent<GameManager>().counter;
        textelement.text = "Games won: " + text;
    }
}
