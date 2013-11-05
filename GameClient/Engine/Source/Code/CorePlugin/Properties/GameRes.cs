/*
 * A set of static helper classes that provide easy runtime access to the games resources.
 * This file is auto-generated. Any changes made to it are lost as soon as Duality decides
 * to regenerate it.
 */
namespace GameRes
{
	public static class Data {
		public static class Enemies {
			public static void LoadAll() {
			}
		}
		public static class Levels {
			public static Duality.ContentRef<Duality.Resources.Scene> Combat_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Combat.Scene.res"); }}
			public static Duality.ContentRef<Duality.Resources.Scene> Menu_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Menu.Scene.res"); }}
			public static Duality.ContentRef<Duality.Resources.Scene> Options_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\Options.Scene.res"); }}
			public static Duality.ContentRef<Duality.Resources.Scene> StartingPlace_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Levels\StartingPlace.Scene.res"); }}
			public static void LoadAll() {
				Combat_Scene.MakeAvailable();
				Menu_Scene.MakeAvailable();
				Options_Scene.MakeAvailable();
				StartingPlace_Scene.MakeAvailable();
			}
		}
		public static class Sprites {
			public static Duality.ContentRef<Duality.Resources.Material> HeroSpritesnobgFixed_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\HeroSpritesnobgFixed.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> HeroSpritesnobgFixed_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\HeroSpritesnobgFixed.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> HeroSpritesnobgFixed_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\HeroSpritesnobgFixed.Texture.res"); }}
			public static Duality.ContentRef<Duality.Resources.Material> TilesetFixed_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Sprites\TilesetFixed.Material.res"); }}
			public static Duality.ContentRef<Duality.Resources.Pixmap> TilesetFixed_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Sprites\TilesetFixed.Pixmap.res"); }}
			public static Duality.ContentRef<Duality.Resources.Texture> TilesetFixed_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Sprites\TilesetFixed.Texture.res"); }}
			public static void LoadAll() {
				HeroSpritesnobgFixed_Material.MakeAvailable();
				HeroSpritesnobgFixed_Pixmap.MakeAvailable();
				HeroSpritesnobgFixed_Texture.MakeAvailable();
				TilesetFixed_Material.MakeAvailable();
				TilesetFixed_Pixmap.MakeAvailable();
				TilesetFixed_Texture.MakeAvailable();
			}
		}
		public static Duality.ContentRef<Duality.Resources.Prefab> Player_Prefab { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Prefab>(@"Data\Player.Prefab.res"); }}
		public static Duality.ContentRef<Duality.Resources.Prefab> Tile_Prefab { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Prefab>(@"Data\Tile.Prefab.res"); }}
		public static void LoadAll() {
			Enemies.LoadAll();
			Levels.LoadAll();
			Sprites.LoadAll();
			Player_Prefab.MakeAvailable();
			Tile_Prefab.MakeAvailable();
		}
	}

}
