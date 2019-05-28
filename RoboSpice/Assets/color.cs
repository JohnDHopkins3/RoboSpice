using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public Color32 Particlecolor=new Color32();
    ParticleSystem particle;
    void Start()
    {
        particle.startColor=Particlecolor;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
