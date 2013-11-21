using Duality;
using Duality.ColorFormat;
using Duality.Components;
using Duality.EditorHints;
using Duality.Resources;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.CustomRenderers
{

    [Serializable]
    public class LayerRenderer : Renderer
    {
        /// <summary>
        /// SPecifies, how the sprites uv-Coordinates are calculated.
        /// </summary>
        public enum UVMode
        {
            /// <summary>
            /// The uv-Coordinates are constant, stretching the supplied texture to fit the SpriteRenderers dimensions.
            /// </summary>
            Stretch = 0x0,
            /// <summary>
            /// The u-Coordinate is calculated based on the available horizontal space, allowing the supplied texture to be
            /// tiled across the SpriteRenderers width.
            /// </summary>
            WrapHorizontal = 0x1,
            /// <summary>
            /// The v-Coordinate is calculated based on the available vertical space, allowing the supplied texture to be
            /// tiled across the SpriteRenderers height.
            /// </summary>
            WrapVertical = 0x2,
            /// <summary>
            /// The uv-Coordinates are calculated based on the available space, allowing the supplied texture to be
            /// tiled across the SpriteRenderers size.
            /// </summary>
            WrapBoth = WrapHorizontal | WrapVertical
        }

        protected Rect rect = Rect.AlignCenter(0, 0, 256, 256);
        protected List<ContentRef<Material>> sharedMat = new List<ContentRef<Material>>() { Material.DualityIcon };
        protected ColorRgba colorTint = ColorRgba.White;
        protected UVMode rectMode = UVMode.Stretch;
        protected int offset = 0;
        [NonSerialized]
        protected Duality.VertexFormat.VertexC1P3T2[] vertices = null;

        [EditorHintFlags(MemberFlags.Invisible)]
        public override float BoundRadius
        {
            get { return this.rect.Transform(this.GameObj.Transform.Scale, this.GameObj.Transform.Scale).BoundingRadius; }
        }
        /// <summary>
        /// [GET / SET] The rectangular area the sprite occupies. Relative to the <see cref="GameObject"/>.
        /// </summary>
        [EditorHintDecimalPlaces(1)]
        public Rect Rect
        {
            get { return this.rect; }
            set { this.rect = value; }
        }
        /// <summary>
        /// [GET / SET] The <see cref="Duality.Resources.Material"/> that is used for rendering the sprite.
        /// </summary>
        public List<ContentRef<Material>> SharedMaterial
        {
            get { return this.sharedMat; }
            set { this.sharedMat = value; }
        }
        /// <summary>
        /// [GET / SET] A color by which the sprite is tinted.
        /// </summary>
        public ColorRgba ColorTint
        {
            get { return this.colorTint; }
            set { this.colorTint = value; }
        }
        /// <summary>
        /// [GET / SET] Specifies how the sprites uv-Coordinates are calculated.
        /// </summary>
        public UVMode RectMode
        {
            get { return this.rectMode; }
            set { this.rectMode = value; }
        }
        /// <summary>
        /// [GET / SET] A virtual Z offset that affects the order in which objects are drawn. If you want to assure an object is drawn after another one,
        /// just assign a higher Offset value to the background object.
        /// </summary>
        public int Offset
        {
            get { return this.offset; }
            set { this.offset = value; }
        }
        /// <summary>
        /// [GET] The internal Z-Offset added to the renderers vertices based on its <see cref="Offset"/> value.
        /// </summary>
        [EditorHintFlags(MemberFlags.Invisible)]
        public float VertexZOffset
        {
            get { return this.offset * 0.01f; }
        }


        public LayerRenderer() { }
        public LayerRenderer(Rect rect, ContentRef<Material> mainMat)
        {
            this.rect = rect;
            this.sharedMat = new List<ContentRef<Material>>() { mainMat };
        }

        protected List<Texture> RetrieveMainTex()
        {
            List<Texture> texList = new List<Texture>();

            foreach (var item in this.sharedMat)
            {
                if (item != null)
                {
                    texList.Add(item.Res.MainTexture.Res);
                }
            }

            return texList;
        }
        protected ColorRgba RetrieveMainColor()
        {
            if (this.sharedMat.ToList()[0].IsAvailable)
                return this.sharedMat.ToList()[0].Res.MainColor * this.colorTint;
            else
                return this.colorTint;
        }
        protected DrawTechnique RetrieveDrawTechnique()
        {
            if (this.sharedMat.ToList()[0].IsAvailable)
                return this.sharedMat.ToList()[0].Res.Technique.Res;
            else
                return null;
        }
        protected void PrepareVertices(ref Duality.VertexFormat.VertexC1P3T2[] vertices, IDrawDevice device, ColorRgba mainClr, Rect uvRect)
        {
            Vector3 posTemp = this.GameObj.Transform.Pos;
            float scaleTemp = 1.0f;
            device.PreprocessCoords(ref posTemp, ref scaleTemp);

            Vector2 xDot, yDot;
            MathF.GetTransformDotVec(this.GameObj.Transform.Angle, scaleTemp, out xDot, out yDot);

            Rect rectTemp = this.rect.Transform(this.GameObj.Transform.Scale, this.GameObj.Transform.Scale);
            Vector2 edge1 = rectTemp.TopLeft;
            Vector2 edge2 = rectTemp.BottomLeft;
            Vector2 edge3 = rectTemp.BottomRight;
            Vector2 edge4 = rectTemp.TopRight;

            MathF.TransformDotVec(ref edge1, ref xDot, ref yDot);
            MathF.TransformDotVec(ref edge2, ref xDot, ref yDot);
            MathF.TransformDotVec(ref edge3, ref xDot, ref yDot);
            MathF.TransformDotVec(ref edge4, ref xDot, ref yDot);

            if (vertices == null || vertices.Length != 4) vertices = new Duality.VertexFormat.VertexC1P3T2[4];

            vertices[0].Pos.X = posTemp.X + edge1.X;
            vertices[0].Pos.Y = posTemp.Y + edge1.Y;
            vertices[0].Pos.Z = posTemp.Z + this.VertexZOffset;
            vertices[0].TexCoord.X = uvRect.X;
            vertices[0].TexCoord.Y = uvRect.Y;
            vertices[0].Color = mainClr;

            vertices[1].Pos.X = posTemp.X + edge2.X;
            vertices[1].Pos.Y = posTemp.Y + edge2.Y;
            vertices[1].Pos.Z = posTemp.Z + this.VertexZOffset;
            vertices[1].TexCoord.X = uvRect.X;
            vertices[1].TexCoord.Y = uvRect.MaximumY;
            vertices[1].Color = mainClr;

            vertices[2].Pos.X = posTemp.X + edge3.X;
            vertices[2].Pos.Y = posTemp.Y + edge3.Y;
            vertices[2].Pos.Z = posTemp.Z + this.VertexZOffset;
            vertices[2].TexCoord.X = uvRect.MaximumX;
            vertices[2].TexCoord.Y = uvRect.MaximumY;
            vertices[2].Color = mainClr;

            vertices[3].Pos.X = posTemp.X + edge4.X;
            vertices[3].Pos.Y = posTemp.Y + edge4.Y;
            vertices[3].Pos.Z = posTemp.Z + this.VertexZOffset;
            vertices[3].TexCoord.X = uvRect.MaximumX;
            vertices[3].TexCoord.Y = uvRect.Y;
            vertices[3].Color = mainClr;
        }

        public override void Draw(IDrawDevice device)
        {
            ColorRgba mainClr = this.RetrieveMainColor();
            List<Texture> texList = this.RetrieveMainTex();

            for (int i = 0; i < texList.Count; i++)
            {
                Rect uvRect;
                if (texList[i] != null)
                {
                    if (this.rectMode == UVMode.WrapBoth)
                        uvRect = new Rect(texList[i].UVRatio.X * this.rect.W / texList[i].PixelWidth, texList[i].UVRatio.Y * this.rect.H / texList[i].PixelHeight);
                    else if (this.rectMode == UVMode.WrapHorizontal)
                        uvRect = new Rect(texList[i].UVRatio.X * this.rect.W / texList[i].PixelWidth, texList[i].UVRatio.Y);
                    else if (this.rectMode == UVMode.WrapVertical)
                        uvRect = new Rect(texList[i].UVRatio.X, texList[i].UVRatio.Y * this.rect.H / texList[i].PixelHeight);
                    else
                        uvRect = new Rect(texList[i].UVRatio.X, texList[i].UVRatio.Y);
                }
                else
                    uvRect = new Rect(1.0f, 1.0f);

                this.PrepareVertices(ref this.vertices, device, mainClr, uvRect);

                foreach (var item in this.sharedMat)
                {
                    device.AddVertices(item, VertexMode.Quads, this.vertices);
                }
            }
        }
        protected override void OnCopyTo(Component target, Duality.Cloning.CloneProvider provider)
        {
            base.OnCopyTo(target, provider);
            LayerRenderer t = target as LayerRenderer;
            t.sharedMat = this.sharedMat;
            t.rect = this.rect;
            t.colorTint = this.colorTint;
            t.rectMode = this.rectMode;
            t.offset = this.offset;
        }
    }
}
