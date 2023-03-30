using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider sl;
    public void VolSli()
    {
        float a=sl.value;
        AudioListener.volume=a;
    }
}
