﻿namespace Shell.Windowing
{
	public interface IContent
	{
		IContentPanel? Parent { get; }
		
		void OnParentChanged(IContentPanel? parent);
	}
}