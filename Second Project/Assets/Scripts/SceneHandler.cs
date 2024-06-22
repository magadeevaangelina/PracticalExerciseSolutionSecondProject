using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] private Transform SplashScreen;
    [SerializeField] private Transform LoadingScreen;
    [SerializeField] private Transform SelectCityScreen;
    [SerializeField] private Transform SelectMonumentSevastopolScreen;
    [SerializeField] private Transform SelectMonumentPeterburgScreen;
    [SerializeField] private Transform CameraScreen;

    //private string selectedCity;

    [SerializeField] private Button SevastopolButton;
    // [SerializeField] private Button MoscowButton;
    [SerializeField] private Button PetersburgButton;
    // [SerializeField] private Button SimferopolButton;

    // [SerializeField] private TextMeshProUGUI SelectedCity;
    [SerializeField] private TextMeshProUGUI Year;
    [SerializeField] private TextMeshProUGUI Author;
    [SerializeField] private TextMeshProUGUI City;

    //[SerializeField] private ImageTrakingController controller;
    private void Start()
    {
        StartCoroutine(ShowScreensSequentially());

        SevastopolButton.onClick.AddListener(() => OnCitySelected(SelectMonumentSevastopolScreen));
        // MoscowButton.onClick.AddListener(() => OnCitySelected("������"));
        PetersburgButton.onClick.AddListener(() => OnCitySelected(SelectMonumentPeterburgScreen));
        // SimferopolButton.onClick.AddListener(() => OnCitySelected("�����������"));
    }
    private IEnumerator ShowScreensSequentially()
    {
        SplashScreen.gameObject.SetActive(true);
        LoadingScreen.gameObject.SetActive(false);
        SelectCityScreen.gameObject.SetActive(false);
        SelectMonumentSevastopolScreen.gameObject.SetActive(false);
        SelectMonumentPeterburgScreen.gameObject.SetActive(false);
        CameraScreen.gameObject.SetActive(false);

        yield return new WaitForSeconds(4);

        SplashScreen.gameObject.SetActive(false);
        LoadingScreen.gameObject.SetActive(true);

        yield return new WaitForSeconds(6);

        LoadingScreen.gameObject.SetActive(false);
        SelectCityScreen.gameObject.SetActive(true);
    }

    private void OnCitySelected(Transform city)
    {
        SelectCityScreen.gameObject.SetActive(false);
        city.gameObject.SetActive(true);
    }

    public void SelectNahimov()
    {
        //controller.targetController.ImageFileSource.Path = "ARMarkers/Nahimov.jpg";
        //controller.targetController.ImageFileSource.Name = "Nahimov";
        //Debug.Log(controller.targetController.ImageFileSource.Path);
        SelectMonumentSevastopolScreen.gameObject.SetActive(false);
        CameraScreen.gameObject.SetActive(true);

        Year.text = "����: 5 ������ 1959";
        Author.text = "������: ����������� A. A. � ������ �. �.";
        City.text = "�����������";
    }

    public void SelectSunkenShipsMonument()
    {
        //controller.targetController.ImageFileSource.Path = "ARMarkers/SunkenShips.jpg";
        //controller.targetController.ImageFileSource.Name = "SunkenShips";
        //Debug.Log(controller.targetController.ImageFileSource.Path);
        SelectMonumentSevastopolScreen.gameObject.SetActive(false);
        CameraScreen.gameObject.SetActive(true);

        Year.text = "����: 1905";
        Author.text = "�����:  �������� �. �.";
        City.text = "�����������";
    }

    public void SelectAlexanderColumn()
    {
        //controller.targetController.ImageFileSource.Path = "ARMarkers/Alexander.jpg";
        //controller.targetController.ImageFileSource.Name = "Alexander";
        //Debug.Log(controller.targetController.ImageFileSource.Path);
        SelectMonumentPeterburgScreen.gameObject.SetActive(false);
        CameraScreen.gameObject.SetActive(true);

        Year.text = "����: 11 �������� 1834";
        Author.text = "�����: ����� ���������";
        City.text = "�����-���������";
    }
}
