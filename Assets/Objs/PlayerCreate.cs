using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreate : MonoBehaviour
{
    public float hsp = 0;
    public float vsp = 0;

    public float hspl = 16;
    public float vspl= 16;

    public float acc = 0.046875f;
    public float dcc = 0.5f;

    public float frc = 0.046875f;

    public float grv = 0.21875f;

    public bool ground = false;
   
    // Start is Preferibale for create things
    void Start()
    {
        
    }

}
