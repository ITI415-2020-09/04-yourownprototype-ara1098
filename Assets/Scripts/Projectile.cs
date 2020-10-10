using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{

    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    public static float bottomY = -13.90522f;                                  // a

    void Start()
    {
        count = 0;
        countText = GameObject.Find("CountText").GetComponent<TextMeshProUGUI>();
        SetCountText();
    }
    void Update()
    {

        if (transform.position.y == bottomY)
        {
            Destroy(this.gameObject);                                      // b
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.SetText("Count: " + count.ToString());

        if (count >= 10)
        {
            winTextObject.SetActive(true);
        }
    }
}

