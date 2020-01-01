using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_move : MonoBehaviour
{
    public PlayerCreate pc;
    public p_physics pp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //player move
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (pc.hsp >= 0)
                {
                    pc.hsp += pc.acc;
                }
                else
                {
                    pc.hsp += pc.dcc;
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (pc.hsp <= 0)
                {
                    pc.hsp -= pc.acc;
                }
                else
                {
                    pc.hsp -= pc.dcc;
                }
            }
            if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                if (pc.hsp > 0)
                {
                    pc.hsp -= pc.frc;
                }
                if (pc.hsp < 0)
                {
                    pc.hsp += pc.frc;
                }

                if (pc.hsp <= pc.frc && pc.hsp >= -pc.frc)
                {
                    pc.hsp = 0;
                }
            }
        }

        //jumpign
        {

            if (Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
            {
                if (pc.ground)
                {
                    pp.isGrouafn = false;
                    pc.ground = false;
                    pc.vsp = -6;
                }
                
            }

        }
    }
}
