using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cam : MonoBehaviour
{
    static public Cam S;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;



    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
        count = 0;
    }
    void Awake()
    {
        S = this;
    }

    void ShowText()
    {

        countText.text = "Score: " + count.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        ShowText();
    }

    public void SetCountText()
    {
       count++;
        if (count >= 10)
        {
            winTextObject.SetActive(true);
        }
    }

 
    



}
