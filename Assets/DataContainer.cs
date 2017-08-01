using UnityEngine;

public class DataContainer : MonoBehaviour
{
    public static DataContainer dataContainer;

    public string VariableToStoreBetweenScenes { get; set; } //Dane, które chcemy przechować między scenami.

    private void Awake()
    {
        if(dataContainer==null)
        {
            DontDestroyOnLoad(gameObject); //DontDestroyOnLoad zapobiega niszczeniu się obiektu przy ładowaniu nowej sceny
            dataContainer = this;
        }
        else if(dataContainer!= this) //Zapobiega możliwości istnieniu dwóch DataContainerów w jednej scenie.
        {
            Destroy(gameObject);
        }
    }
}
