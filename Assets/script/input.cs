using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public GameObject OTTO;
    public GameObject background;
    public Text text;
    public Text text2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CHANGE()
    {
        OTTO.GetComponent<OTTO>().changeTimer();
        background.GetComponent<background>().CHANGE();
    }

    public void COMPELET()
    {
        text.text = text2.text;
        background.GetComponent<background>().CHANGE_PICTURE();
    }

}
