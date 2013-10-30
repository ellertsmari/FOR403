/*
 * A set of static helper classes that provide easy runtime access to the games resources.
 * This file is auto-generated. Any changes made to it are lost as soon as Duality decides
 * to regenerate it.
 */
namespace GameRes
{
	public static class Data {
		public static class Levels {
			public static Duality.ContentRef<Duality.Resources.Scene> Starting_Scene_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Starting Scene.Scene.res"); }}
			public static void LoadAll() {
				Starting_Scene_Scene.MakeAvailable();
			}
		}
		public static class Sprites {
			public static Duality.ContentRef<Duality.Resources.Material> grass_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\grass.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> grass_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\grass.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> grass_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\grass.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> HeroSpritesnobg_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\HeroSpritesnobg.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> HeroSpritesnobg_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\HeroSpritesnobg.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> HeroSpritesnobg_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\HeroSpritesnobg.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> Proto_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\Proto.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> Proto_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\Proto.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> Proto_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\Proto.Texture.res"); }}
			public static void LoadAll() {
				grass_Material.MakeAvailable();
				grass_Pixmap.MakeAvailable();
				grass_Texture.MakeAvailable();
				HeroSpritesnobg_Material.MakeAvailable();
				HeroSpritesnobg_Pixmap.MakeAvailable();
				HeroSpritesnobg_Texture.MakeAvailable();
				Proto_Material.MakeAvailable();
				Proto_Pixmap.MakeAvailable();
				Proto_Texture.MakeAvailable();
			}
		}
		public static void LoadAll() {
			Levels.LoadAll();
			Sprites.LoadAll();
		}
	}

}
