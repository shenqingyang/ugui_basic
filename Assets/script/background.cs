using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    public string path;
    // Start is called before the first frame update
    void Start()
    {
        path = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CHANGE()
    {
        transform.gameObject.GetComponent<Image>().color = new Color(Random.Range(0,5), Random.Range(0, 5), Random.Range(0, 5));
    }

    public void CHANGE_PICTURE()
    {
        this.gameObject.GetComponent<Image>().overrideSprite = Resources.Load(path,typeof(Sprite)) as Sprite;
        Debug.Log("1");
    }
}
