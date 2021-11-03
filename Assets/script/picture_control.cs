using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class picture_control : MonoBehaviour,IScrollHandler
{
    public float speed;

    public void OnScroll(PointerEventData eventData)
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            transform.localScale += Vector3.one * Time.deltaTime * speed;
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            transform.localScale -= Vector3.one * Time.deltaTime * speed;
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
