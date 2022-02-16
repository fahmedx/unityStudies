using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercises_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        print("---Exercicio 01:---");
        int x01 = 5;
        float y01 = 4.20f;
        print("X: "+ x01);
        print("Y: "+ y01);

        print("---Exercicio 02:---");
        int x02 = 5;
        int y02 = 5;
        int z02 = 0;
        z02 = x02 + y02;
        print("Soma: " + z02);
        z02 = x02 - y02;
        print("Subtração: " + z02);
        z02 = x02 * y02;
        print("Multiplicação: " + z02);
        z02 = x02 / y02;
        print("Divisão: " + z02);

        print("---Exercicio 03:---");

        int x03 = 1;
        string result1;
        string result2;

        result1 = (x03 == 0)?"Verdadeiro!":"Falso!";
        print(result1);
        result2 = (x03 == 1)?"Verdadeiro!":"Falso!";
        print(result2);

        print("---Exercicio 04:---");

        int x04 = 10;
        int y04 = 6;
        int z04 = 0;
        z04 = x04 - y04;
        print("Diferença: " + z04);

        print("---Exercicio 05:---");

        int x05 = 10;
        if(x05 == 10){
            print("Games Eduu");
        }else{
            print("Zap Zap");
        }

        print("---Exercicio 06:---");
        string x06 = "Vilão";
        for (int i=0; i<=9; i++){
            print(x06);
        }

        print("---Exercicio 07:---");
        int[] x07;
        x07 = new int[5];
        x07[0] = 1;
        x07[1] = 2;
        x07[2] = 3;
        x07[3] = 4;
        x07[4] = 5;

        foreach(int number in x07){
            print(number);
        }

        print("---Exercicio 08:---");
        int[,]x08 = new int[2,2];
        x08[0,0] = 1;
        x08[0,1] = 2;
        x08[1,0] = 1;
        x08[1,1] = 2;

        for(int x = 0; x<2; x++){
            for(int y = 0; y<2; y++){
                  print(x08[x,y]);  
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
