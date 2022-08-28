using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 3;
    
    public Renderer rend;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == Random.Range(200, 251))
        {
            gameObject.GetComponent<Renderer>().enabled = false;
           
        }
    }
}
