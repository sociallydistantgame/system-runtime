﻿#nullable enable
using System;
using Shell.Common;

namespace Shell.Windowing
{
	public interface IWindow :  ICloseable
	{
		public event Action<IWindow>? WindowClosed; 

		IWorkspaceDefinition? Workspace { get; set; }
		CompositeIcon Icon { get; set; }
		
		bool IsActive { get; }

		IWorkspaceDefinition CreateWindowOverlay();
	}
}