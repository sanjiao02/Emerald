using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField] bool female = false;
    AudioClip previousClip;
    public TerrainPlaylist terrainPlaylist;
    public AudioSource audioSource;
    public int posX;
    public int posZ;
    public Terrain terrainObject;
    public Transform playerTransform;
    public float[] textureValues;

    public object texture1 { get; private set; }
    public object texture2 { get; private set; }
    public object texture3 { get; private set; }
    public object texture4 { get; private set; }
    public object texture5 { get; private set; }
    public object texture6 { get; private set; }
    public object texture7 { get; private set; }
    public object texture8 { get; private set; }
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        terrainPlaylist = FindObjectOfType<TerrainPlaylist>();
        terrainObject = FindObjectOfType<Terrain>(); // found the the wrong one ffs
        playerTransform = gameObject.transform;
    }

    private void Update()
    {
        GetTerrainTexture();
    }
    public void GetTerrainTexture()
    {
        ConvertPosition(playerTransform.position);
        CheckTexture();
    }
    void ConvertPosition(Vector3 playerPosition)
    {
        Vector3 terrainPosition = playerPosition - terrainObject.transform.position;
        Vector3 mapPosition = new Vector3
        (terrainPosition.x / terrainObject.terrainData.size.x, 0,
        terrainPosition.z / terrainObject.terrainData.size.z);

        float xCoord = mapPosition.x * terrainObject.terrainData.alphamapWidth;
        float zCoord = mapPosition.z * terrainObject.terrainData.alphamapHeight;

        posX = (int)xCoord;
        posZ = (int)zCoord;
    }
    AudioClip GetClipFormArray(AudioClip[] clipArray)
    {
        int attempts = 3;
        AudioClip selectedClip = clipArray[Random.Range(0, clipArray.Length - 1)];

        while (selectedClip == previousClip && attempts > 0)
        {
            selectedClip = clipArray[Random.Range(0, clipArray.Length - 1)];
        }

        previousClip = selectedClip;
        return selectedClip;
    }

    public void Step()
    {
        Debug.Log("geting steps");
        //        GetTerrainTexture();
        if (female == false)
        {
            Debug.Log("Male foot");
            Debug.Log("Male foot1");

            if (textureValues[0] > 0)
            {
                Debug.Log(" trying to play sounds 0");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture1Male));
            }
            if (textureValues[1] > 0)
            {
                Debug.Log(" trying to play sounds 1");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture2Male));
            }
            if (textureValues[2] > 0)
            {
                Debug.Log(" trying to play sounds 2");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture3Male), textureValues[2]);
            }
            if (textureValues[3] > 0)
            {
                Debug.Log(" trying to play sounds 3");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture4Male), textureValues[3]);
            }
            if (textureValues[4] > 0)
            {
                Debug.Log(" trying to play sounds 3");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture5Male), textureValues[4]);
            }
            if (textureValues[5] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture6Male), textureValues[5]);
            }
            if (textureValues[6] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture7Male), textureValues[6]);
            }
            if (textureValues[7] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture8Male), textureValues[7]);
            }
            else
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture2Male));
            }
        }
        else
        {

            if (textureValues[0] > 0)
            {
                Debug.Log(" trying to play sounds 0");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture1Female));
            }
            if (textureValues[1] > 0)
            {
                Debug.Log(" trying to play sounds 1");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture2Female));
            }
            if (textureValues[2] > 0)
            {
                Debug.Log(" trying to play sounds 2");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture3Female), textureValues[2]);
            }
            if (textureValues[3] > 0)
            {
                Debug.Log(" trying to play sounds 3");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture4Female), textureValues[3]);
            }
            if (textureValues[4] > 0)
            {
                Debug.Log(" trying to play sounds 3");
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture5Female), textureValues[4]);
            }
            if (textureValues[5] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture6Female), textureValues[5]);
            }
            if (textureValues[6] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture7Female), textureValues[6]);
            }
            if (textureValues[7] > 0)
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture8Female), textureValues[7]);
            }
            else
            {
                audioSource.PlayOneShot(GetClipFormArray(terrainPlaylist.texture2Female));
            }
        }

    }
    public void CheckTexture()
    {

        float[,,] aMap = terrainObject.terrainData.GetAlphamaps(posX, posZ, 1, 1);
        textureValues[0] = aMap[0, 0, 0];
        textureValues[1] = aMap[0, 0, 1];
        textureValues[2] = aMap[0, 0, 2];
        textureValues[3] = aMap[0, 0, 3];
        textureValues[4] = aMap[0, 0, 4];
        textureValues[5] = aMap[0, 0, 5];
        textureValues[6] = aMap[0, 0, 6];
        textureValues[7] = aMap[0, 0, 7];

    }


}
