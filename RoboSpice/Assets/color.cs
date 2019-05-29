using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    ParticleSystem ps;
    ParticleSystem.MainModule ma;
    public Color Particlecolor;
    public GameObject Platform;

    void Start()
    {
        Particlecolor = Platform.GetComponent<Color>();
        ps = GetComponent<ParticleSystem>();
        ma = ps.main;

        ma.startColor = Particlecolor;
    }
}
