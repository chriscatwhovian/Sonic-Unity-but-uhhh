using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollRight : MonoBehaviour
{
    public bool isCollRight;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollRight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isCollRight = false;
        }
    }

}
