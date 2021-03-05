using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sampleScript : MonoBehaviour
{
    public Text text;
    public Slider slider;
   public Image image;
    public GameObject block;
    public int width = 4;
    public int height = 4;
    public int breadth = 4;

    void Start()
    {
        for (int z = 0; z < breadth; ++z)
        {
          for (int y = 0; y < height; ++y)
          {
            for (int x = 0; x < width; ++x)
            {
              Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
            }
           }
        }
    }

    // Update is called once per frame
    void Update()
    {
     int o=System.DateTime.Now.Second;
        Debug.Log(o);
    }

    public void imageColor()
    {
        image.color = new Color32(255, 0, 0, 255);
    }

    public void sliderValue()
    {
        text.text = slider.value.ToString();
        //kkk
    }

}

