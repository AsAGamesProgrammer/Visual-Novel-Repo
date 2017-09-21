using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour {

    public Text speech1;
    //public Text speech2;
    public Text name1;
    //public Text name2;

    public string[] dialog;

    public int momentum = -1;
    public GameObject choiceA;
    public GameObject choiceB;
    public Button nextBtn;

    public void Start()
    {
        Button btn = nextBtn.GetComponent<Button>();
        btn.onClick.AddListener(OnBtnClick);
    }

    public void changeScene()
    {
        momentum += 1;  //Next scene started

        if (momentum < dialog.Length)
        {
            speech1.text = dialog[momentum];
            name1.text = "Char 1";
        }
     
    }

    void OnBtnClick()
    {
        changeScene();
    }
}
