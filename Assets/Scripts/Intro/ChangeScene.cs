using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    //public void btn_change_scene(string scene_name)
    //{
    //    SceneManager.LoadScene(scene_name);
    //}

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LoadNextLevel();
        }
    }


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public IEnumerator LoadLevel(int SceneIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(SceneIndex);
    }
}
