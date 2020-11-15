using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public float updateInterval =1.0F;

    private float accum = 0;
    private int frames = 0; 
    private float timeleft;

    private TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
        timeleft = updateInterval;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            // display two fractional digits (f2 format)
            float fps = accum / frames;
            string format = string.Format("{0:0}", fps);
            text.SetText(format);

            timeleft = updateInterval;
            accum = 0.0F;
            frames = 0;
        }
    }
}
