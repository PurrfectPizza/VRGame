using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsDetector : MonoBehaviour
{
    [HideInInspector] public Dictionary<string, int> ingredients;

    private void Start()
    {
        ingredients = new Dictionary<string, int>();
    }

    private void OnTriggerEnter(Collider go)
    {
        if (this.name == "Ingredients" & go.tag == "Ingredient")
        {
            Debug.Log(go.name + " Added");
            go.transform.SetParent(this.transform);
            go.GetComponent<Rigidbody>().isKinematic = true;

            if (ingredients.ContainsKey(go.name))
            {
                ingredients[go.name]++;
            }
            else
            {
                ingredients.Add(go.name, 0);
            }
        }
    }
}