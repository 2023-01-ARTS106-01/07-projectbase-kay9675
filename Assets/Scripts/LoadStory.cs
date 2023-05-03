using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStory : MonoBehaviour
{
    public void LoadStoryScene()
    {
        SceneManager.LoadScene("StoryScene");
    }
}
