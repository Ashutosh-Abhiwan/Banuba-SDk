using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public static UiController instance;

    public List<GameObject> FaceFilters =>MainMenuButtons.instance.FaceFilters;


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



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        btAfro.onClick.AddListener(delegate { OnFilter(0); });
        btBeardFlower.onClick.AddListener(delegate { OnFilter(1); });
        btFootballsFanEagle.onClick.AddListener(delegate { OnFilter(2); });
        btButterFlies.onClick.AddListener(delegate { OnFilter(3); });
        btTarantula.onClick.AddListener(delegate { OnFilter(4); });
        btOctoberFastMen.onClick.AddListener(delegate { OnFilter(5); });
        btglasses_AviatorGold.onClick.AddListener(delegate { OnFilter(6); });
        btglasses_AviatorMrror.onClick.AddListener(delegate { OnFilter(7); });
        btglasses_BeautyGlasses.onClick.AddListener(delegate { OnFilter(8); });
        btBreakingBad.onClick.AddListener(delegate { OnFilter(9); });
        btBrutanMan.onClick.AddListener(delegate { OnFilter(10); });
        btCoachella.onClick.AddListener(delegate { OnFilter(11); });
        btDior.onClick.AddListener(delegate { OnFilter(12); });
        btDoggy.onClick.AddListener(delegate { OnFilter(13); });
        btMetalFrame.onClick.AddListener(delegate { OnFilter(14); });
        btPeachHairStyle.onClick.AddListener(delegate { OnFilter(15); });
        btPinkGlasses.onClick.AddListener(delegate { OnFilter(16); });
        btPlaygendary.onClick.AddListener(delegate { OnFilter(17); });
        btRound.onClick.AddListener(delegate { OnFilter(18); });
        btStanlee.onClick.AddListener(delegate { OnFilter(19); });
        btTonyStark.onClick.AddListener(delegate { OnFilter(20); });
        btWhite.onClick.AddListener(delegate { OnFilter(21); });
        btCaitineNecklase.onClick.AddListener(delegate { OnFilter(22); });
        btPanaEaring.onClick.AddListener(delegate { OnFilter(23); });
        btPotterBirthday.onClick.AddListener(delegate { OnFilter(24); });


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

    void OnFilter(int i)
    {
        bool sceneLoading = false;
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            sceneLoading = true;
            SceneManager.LoadScene(1);
        }
        if (!sceneLoading)
        {
            ActivateGamePanels(FaceFilters[i]);
        }
        else
        {
            StartCoroutine(CoreFilerDelay(i));
        }
    }
    IEnumerator CoreFilerDelay(int i)
    {
        while (true)
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                break;
            }
            yield return new WaitForSeconds(.5f);
        }
        ActivateGamePanels(FaceFilters[i]);
    }

    public void OpenActionUnitScene()
    {
        Debug.Log("open25");
        SceneManager.LoadScene(3);
    }

    public void OpenBeautificationScene()
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

