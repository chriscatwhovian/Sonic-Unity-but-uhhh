using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_physics : MonoBehaviour
{
    public PlayerCreate pc;
    public CollRight CR;
    public CollLeft CL;
    public CollUp CU;
    public CollDown CD;
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
                for (i = 0; i < pc.hsp && !CR.isCollRight; i += 1)
                {
                    gameObject.transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
                }
            }

            if (pc.hsp < 0)
            {
                int i;
                for (i = 0; i > pc.hsp && !CL.isCollLeft; i -= 1)
                {
                    gameObject.transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
                }
            }
        }

        //V movement
        {
            if (pc.vsp > 0)
            {
                int i;
                for (i = 0; i < pc.vsp && !CD.isCollDown; i += 1)
                {
                    gameObject.transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
                }
            }

            if (pc.vsp < 0)
            {
                int i;
                for (i = 0; i > pc.vsp && !CU.isCollUp; i -= 1)
                {
                    gameObject.transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
                }
            }
        }

        //wall collider thing 
        {
          
        }

        //lanind
        {
            if(pc.vsp >=0 && !pc.ground && CD.isCollDown)
            {
                pc.vsp = 0;
                pc.ground = true;
            }
        }

        //leave ground
        {
            if(!CD.isCollDown&& pc.ground)
            {
                pc.ground = false;
            }
        }

        //gravity
        {
            if (!pc.ground)
            {
                pc.vsp += pc.grv;
            }
        }
    }
   
}
   
