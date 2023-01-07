using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public List<GameObject> FaceFilters= new List<GameObject>();



    /*public GameObject FaceFilterone;
    public GameObject FaceFiltertwo;
    public GameObject FaceFilterthree;
    public GameObject FaceFilterfour;
    public GameObject FaceFilterfive;
    public GameObject FaceFiltersix;
    public GameObject FaceFilterseven;
    public GameObject FaceFiltereight;
    public GameObject FaceFilternine;
    public GameObject FaceFilterten;*/
  
    public Button bt1;
    public Button bt2;
    public Button bt3;
    public Button bt4;
    public Button bt5;
    public Button bt6;
    public Button bt7;
    public Button bt8;
    public Button bt9;
    public Button bt10;
    public Button bt11;
    public Button bt12;
    public Button bt13;
    public Button bt14;
    public Button bt15;
    public Button bt16;
    public Button bt17;
    public Button bt18;
    public Button bt19;
    public Button bt20;
    public Button bt21;
    public Button bt22;
    public Button bt23;
    public Button bt24;
    public Button openActionUnitScene;
    public Button openBeautificationScene;
    //public Button open


    


    void Start()
    {
        bt1.onClick.AddListener(open1);
        bt2.onClick.AddListener(open2);
        bt3.onClick.AddListener(open3);
        bt4.onClick.AddListener(open4);
        bt5.onClick.AddListener(open5);
        bt6.onClick.AddListener(open6);
        bt7.onClick.AddListener(open7);
        bt8.onClick.AddListener(open8);
        bt9.onClick.AddListener(open9);
        bt10.onClick.AddListener(open10);
        bt11.onClick.AddListener(open11);
        bt12.onClick.AddListener(open12);
        bt13.onClick.AddListener(open13);
        bt14.onClick.AddListener(open14);
        bt15.onClick.AddListener(open15);
        bt16.onClick.AddListener(open16);
        bt17.onClick.AddListener(open17);
        bt18.onClick.AddListener(open18);
        bt19.onClick.AddListener(open19);
        bt20.onClick.AddListener(open20);
        bt21.onClick.AddListener(open21);
        bt22.onClick.AddListener(open22);
        bt23.onClick.AddListener(open23);
        //bt24.onClick.AddListener(open24);
        openActionUnitScene.onClick.AddListener(OpenActionUnitScene);
        openBeautificationScene.onClick.AddListener(OpenBeautificationScene);
        
    }

    public void ActivateGamePanels(GameObject gamePanel)
    {
        foreach (var panel in FaceFilters)
        {
            panel.SetActive(gamePanel.Equals(panel));
        }

    }

    void open1()
    {
        ActivateGamePanels(FaceFilters[0]);
    }

    void open2()
    {
        ActivateGamePanels(FaceFilters[1]);
    }

    void open3()
    {
        ActivateGamePanels(FaceFilters[2]);
    }

    void open4()
    {
        ActivateGamePanels(FaceFilters[3]);
    }

    void open5()
    {
        ActivateGamePanels(FaceFilters[4]);
    }

    void open6()
    {
        ActivateGamePanels(FaceFilters[5]);
    }

    void open7()
    {
        ActivateGamePanels(FaceFilters[6]);
    }

    void open8()
    {
        ActivateGamePanels(FaceFilters[7]);
    }

    void open9()
    {
        ActivateGamePanels(FaceFilters[8]);
    }

    void open10()
    {
        ActivateGamePanels(FaceFilters[9]);
    }

    void open11()
    {
        ActivateGamePanels(FaceFilters[10]);
    }

    void open12()
    {
        ActivateGamePanels(FaceFilters[11]);
    }

    void open13()
    {
        ActivateGamePanels(FaceFilters[12]);
    }

    void open14()
    {
        ActivateGamePanels(FaceFilters[13]);
    }

    void open15()
    {
        ActivateGamePanels(FaceFilters[14]);
    }

    void open16()
    {
        ActivateGamePanels(FaceFilters[15]);
    }

    void open17()
    {
        ActivateGamePanels(FaceFilters[15]);
    }

    void open18()
    {
        ActivateGamePanels(FaceFilters[16]);
    }

    void open19()
    {
        ActivateGamePanels(FaceFilters[17]);
    }

    void open20()
    {
        ActivateGamePanels(FaceFilters[18]);
    }

    void open21()
    {
        ActivateGamePanels(FaceFilters[19]);
    }

    void open22()
    {
        ActivateGamePanels(FaceFilters[20]);
    }

    void open23()
    {
        ActivateGamePanels(FaceFilters[21]);
    }



  public  void OpenActionUnitScene()
    {
        Debug.Log("loggg");
        SceneManager.LoadScene(3);
    }
    
    public  void OpenBeautificationScene()
    {
        Debug.Log("loggg");
        SceneManager.LoadScene(4);
    }

}

