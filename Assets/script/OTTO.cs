using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class OTTO : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public float move_time;
    public float timer;
    public float speed;
    public Vector2 dir;
    public Slider[] slider;
    public float pre_x;
    public float pre_y;
    // Start is called before the first frame update
    void Start()
    {
        timer = move_time;
    }

    // Update is called once per frame
    void Update()
    {
        //ÑÕÉ«
        transform.gameObject.GetComponent<Image>().color = new Color(slider[0].value, slider[1].value, slider[2].value);


        //ÒÆ¶¯
        transform.position = Vector2.MoveTowards(transform.position,dir,speed);
        if (timer > 0)
        {
            timer -=Time.deltaTime;
        }
        else
        {
            dir = new Vector2(Random.Range(249,449),Random.Range(118,318));
            timer = move_time;
        }
    }

    public void changeTimer()
    {
        timer = 0;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 dir = new Vector2(transform.position.x+ eventData.position.x - pre_x, transform.position.y + eventData.position.y - pre_y);
        transform.position = dir;
        pre_x = eventData.position.x;
        pre_y = eventData.position.y;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        pre_x = eventData.position.x;
        pre_y = eventData.position.y;
    }
}
