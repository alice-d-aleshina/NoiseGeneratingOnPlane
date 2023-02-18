// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using LibNoise;
// using LibNoise.Generator;
// using LibNoise.Operator;


// namespace LibNoise
// {
//     public class NoiseGenerating : MonoBehaviour
//     {

//         // Start is called before the first frame update

//         [Header("Gradient")]
//         public Gradient _gradient = GradientPresets.RGB;
//         public float _left = 1;
//         public float _right = 3;
//         public float _top = 4;
//         public float _bottom = 7;

//         void Start()
//         {
//             var billow = new Billow();
//             var heightMapBuilder = new Noise2D(100, 100, billow);
//             heightMapBuilder.GeneratePlanar(_left, _right, _top, _bottom);
//             var image = heightMapBuilder.GetTexture(_gradient);
//             GetComponent<Renderer>().material.mainTexture = image;

//         }
//     }
// }

