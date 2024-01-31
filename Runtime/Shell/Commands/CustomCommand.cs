﻿#nullable enable

using System.Threading.Tasks;
using OS.Devices;

namespace Shell.Commands
{
	public abstract class CustomCommand
	{
		public string Name { get; protected set; } = string.Empty;
		public bool RequiresAdmin { get; protected set; }
		public bool PlayerOnly { get; protected set; }

		public abstract Task<int> Run(string[] args, ISystemProcess process, ConsoleWrapper console);
	}
}