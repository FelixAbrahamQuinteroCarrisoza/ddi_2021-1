﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    

public class Slot : MonoBehaviour
{

    public Item item;

    public Image image;
    public Sprite deafaultSprite;

    public Text counterText;

    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    public void SetItem(Item item, int count)
    {

        this.item = item;
        counter = count;
        if(image != null)
        {
            image.enabled = true;
            image.sprite = item.icon;
        }

        if(counterText != null)
        counterText.text = counter.ToString();
        
    }

    public void Clear()
    {
        this.item = null;
        //image.sprite = deafaultSprite;
        image.enabled = false;
    }

    public void UseItem()
    {
        if(this.item != null)
        {
            item.Use();
            if (counter>0)
               counter--;
            if(counterText != null)
              counterText.text = counter.ToString();  
        }
    }


    
}
