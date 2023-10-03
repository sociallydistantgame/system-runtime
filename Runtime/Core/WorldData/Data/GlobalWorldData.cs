﻿#nullable enable
using System;
using Core.Serialization;

namespace Core.WorldData.Data
{
	public struct GlobalWorldData : 
		IWorldData,
		IGlobalState
	{
		private long dateData;
		private float timeScale;
		
		public DateTime Now
		{
			get => DateTime.FromBinary(dateData);
			set => dateData = value.ToBinary();
		}

		public float TimeScale
		{
			get => timeScale;
			set => timeScale = value;
		}
		
		/// <inheritdoc />
		public void Serialize(IWorldSerializer serializer)
		{
			SerializationUtility.SerializeAtRevision(ref dateData, serializer, WorldRevision.AddedWorldTime, default);
			SerializationUtility.SerializeAtRevision(ref timeScale, serializer, WorldRevision.AddedWorldTime, default);
		}
	}
}