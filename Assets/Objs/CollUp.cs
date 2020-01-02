using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollUp : MonoBehaviour
{
    public bool isCollUp;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            isCollUp = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollUp = false;
        }
    }
}
