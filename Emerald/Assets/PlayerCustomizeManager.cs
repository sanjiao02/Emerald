using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCustomizeManager : MonoBehaviour
{
    public GameObject HairImagePrefab;

    public MirSelectButton HairTab;
    public GameObject HairGrid;
    public MirSelectButton FaceTab;
    public GameObject FaceGrid;

    private List<GameObject> hairImages = new List<GameObject>();
    private List<GameObject> faceImages = new List<GameObject>();

    public List<Sprite> WarriorHairImages = new List<Sprite>();
    public List<Sprite> WarriorFaceImages = new List<Sprite>();

    [HideInInspector]
    public int SelectedHair, SelectedFace;

    public void Refresh(MirClass selectedClass, MirGender selectedGender)
    {
        for (int i = 0; i < hairImages.Count; i++)
            Destroy(hairImages[i]);
        hairImages.Clear();

        for (int i = 0; i < faceImages.Count; i++)
            Destroy(faceImages[i]);
        faceImages.Clear();

        switch (selectedClass)
        {
            case MirClass.Warrior:
                for (int i = (int)selectedGender; i < WarriorHairImages.Count; i += 2)
                {
                    GameObject prefab = Instantiate(HairImagePrefab, HairGrid.transform, false);
                    prefab.GetComponent<Image>().sprite = WarriorHairImages[i];
                    int x = new int();
                    x = i / 2;
                    prefab.GetComponent<HairImageInfo>().Index = x;
                    prefab.GetComponent<Button>().onClick.AddListener(() => HairImage_onClick(x));
                    hairImages.Add(prefab);
                }

                for (int i = (int)selectedGender; i < WarriorFaceImages.Count; i += 2)
                {
                    GameObject prefab = Instantiate(HairImagePrefab, FaceGrid.transform, false);
                    prefab.GetComponent<Image>().sprite = WarriorFaceImages[i];
                    int x = new int();
                    x = i / 2;
                    prefab.GetComponent<HairImageInfo>().Index = x;
                    prefab.GetComponent<Button>().onClick.AddListener(() => FaceImage_onClick(x));
                    faceImages.Add(prefab);
                }
                break;
        }

        HairTab.Select(true);
        HairGrid.SetActive(true);

        FaceTab.Select(false);
        FaceGrid.SetActive(false);
    }

    void HairImage_onClick(int index)
    {
        SelectedHair = index;
        Debug.Log("Hair: " + index);
    }

    void FaceImage_onClick(int index)
    {
        SelectedFace = index;
        Debug.Log("Face: " + index);
    }

    public void HairTab_onClick()
    {
        HairTab.Select(true);
        HairGrid.SetActive(true);

        FaceTab.Select(false);
        FaceGrid.SetActive(false);

        GetComponent<ScrollRect>().verticalScrollbar.value = 1;
    }

    public void FaceTab_onClick()
    {
        FaceTab.Select(true);
        FaceGrid.SetActive(true);

        HairTab.Select(false);
        HairGrid.SetActive(false);

        GetComponent<ScrollRect>().verticalScrollbar.value = 1;
    }
}
