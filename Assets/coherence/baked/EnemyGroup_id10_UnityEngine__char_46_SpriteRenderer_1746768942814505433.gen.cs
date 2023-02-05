// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433 : ICoherenceComponentData
	{
		public Vector2 size;

		public override string ToString()
		{
			return $"EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433(size: {size})";
		}

		public uint GetComponentType() => Definition.InternalEnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				size = other.size;
			}
			mask >>= 1;
			return this;
		}

		public static void Serialize(EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteVector2((data.size.ToCoreVector2()), FloatMeta.NoCompression());
			}
			mask >>= 1;
		}

		public static (EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433();
	
			if (bitStream.ReadMask())
			{
				val.size = (bitStream.ReadVector2(FloatMeta.NoCompression())).ToUnityVector2();
				mask |= 0b00000000000000000000000000000001;
			}
			return (val, mask, null);
		}
		public static (EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433, uint, uint?) DeserializeArchetypeEnemyGroup_dc358293f079f194ab5ec7d1d043818f_EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433();
			if (bitStream.ReadMask())
			{
				val.size = (bitStream.ReadVector2(FloatMeta.NoCompression())).ToUnityVector2();
				mask |= 0b00000000000000000000000000000001;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as EnemyGroup_id10_UnityEngine__char_46_SpriteRenderer_1746768942814505433?;
	
		}
	}
}