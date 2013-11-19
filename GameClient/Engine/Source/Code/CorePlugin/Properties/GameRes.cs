/*
 * A set of static helper classes that provide easy runtime access to the games resources.
 * This file is auto-generated. Any changes made to it are lost as soon as Duality decides
 * to regenerate it.
 */
namespace GameRes
{
	public static class Data {
		public static class Levels {
			public static Duality.ContentRef<Duality.Resources.Scene> Combat_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Combat.Scene.res"); }}
			public static Duality.ContentRef<Duality.Resources.Scene> Level1_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Level1.Scene.res"); }}
			public static Duality.ContentRef<Duality.Resources.Scene> Options_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Options.Scene.res"); }}
			public static void LoadAll() {
				Combat_Scene.MakeAvailable();
				Level1_Scene.MakeAvailable();
				Options_Scene.MakeAvailable();
			}
		}
		public static class MenuTextures {
			public static Duality.ContentRef<Duality.Resources.Material> PlayerMenu_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\MenuTextures\PlayerMenu.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> PlayerMenu_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\MenuTextures\PlayerMenu.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> PlayerMenu_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\MenuTextures\PlayerMenu.Texture.res"); }}
			public static void LoadAll() {
				PlayerMenu_Material.MakeAvailable();
				PlayerMenu_Pixmap.MakeAvailable();
				PlayerMenu_Texture.MakeAvailable();
			}
		}
		public static class Prefabs {
			public static Duality.ContentRef<Duality.Resources.Prefab> Tile_Prefab { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Prefab>(@"Data\Prefabs\Tile.Prefab.res"); }}
			public static void LoadAll() {
				Tile_Prefab.MakeAvailable();
			}
		}
		public static class Sprites {
			public static Duality.ContentRef<Duality.Resources.Material> Desert_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\Desert.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> Desert_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\Desert.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> Desert_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\Desert.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> HeroSpritesnobgFixed_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\HeroSpritesnobgFixed.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> HeroSpritesnobgFixed_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\HeroSpritesnobgFixed.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> HeroSpritesnobgFixed_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\HeroSpritesnobgFixed.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> TilesetFixed_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\TilesetFixed.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> TilesetFixed_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\TilesetFixed.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> TilesetFixed_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\TilesetFixed.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> Wolf_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\Wolf.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> Wolf_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\Wolf.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> Wolf_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\Wolf.Texture.res"); }}
			public static void LoadAll() {
				Desert_Material.MakeAvailable();
				Desert_Pixmap.MakeAvailable();
				Desert_Texture.MakeAvailable();
				HeroSpritesnobgFixed_Material.MakeAvailable();
				HeroSpritesnobgFixed_Pixmap.MakeAvailable();
				HeroSpritesnobgFixed_Texture.MakeAvailable();
				TilesetFixed_Material.MakeAvailable();
				TilesetFixed_Pixmap.MakeAvailable();
				TilesetFixed_Texture.MakeAvailable();
				Wolf_Material.MakeAvailable();
				Wolf_Pixmap.MakeAvailable();
				Wolf_Texture.MakeAvailable();
			}
		}
		public static void LoadAll() {
			Levels.LoadAll();
			MenuTextures.LoadAll();
			Prefabs.LoadAll();
			Sprites.LoadAll();
		}
	}

}
