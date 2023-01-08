using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class beautificationButtons : MonoBehaviour
{
    public Button backtoscene1;

    private void Start()
    {
        backtoscene1.onClick.AddListener(Backtoscene1);
    }

    public void Backtoscene1()
    {
        SceneManager.LoadScene(1);
    }
}
