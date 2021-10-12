using NativeWebSocket;
using UnityEngine;

public class TextureFromESP32CAM : MonoBehaviour
{
    private WebSocket _webSocket;

    async void Start()
    {
        _webSocket = new WebSocket("http://192.168.43.55/");
        _webSocket.OnOpen    += ()      => { print("Connection Open!");  };
        _webSocket.OnError   += (e)     => { print("Error :" + e);       };
        _webSocket.OnClose   += (e)     => { print("Connection Close!"); };
        _webSocket.OnMessage += (bytes) =>
        {
            print("onMessage length :" + bytes.Length);
            if (bytes.Length > 0)
            {
                Texture2D tex = new Texture2D(2, 2);
                tex.LoadImage(bytes);

                if (GetComponent<Renderer>() != null)
                {
                    GetComponent<Renderer>().material.mainTexture = tex;
                }
            }
        };
        await _webSocket.Connect();
    }

    private async void OnApplicationQuit()
    {
        await _webSocket.Close();
    }
}