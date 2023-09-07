﻿#nullable enable
using System;
using Shell.Common;
using UnityEngine;

namespace Shell.Windowing
{
	public interface IWindow : ICloseable
	{
		public event Action<IWindow>? WindowClosed; 

		IWorkspaceDefinition Workspace { get; }
		string Title { get; set; }
		CompositeIcon Icon { get; set; }
		WindowState WindowState { get; set; }
		
		bool EnableCloseButton { get; set; }
		bool EnableMaximizeButton { get; set; }
		bool EnableMinimizeButton { get; set; }
		
		bool IsActive { get; }
		
		Vector2 MinimumSize { get; set; }
		Vector2 Position { get; set; }

		void ToggleMaximize();
		void Restore();
		void Minimize();
		void ForceClose();
		void SetWorkspace(IWorkspaceDefinition workspace);
	}
}