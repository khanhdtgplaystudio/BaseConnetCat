using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartLoading : MonoBehaviour
{
    public Text txtLoading;
    public Image progressBar;
    private void Start()
    {
        Application.targetFrameRate = 60;
        progressBar.fillAmount = 0f;
        StartCoroutine(ChangeScene());
        StartCoroutine(LoadingText());
    }

    // Use this for initialization
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);

        // we start loading the scene
        //scene_name = GameUtils.SceneName.HOME_SCENE;
        var _asyncOperation = SceneManager.LoadSceneAsync("GamePlay", LoadSceneMode.Single);
        _asyncOperation.allowSceneActivation = false;

        // while the scene loads, we assign its progress to a target that we'll use to fill the progress bar smoothly
        while (_asyncOperation.progress < 0.9f)
        {
            progressBar.fillAmount = _asyncOperation.progress / 0.9f;
            yield return null;
        }

        // we switch to the new scene
        _asyncOperation.allowSceneActivation = true;
    }

    IEnumerator LoadingText()
    {
        var wait = new WaitForSeconds(1f);
        while (true)
        {
            txtLoading.text = "LOADING .";
            yield return wait;

            txtLoading.text = "LOADING ..";
            yield return wait;

            txtLoading.text = "LOADING ...";
            yield return wait;

        }
    }
}
