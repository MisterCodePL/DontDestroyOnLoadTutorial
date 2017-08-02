using UnityEngine;
//DataContainer jest tak naprawdę Singletonem
public class DataContainer : MonoBehaviour
{
    public static DataContainer Instance;

    public string VariableToStoreBetweenScenes { get; set; } //Dane do przechowania.

    private void Awake()
    {
        if(Instance==null)
        {
            DontDestroyOnLoad(gameObject); //DontDestroyOnLoad zapobiega niszczeniu się obiektu przy 
                                            //ładowaniu nowej sceny
            Instance = this;
        }
        else if(Instance!= this) //Zapobiega możliwości istnieniu dwóch DataContainerów w jednej scenie.
        {
            Destroy(gameObject);
        }
    }
}
