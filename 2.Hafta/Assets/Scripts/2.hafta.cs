using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        string tumListe = ToplamaMetni(20, 44);
        string ikiyeBolunenler = BolenleriGetir(20, 44, 2);
        string ucBolunenler = BolenleriGetir(20, 44, 3);
        string dortBolunenler = BolenleriGetir(20, 44, 4);
        string besBolunenler = BolenleriGetir(20, 44, 5);

        Debug.Log("Tüm Sayılar: " + tumListe);
        Debug.Log("İkiye Bölünenler: " + ikiyeBolunenler);
        Debug.Log("Üçe Bölünenler: " + ucBolunenler);
        Debug.Log("Dörde Bölünenler: " + dortBolunenler);
        Debug.Log("Beşe Bölünenler: " + besBolunenler);
    }

    string ToplamaMetni(int baslangic, int bitis)
    {
        string metin = "";
        for (int i = baslangic; i <= bitis; i++)
        {
            if (i != bitis)
            {
                metin += i + "-";
            }
            else
            {
                metin += i;
            }
        }
        return metin;
    }

    string BolenleriGetir(int baslangic, int bitis, int bolen)
    {
        string metin = "";
        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % bolen == 0)
            {
                if (i != bitis)
                {
                    metin += i + "-";
                }
                else
                {
                    metin += i;
                }
            }
        }
        return metin;
    }


}

