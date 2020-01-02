using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollDown : MonoBehaviour
{
    public bool isCollDown;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollDown = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollDown = false;
        }
    }
}
