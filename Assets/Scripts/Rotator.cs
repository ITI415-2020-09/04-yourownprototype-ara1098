using UnityEngine;
using System.Collections;
using TMPro;

public class Rotator : MonoBehaviour
{

    static private Rotator S;

    public static int count;
    public TextMeshProUGUI countText;
    // Before rendering each frame..
    void Update()
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

    void Start()
    {
        S = this;
        count = 0;
        
        countText = GameObject.Find("CountText").GetComponent<TextMeshProUGUI>();

        SetCountText();
    }

 

    public static void  SetCountText()
    {
        countText.SetText("Count: " + S.count.ToString());

       // if (count >= 10)
        //{
       //     winTextObject.SetActive(true);
       // }
    }

   public static void addCount()
    {
        S.count++;
        S.SetCountText();
    }
 
}
