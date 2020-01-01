using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_physics : MonoBehaviour
{
    public PlayerCreate pc;
    public bool isGrouafn;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //limits
        {
            if (pc.hsp > pc.hspl)
            {
                pc.hsp = pc.hspl;
            }

            if (pc.hsp < -pc.hspl)
            {
                pc.hsp = -pc.hspl;
            }

            if (pc.vsp > pc.vspl)
            {
                pc.vsp = pc.vspl;
            }

            if (pc.vsp < -pc.vspl)
            {
                pc.vsp = -pc.vspl;
            }
        }

        //h movement
        {
            if (pc.hsp > 0)
            {
                int i;
                for (i = 0; i < pc.hsp; i += 1)
                {
                    gameObject.transform.position += new Vector3(1* Time.deltaTime/2, 0, 0);

                }
            }

            if (pc.hsp < 0)
            {
                int i;
                for (i = 0; i < pc.hsp; i -= 1)
                {
                    gameObject.transform.position += new Vector3(-1* Time.deltaTime/2, 0, 0);

                }
            }
        }

        //v movement
        {
            if (pc.vsp > 0)
            {
                int i;
                for (i = 0; i < pc.vsp && !isGrouafn; i += 1)
                {
                    gameObject.transform.position += new Vector3(0, -1 * Time.deltaTime/2, 0);

                }
            }


            if (pc.vsp < 0)
            {
                int i;
                for (i = 0; i < pc.vsp && !isGrouafn; i -= 1)
                {
                    gameObject.transform.position += new Vector3(0, 1* Time.deltaTime/2, 0);

                }
            }
        }


        //land
        {
            if (pc.vsp >= 0 && !pc.ground && isGrouafn)
            {
                pc.vsp = 0;
                pc.ground = true;
            }
        }

        //Leave Ground
        {
            if(isGrouafn == false && pc.ground)
            {
                pc.ground = false;
            }
        }

        //gravity
        if (!pc.ground)
        {
            pc.vsp += pc.grv;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrouafn = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isGrouafn = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrouafn = false;
    }
}
   
