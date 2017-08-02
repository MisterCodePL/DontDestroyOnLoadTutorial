using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    private InputField inputField; //Referencja do pola tekstowego.

    private void Start() /*Na początku sceny pobieramy referencje do do pola tekstowego.*/
    {
        inputField = GetComponent<InputField>();
        if(DataContainer.Instance.VariableToStoreBetweenScenes !=null) /*Sprawdzenie czy zmienna ma już 
            jakąś wartość (czy jest to już kolejna scena.)*/
            inputField.text = DataContainer.Instance.VariableToStoreBetweenScenes; /*przypisanie 
        wartości z DataContainera do pola tekstowego.*/
    }

    private void OnDisable() //Przy końcu sceny zapisanie zawartości pola tekstowego do DataContainera.
    {
        DataContainer.Instance.VariableToStoreBetweenScenes = inputField.text;
    }

}
