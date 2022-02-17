using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    //Podemos criar as variaveis aqui fora ("Global")
    /* int moeda;
    int i; 
    int heroiMoedas = 100;
    int precoVida = 100; 
    int estados = 1;
    float bufunfa; // = 10.6f; 
    bool trufal;
    string result;
    */

    // enum AI {Attack, Run, Patroll}
    
    //Creating Objects
   // Feline feline_01;
    //Feline feline_02;

    //Cat cat_01;

    //methods sum;

    //methods obj;

    //parent p;

    //son son;

    //calculator calc;

    //parent p;

    //lion leo;

    //cat cato;

    // Start is called before the first frame update
    void Start()
    {
        //Aqui podemos atribuir valores às variáveis ANTES do primeiro frame.
        
        /*
        Algumas conversões:

        Para inteiro:
        //moeda = (int)bufunfa;

        Para String:

        //text = moeda.ToString();

        Operações:
        x = y + z (Soma) 
        x = y - z (Subtração)
        x = y * z (Multiplicação)
        x = y / z (Divisão)

        x = y % z (Modulo)
        x = y ^ z (Potência)

        Teste de print Objeto moeda:
        moeda = 10;
        print(text);


        Incremento:
        int i = i++;
        ou
        int i +=1;

        Decremento:
        int i = i--;
        ou
        int i -=1;

        Multiplicação:

        int i *=2;
        
        Divisão:

        int i /=2;


        -- Operadores Relacionais ---

        == igual
        != Diferente 
        <  Menor
        >  Maior
        <= Menor Igual
        >= Maior Igual
        

        int x = 1;
        int y = 2;

        print (x == y); False
        print (x != y); True 
        print (x < y);  True 
        print (x > y);  False
        print (x <= y); True
        print (x >= y); False

        -- Operadores Lógicos --
        AND
        &&
        print (x != y && y != x); True

        OR 
        ||
        
        print (x != y || y != x); True

        NOT
        !
        print (!(x == y)); True


        --Se e Senão--
        
        if (heroiMoedas == precoVida){
            print("Olá Herói, você pode comprar Vida, mas fica sem um tustão furado...");
        }else if(heroiMoedas >= precoVida){
            print("Olá Herói, você pode comprar Vida e lhe sobra dinheiro!");
        }else{
            print("Adquira mais moedas!");
        }


        --Operador Ternario--

        result = (heroiMoedas >= precoVida)?"Posso Comprar a Vida":"Adquira mais moedas!";

        print(result);



        --Switch--
        Switches em contexto de jogo:

        Estados de um vilão:
        Estado 1: Corajoso.
        Estado 2: Medio.
        Estado 3: Covardia.

        switch(estados){
            case 1:
                print("Ataque!");
                break;
            case 2:
                print("Ataque e defenda");
                break;
            case 3: 
                print("Corra!");
                break;
            default:
                print("Estado não disponível");
                break;
        }


        --For--

        for (int i = 0; i<10; i++){
            print(i);
        }

        --While--

        int i=0;
        while(i<=10){
            print(i);
            i++;
        }

        --Do-While-- 
        
        Do While é usado pois a verificação da condição é feita ao final 
        da interação, diferente do while "cru".

        int i = 10;
        do{
          print(i);
          i++;
        }while(i<=10);

        --For-Each-- 
        
        For Each é usado para percorrer um vetor.

        string[] enemies;
        enemies = new string[4];
        enemies[0] = "caveira";
        enemies[1] = "litch";
        enemies[2] = "esqueleto";
        enemies[3] = "mindmaster";

        foreach(string name in enemies){
            print(name);
        }

        --Break e continue-- 
        São palavras do sistema que são usadas para quebrar um laço ou continuar para a próxima interação.


        string[] enemies;
        enemies = new string[4];
        enemies[0] = "caveira";
        enemies[1] = "litch";
        enemies[2] = "esqueleto";
        enemies[3] = "mindmaster";

        foreach(string name in enemies){
            //print(name);
            if(name == "esqueleto"){
                //break;
                continue;
            }
            print(name);
        }
        
        --Lista-- 

        List<int> listInt = new List<int>();
        listInt.Add(100);
        listInt.Add(200);
        listInt.Add(300);

        listInt.Remove(100);

        //print(listInt[1]);

        print(listInt.IndexOf(300));

        List<int> listInt = new List<int>();
        for(int i=0; i<=9;i++){
            listInt.Add(i);
        }

        foreach(int values in listInt){
            print(values);
        }

        --Dictionaries-- 

        Dicionarios servem para associar chaves à valores. (Tipo Assossiar nome/tipo de vilão
        com suas habilidades).
        
        Dictionary<string,string> villain = new Dictionary<string, string>();

        villain.Add("Killer","First Villain");
        villain.Add("Jumper","Jumper Villain");
        villain.Add("Shooter","Shooting Villain");

        foreach(string key in villain.Keys){
            print(key);
            print(villain[key]);
        }
       
        --Enumeradores--
        Enums são enumeradores que devem ser declarado fora das funções principais, no escopo da
        classe.
        Os valores nomeados abaixo são respectivos à valores inteiros.

        Declaração:

        enum AI {Attack, Run, Patroll}

        Uso no código:

        AI villain_01 = AI.Patroll;
        AI villain_02 = AI.Attack;

        int v1 = (int)villain_02;
        
        print(v1);
        print(villain_01);
        print(villain_02);


        --Montagem dos objetos--
        feline_01 = new Feline ();
        feline_02 = new Feline ();

        //Acesso à atributos protegidos pela classe filha.
        cat_01 = new Cat();
        cat_01.access();

        //Chamada de metodos

        sum = new methods();
        print(sum.sum(1,1));

        //Alimentando construtores.
        
        obj = new methods(10,"Sample");
        //print(obj.val1);
        //obj.val1 = 1000;
        print(obj.val1);
        print(obj.str1);


        //Chamando metodos estáticos. (Metodos estáticos são metodos que não necessitam
        //da criação de um objeto novo).
        int return1 = methods.sum(1,1);

        print(return1);

        //This and Base

        p = new parent(25);
        print(p.age);

        son = new son();
        son.getAge();


        // Sobrecarga de métodos.
        
        int   resultInt;
        float resultFloat;

        calc = new calculator();

        resultInt   = calc.calculate(1,2);
        resultFloat = calc.calculate(1.1f,2.2f);

        print(resultInt);
        print(resultFloat);

        //Encapsulamento
        p = new parent();
        p.Age = 19;
        print(p.Age);

        //Polimorfismo

        leo  = new lion();
        cato = new cat();
        
        leo.eat();
        cato.eat();


        */
        
    }

    // Update is called once per frame
    void Update()
    {
        //Update é um espaço do código que funciona como um for, onde cada interação dentrro do frame = "i=i++;"
        //moeda += 1;
        //print(moeda);
    }
}

