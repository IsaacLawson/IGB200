using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactionscript : MonoBehaviour
{
    public TMP_Text interacttxt;
    public GameObject other;

    // Start is called before the first frame update
    void Start()
    {
        interacttxt.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        interacttxt.enabled = true;
    }
}
