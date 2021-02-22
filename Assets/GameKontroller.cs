using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKontroller : MonoBehaviour
{
    int minSayi = 0;
    int maxSayi = 100;
    int tahmin;
    bool oyunBasladi = false;
    bool oyunBitti = false;
  
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle Oyun Oynamak İster Miain? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Aklından 1-100 arasında bir sayı tut ve Enter tuşuna bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen Bilirsin!");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                oyunBasladi = true;
            }
        }
        else if(!oyunBitti)
        {
            //--------------------------------------
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yaşasın! Aklındaki sayıyı buldum!");
                oyunBitti = true;
            }
        }

        void Kontrol()
        {
            tahmin = (minSayi + maxSayi) / 2;
            print("Aklından tuttuğun sayı" + tahmin + "mi? Daha büyük ise yukarı,daha küçük ise aşağı tuşuna bas! Doğruysa boşluk tuşuna bas!");
        }
    }
}
