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
  
    public Button btAfro;
    public Button btBeardFlower;
    public Button btFootballsFanEagle;
    public Button btButterFlies;
    public Button btTarantula;
    public Button btOctoberFastMen;
    public Button btglasses_AviatorGold;
    public Button btglasses_AviatorMrror;
    public Button btglasses_BeautyGlasses;
    public Button btBreakingBad;
    public Button btBrutanMan;
    public Button btCoachella;
    public Button btDior;
    public Button btDoggy;
    public Button btMetalFrame;
    public Button btPeachHairStyle;
    public Button btPinkGlasses;
    public Button btPlaygendary;
    public Button btRound;
    public Button btStanlee;
    public Button btTonyStark;
    public Button btWhite;
    public Button btCaitineNecklase;
    public Button btPanaEaring;
    public Button btPotterBirthday;
    public Button openActionUnitScene;
    public Button openBeautificationScene;
    public Button openMorphingScene;
    public Button openSegmentation;
    //public Button backtoscene1;


    


    void Start()
    {
        btAfro.onClick.AddListener(open1);
        btBeardFlower.onClick.AddListener(open2);
        btFootballsFanEagle.onClick.AddListener(open3);
        btButterFlies.onClick.AddListener(open4);
        btTarantula.onClick.AddListener(open5);
        btOctoberFastMen.onClick.AddListener(open6);
        btglasses_AviatorGold.onClick.AddListener(open7);
        btglasses_AviatorMrror.onClick.AddListener(open8);
        btglasses_BeautyGlasses.onClick.AddListener(open9);
        btBreakingBad.onClick.AddListener(open10);
        btBrutanMan.onClick.AddListener(open11);
        btCoachella.onClick.AddListener(open12);
        btDior.onClick.AddListener(open13);
        btDoggy.onClick.AddListener(open14);
        btMetalFrame.onClick.AddListener(open15);
        btPeachHairStyle.onClick.AddListener(open16);
        btPinkGlasses.onClick.AddListener(open17);
        btPlaygendary.onClick.AddListener(open18);
        btRound.onClick.AddListener(open19);
        btStanlee.onClick.AddListener(open20);
        btTonyStark.onClick.AddListener(open21);
        btWhite.onClick.AddListener(open22);
        btCaitineNecklase.onClick.AddListener(open23);
        btPanaEaring.onClick.AddListener(open24);
        btPotterBirthday.onClick.AddListener(open25);
        openActionUnitScene.onClick.AddListener(OpenActionUnitScene);
        openBeautificationScene.onClick.AddListener(OpenBeautificationScene);
        openMorphingScene.onClick.AddListener(OpenMorphingScene);
        openSegmentation.onClick.AddListener(OpenSegmentation);
        //backtoscene1.onClick.AddListener(Backtoscene1);
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
        Debug.Log("open1");
        ActivateGamePanels(FaceFilters[0]);
    }

    void open2()
    {
        Debug.Log("open2");
        ActivateGamePanels(FaceFilters[1]);
    }

    void open3()
    {
        Debug.Log("open3");
        ActivateGamePanels(FaceFilters[2]);
    }

    void open4()
    {
        Debug.Log("open4");
        ActivateGamePanels(FaceFilters[3]);
    }

    void open5()
    {
        Debug.Log("open5");
        ActivateGamePanels(FaceFilters[4]);
    }

    void open6()
    {
        Debug.Log("open6");
        ActivateGamePanels(FaceFilters[5]);
    }

    void open7()
    {
        Debug.Log("open7");
        ActivateGamePanels(FaceFilters[6]);
    }

    void open8()
    {
        Debug.Log("open8");
        ActivateGamePanels(FaceFilters[7]);
    }

    void open9()
    {
        Debug.Log("open9");
        ActivateGamePanels(FaceFilters[8]);
    }

    void open10()
    {
        Debug.Log("open10");
        ActivateGamePanels(FaceFilters[9]);
    }

    void open11()
    {
        Debug.Log("open11");
        ActivateGamePanels(FaceFilters[10]);
    }

    void open12()
    {
        Debug.Log("open12");
        ActivateGamePanels(FaceFilters[11]);
    }

    void open13()
    {
        Debug.Log("open13");
        ActivateGamePanels(FaceFilters[12]);
    }

    void open14()
    {
        Debug.Log("open14");
        ActivateGamePanels(FaceFilters[13]);
    }

    void open15()
    {
        Debug.Log("open15");
        ActivateGamePanels(FaceFilters[14]);
    }

    void open16()
    {
        Debug.Log("open16");
        ActivateGamePanels(FaceFilters[15]);
    }

    void open17()
    {
        Debug.Log("open17");
        ActivateGamePanels(FaceFilters[15]);
    }

    void open18()
    {
        Debug.Log("open18");
        ActivateGamePanels(FaceFilters[16]);
    }

    void open19()
    {
        Debug.Log("open19");
        ActivateGamePanels(FaceFilters[17]);
    }

    void open20()
    {
        Debug.Log("open20");
        ActivateGamePanels(FaceFilters[18]);
    }

    void open21()
    {
        Debug.Log("open21");
        ActivateGamePanels(FaceFilters[19]);
    }

    void open22()
    {
        Debug.Log("open22");
        ActivateGamePanels(FaceFilters[20]);
    }

    void open23()
    {
        Debug.Log("open23");
        ActivateGamePanels(FaceFilters[21]);
    }

    void open24()
    {
        Debug.Log("open24");
        ActivateGamePanels(FaceFilters[22]);
    }

    void open25()
    {
        Debug.Log("open25");
        ActivateGamePanels(FaceFilters[24]);
    }



    public  void OpenActionUnitScene()
    {
        Debug.Log("open25");
        SceneManager.LoadScene(3);
    }
    
    public  void OpenBeautificationScene()
    {
        Debug.Log("open26");
        SceneManager.LoadScene(4);
    }

    public void OpenMorphingScene()
    {
        Debug.Log("open26");
        SceneManager.LoadScene(5);
    }

    public void OpenSegmentation()
    {
        Debug.Log("open26");
        SceneManager.LoadScene(6);
    }

    /*public void Backtoscene1()
    {
        Debug.Log("open26");
        SceneManager.LoadScene(1);
    }*/
}

