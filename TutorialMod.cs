using Terraria.ModLoader;

namespace TutorialMod
{
	class TutorialMod : Mod
	{
		public TutorialMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
