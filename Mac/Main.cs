using System;

using AppKit;

namespace HelloSpriteKitGame.Mac
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			NSApplication.Main(args);
		}
	}
}
