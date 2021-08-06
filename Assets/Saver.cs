using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public struct LevelCoor
{
    public float Xcoor1;
    public float Xcoor2;
};
public class Saver : MonoBehaviour
{
    public float CheckCoorX;
    public float CheckCoorY;
    public string sceneName;
    GameObject Player;
    public LevelCoor[] level = new LevelCoor[20];
    public Transform[] Figures = new Transform[6];
    void Start()
    {
        int i = 0;
        Player = GameObject.FindWithTag("Player");
        foreach(Transform child in Player.transform)
        {
            
            Figures[i] = child;
            i++;
        }
        
        level[1].Xcoor1 = 296f;
        level[1].Xcoor2 = 322f;
        level[2].Xcoor1 = 420f;
        level[2].Xcoor2 = 540f;
        level[3].Xcoor1 = 740f;
        level[3].Xcoor2 = 804f;
        level[4].Xcoor1 = 928f;
        level[4].Xcoor2 = 967f;
        level[5].Xcoor1 = 1254f;
        level[5].Xcoor2 = 1302f;
        level[6].Xcoor1 = 1426f;
        level[6].Xcoor2 = 1471f;
        level[7].Xcoor1 = 1595f;
        level[7].Xcoor2 = 1621f;
    }
    private void FixedUpdate()
    {
        foreach (var i in GameObject.FindWithTag("Saver").GetComponent<Saver>().level)
        {
            if (Player.transform.position.x < i.Xcoor2 && gameObject.transform.position.x > i.Xcoor1)
            {

                GameObject Triangle;
                //Triangle = Instantiate(Figures[1], transform.position, transform.rotation) as GameObject;
            }
        }
    }
    T[] InitializeArray<T>(int length) where T : new()
    {
        T[] array = new T[length];
        for (int i = 0; i < length; ++i)
        {
            array[i] = new T();
        }
        return array;
    }
}