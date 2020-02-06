using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    ParticleSystem[] ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponentsInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < ps.Length; i++)
            {
                ps[i].Play();
            }
        }
    }
}
