﻿#nullable enable
namespace Shell.Windowing
{
	public interface ITile : 
		IWindow, 
		ITabbedContent, 
		IWorkspaceDefinition
	{
		void Hide();
		void Show();
	}
}