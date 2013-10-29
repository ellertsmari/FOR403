/*
 * A set of static helper classes that provide easy runtime access to the games resources.
 * This file is auto-generated. Any changes made to it are lost as soon as Duality decides
 * to regenerate it.
 */
namespace GameRes
{
	public static class Data {
		public static Duality.ContentRef<Duality.Resources.Material> grass_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\grass.Material.res"); }}
		public static Duality.ContentRef<Duality.Resources.Pixmap> grass_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\grass.Pixmap.res"); }}
		public static Duality.ContentRef<Duality.Resources.Texture> grass_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\grass.Texture.res"); }}
		public static Duality.ContentRef<Duality.Resources.Material> Proto_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\Proto.Material.res"); }}
		public static Duality.ContentRef<Duality.Resources.Pixmap> Proto_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\Proto.Pixmap.res"); }}
		public static Duality.ContentRef<Duality.Resources.Texture> Proto_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\Proto.Texture.res"); }}
		public static Duality.ContentRef<Duality.Resources.Scene> Starting_Scene_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Starting Scene.Scene.res"); }}
		public static void LoadAll() {
			grass_Material.MakeAvailable();
			grass_Pixmap.MakeAvailable();
			grass_Texture.MakeAvailable();
			Proto_Material.MakeAvailable();
			Proto_Pixmap.MakeAvailable();
			Proto_Texture.MakeAvailable();
			Starting_Scene_Scene.MakeAvailable();
		}
	}

}
