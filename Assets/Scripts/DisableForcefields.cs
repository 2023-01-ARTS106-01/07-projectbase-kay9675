using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableForcefields : MonoBehaviour
{
    public GameObject Forcefield1;
    public GameObject Forcefield2;

    void OnTriggerEnter(Collider other)
    {
        Invoke("ForcefieldOff", 2.0f);
        //Add audio cue later
    }

    private void ForcefieldOff()
    {
        Forcefield1.SetActive(false);
        Forcefield2.SetActive(false);
    }
}
