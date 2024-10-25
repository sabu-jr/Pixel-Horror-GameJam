using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2StoryController : MonoBehaviour
{

    [SerializeField] private GameObject RufusDlg;
    [SerializeField] private GameObject LunaDlg;
    [SerializeField] private GameObject UI;
    // Start is called before the first frame update

    private int Count=0;
    void Start()
    {
        RufusDlg.SetActive(true);
        LunaDlg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Count++;
            UpdateDlg();
        }
    }
    void UpdateDlg()
    {
        if (Count == 1)
        {
            RufusDlg.SetActive(false);
            LunaDlg.SetActive(true);
        }
        else if (Count ==3)
        {
            UI.SetActive(false);
        }
        else if (Count == 2)
        {
            RufusDlg.SetActive(false);
            LunaDlg.SetActive(false);
        }
    }
}
