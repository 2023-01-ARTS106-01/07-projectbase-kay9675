using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        LevelChange();
    }

    private void LevelChange()
    {
        SceneManager.LoadScene("A2");
    }
}
