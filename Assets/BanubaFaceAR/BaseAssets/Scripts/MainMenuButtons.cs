using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public static MainMenuButtons instance;
    public List<GameObject> FaceFilters = new List<GameObject>();
    private void Awake()
    {
        instance = this;
    }
}
