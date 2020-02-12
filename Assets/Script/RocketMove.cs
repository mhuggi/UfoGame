using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RocketMove : MonoBehaviour
{
    Vector2 gravity = new Vector2(0, -0.098f);
    Vector2 upforce = new Vector2(0, 0.198f);
    Vector2 rightforce = new Vector2(0.098f, 0);
    Vector2 leftforce = new Vector2(-0.098f, 0);
    GameObject asteroid;
    
    // Start is called before the first frame update
    void Start()
    {
        asteroid = GameObject.Find("Asteroid");

    }

    // Update is called once per frame
    void Update()
    {
        //Definierar en vektor v som indikerar hur mycket och i vilken riktning
        //raketen ska röra på sej per frame. Om ingen knapp trycks ner sätter vi både x och y 
        //i vektorn att var 0, dvs. raketen står stilla
        Vector2 v = new Vector2(0, 0);
       

        //Om högerpil på tangentbordet är intryckt...
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            //...vill vi för varje frame öka på x-koordinaten med 0.05
            //v = new Vector2(0.05f, v.y);
            v += rightforce;
        }

        //Om vänsterpil på tangentbordet är intryckt..
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //...vill vi minska på x-koordinaten med 0.05
            //v = new Vector2(-0.05f, v.y);
            v += leftforce;
        }

        //Om uppåtpil på tangentbordet är intryckt..
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //...vill vi öka på y-koordinaten med 0.05
            //v = new Vector2(v.x, 0.05f);
            v += upforce;
        }

        //Om neråtpil på tangentbordet är intryckt..
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //...vill vi minska på y-koordinaten med 0.05
            v = new Vector2(v.x, -0.05f);
        }

        //Adderar positionsvektorn med vektorn v. Nya positionsvektorn blir då
        //resultanten av vektoradditionen mellan transform.position och v
        if (VArithmetics.GetDistance(transform.position, asteroid.transform.position) > 1) {

            Vector2 airResistance = -v * 0.01f;

            v += airResistance;
            v += gravity;
            transform.Translate(v);
        }
    }
}
