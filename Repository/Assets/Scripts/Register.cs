using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // We're gonna need this to access to the Input Fields 

public class Register : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton; 

    public void CallRegister()
    {
        StartCoroutine(Registeration());
    }

    IEnumerator Registeration()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        // We can access to the PHP File using WWW class 
        WWW www = new WWW("http://localhost/sqlconnect/register.php", form); // Get to a page & get information from it 
        yield return www; // Tell to Unity to put this on the back burner & once we get the information back we'll run the rest of the code 
        if(www.text == "0")
        {
            Debug.Log("User Created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User creation failed. Error # " + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }


}
