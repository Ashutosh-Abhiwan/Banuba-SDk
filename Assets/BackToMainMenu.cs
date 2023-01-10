using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
    public Button backToScene;

    private void Start()
    {
        backToScene.onClick.AddListener(Backtoscene);
    }
    public void Backtoscene()
    {
        SceneManager.LoadScene(8);
    }

}
