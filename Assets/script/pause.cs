using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject OTTO;
    public int pause_num=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void PAUSEUI()
    {
        if (pause_num % 2!=0)
        {
            OTTO.SetActive(true);
        }
        else
        {
            OTTO.SetActive(false);
        }
        pause_num++;
    }

    public void habixia()
    {
        OTTO.gameObject.GetComponent<OTTO>().enabled = !OTTO.gameObject.GetComponent<OTTO>().enabled;
    }
}
