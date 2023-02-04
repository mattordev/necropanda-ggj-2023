using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plants", order = 0)]
public class Plant : ScriptableObject
{
    public string plantName;
    public Object plantObj;
    public int health = 10;
    public Sprite sprite;
    public List<E_Surfaces> buildSurfaces = new List<E_Surfaces>();

    public int waterCost = 1;
    public E_Surfaces surfaceModifier = E_Surfaces.Closed;

    public int radius;
    public int damage;
    public int healing;
    public bool confusion;
    public bool slow;
    public float tickTime = 1f;

    public void SpawnPlant(GridSpace space)
    {
        //check that the plant can be built on the specified surface
        GameObject plant = Instantiate(plantObj, space.transform) as GameObject;
        plant.transform.localPosition = new Vector3(0, 0.1f, 0);
        plant.GetComponent<PlantObject>().Setup(this, space);
    }
}

public enum E_Surfaces
{
    Open, Marsh, Water, Closed, Null
}