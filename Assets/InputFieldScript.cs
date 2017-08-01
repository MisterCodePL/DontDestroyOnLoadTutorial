using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    private InputField inputField; //Referencja do pola tekstowego.
    private DataContainer dataContainer; //Referencja do kontenera na dane.

    private void Start() /*Na początku sceny pobieramy referencje do DataContainera oraz 
        do pola tekstowego.*/
    {
        dataContainer = GameObject.Find("EmptyObjectName").GetComponent<DataContainer>(); 

        inputField = GetComponent<InputField>();
        if(dataContainer.VariableToStoreBetweenScenes !=null) /*Sprawdzenie czy zmienna ma już jakąś 
            wartość (czy jest to już kolejna scena.)*/
            inputField.text = dataContainer.VariableToStoreBetweenScenes; /*przypisanie wartości z 
        DataContainera do pola tekstowego.*/
    }

    private void OnDisable() //Przy końcu sceny zapisanie zawartości pola tekstowego do DataContainera.
    {
        dataContainer.VariableToStoreBetweenScenes = inputField.text;
    }

}
