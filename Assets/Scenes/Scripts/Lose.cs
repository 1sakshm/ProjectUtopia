using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public Image ima;
    public GameObject go;
    void FixedUpdate()
    {
        if(ima.fillAmount==0)
        {
            go.SetActive(true);
        }
    }
}
