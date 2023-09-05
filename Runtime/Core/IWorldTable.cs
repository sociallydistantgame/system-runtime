﻿#nullable enable
using Core.Serialization;

namespace Core
{
	/// <summary>
	///		Represents a serializable table of world data objects.
	/// </summary>
	/// <typeparam name="TDataElement">The type of object contained within the data table</typeparam>
	public interface IWorldTable<TDataElement> : 
		ISerializableDataTable<TDataElement, WorldRevision, IWorldSerializer>
		where TDataElement : struct, IWorldData, IDataWithId
	{
		
	}
}