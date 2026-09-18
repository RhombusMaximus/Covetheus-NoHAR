using RimWorld;
using UnityEngine;
using Verse;

namespace CovetheusNoHAR
{
    /// <summary>
    /// Walter android blood filth with 8 texture variants + random 90-degree rotation.
    /// Variant and rotation are both derived from thingIDNumber — stable across save/load.
    /// Texture files: Things/Filth/WalterBlood_a.png ... _h.png
    /// </summary>
    public class Filth_WalterBlood : Filth
    {
        private static Graphic[] variants;
        private static readonly string[] Suffixes =
            { "a","b","c","d","e","f","g","h" };

        private static Graphic[] Variants
        {
            get
            {
                if (variants == null)
                {
                    var list = new System.Collections.Generic.List<Graphic>();
                    foreach (var s in Suffixes)
                    {
                        string path = $"Things/Filth/WalterBlood_{s}";
                        if (ContentFinder<Texture2D>.Get(path, false) != null)
                        {
                            list.Add(GraphicDatabase.Get<Graphic_Single>(
                                path, ShaderDatabase.Transparent, Vector2.one, Color.white));
                        }
                    }
                    variants = list.ToArray();
                    Log.Message($"[Covetheus] Filth_WalterBlood: {variants.Length} texture variants loaded");
                }
                return variants;
            }
        }

        public override Graphic Graphic
        {
            get
            {
                Graphic[] pool = Variants;
                if (pool.Length == 0) return base.Graphic;
                return pool[Mathf.Abs(thingIDNumber) % pool.Length];
            }
        }

        protected override void DrawAt(Vector3 drawLoc, bool flip)
        {
            int rot = (Mathf.Abs(thingIDNumber) / 8) % 4;
            if (rot == 0)
            {
                base.DrawAt(drawLoc, flip);
                return;
            }
            // Rotate 90/180/270 per instance: draw the base graphic rotated around Y.
            Graphic g = Graphic;
            Vector3 loc = drawLoc;
            Quaternion quat = Quaternion.Euler(0f, rot * 90f, 0f);
            Mesh mesh = MeshPool.plane10;
            Material mat = g.MatSingle;
            Graphics.DrawMesh(mesh, loc, quat, mat, 0);
        }
    }
}