//Class sample
/*
class Feline : MonoBehaviour{
    //Atributos
    protected string name;
    string furColor;
    int strenght;
    //Metodos
    void attack(){
        return;
    }
}

//Polimorfismo e uso de atributos protegidos.
class Cat : Feline{
    public void access(){
        print(name = "Cat");
    }

}
*/
/*
class methods  {
    public int sum(int value1, int value2){
        int result = value1 + value2;
        return result;
    }
}


//Uso de construtores
class methods{
    public int val1;
    public string str1;

    public methods(int val1, string str1){
        this.val1 = val1;
        this.str1 = str1;
    }
}

//Criando métodos estáticos 
class methods{
    public static int sum(int val1, int val2){
        int result = val1 + val2;
        return result;
    }
}



// Base and Age

class parent : MonoBehaviour{
    public int age = 25;
    
    //public parent(int age){
    //    this.age = age;
    //}
    
}

class son : parent{
    public void getAge(){
        print(base.age);
    }
}


class parent : MonoBehaviour{
    private int age = 18;

    public int Age{
        get{return age;}
        set{    if(value >= 20){
                    age = value;
                }else{
                    print("Error");
                }
            }
    }
}


// Polimorfismo
class animal : MonoBehaviour{
    public virtual void eat(){
        print("Is eating");
    }
}

class lion : animal{

    public override void eat()
    {
        print("Lion is eating");
    }

}

class cat : animal{
    public override void eat()
    {
        print("Cat is eating");
    }
}

*/

