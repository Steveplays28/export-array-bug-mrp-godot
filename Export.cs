using Godot;

namespace ExportArrayBugMRPGodot;

public partial class Export : Node
{
	[Export]
	public PackedScene[] Scenes;
}
