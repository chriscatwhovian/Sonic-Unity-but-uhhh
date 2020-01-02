using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollLeft : MonoBehaviour
{
    public bool isCollLeft;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollLeft = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollLeft = false;
        }
    }
}
