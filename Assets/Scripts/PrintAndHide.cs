using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i=3;

    private int randInt;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        randInt = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {

        if(this.CompareTag("Red") && i == 100)
        {
            this.gameObject.SetActive(false);
        }

        if(this.CompareTag("Blue") && i == randInt)
        {
            rend.enabled = false;
        }

        Debug.Log(this.name + ":" + ++i);
    }
}
