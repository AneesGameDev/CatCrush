using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnimation : MonoBehaviour
{
    public Sprite[] sprite;
    public Texture2D[] texture;
    // public GameObject Image;
    public Image image;
    public float dely = 0.05f;
    public int length;
    public int current;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        length = sprite.Length;

    }


    // Update is called once per frame
    void Update()
    {
        dely -= Time.deltaTime;
        if (dely < 0  )
        {
           if( current <30) { 
            //  Sprite balanceone = Sprite.Create(newTexture, new Rect(0, 0, newTexture.width, newTexture.height), new Vector2(0.5f, 0.5f));
            image.sprite = sprite[current];
            current++;
                dely = 0.05f;
            }
			else
			{
                current = 0;
            }
        }
		else {
            
           
        }

       
    

		
        
    }
}
