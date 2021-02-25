using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UIController : MonoBehaviour
{

    public GameObject OptionScreen;
    public string sceneToLoad;
    public string nextScene;
    public AudioMixer audioMixer;
    float currentVolume;

    public void loadScene() {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void SetVolume(float volume) {
        audioMixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }

    public void SetFullscreen() {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void EndGame() {
        Application.Quit();
    }

    public void OptionMenuButton() {
        OptionScreen.SetActive(!OptionScreen.activeSelf);
    }

}
