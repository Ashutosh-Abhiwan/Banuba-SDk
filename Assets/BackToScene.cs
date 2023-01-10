using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToScene : MonoBehaviour
{
    public Button backBtn, scene1Btn, scene4Btn, scene5Btn, scene6Btn;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        //backBtn.onClick.AddListener(delegate { LoadScene(8); });
        scene1Btn.onClick.AddListener(delegate { LoadScene(1); });
        scene4Btn.onClick.AddListener(delegate { LoadScene(4); });
        scene5Btn.onClick.AddListener(delegate { LoadScene(5); });
        scene6Btn.onClick.AddListener(delegate { LoadScene(6); });
    }

    private void LoadScene(int id)
    {
        SceneManager.LoadScene(id);
    }
}
