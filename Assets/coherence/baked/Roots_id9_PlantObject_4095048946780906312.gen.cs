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

	public struct Roots_id9_PlantObject_4095048946780906312 : ICoherenceComponentData
	{
		public bool enabled;

		public override string ToString()
		{
			return $"Roots_id9_PlantObject_4095048946780906312(enabled: {enabled})";
		}

		public uint GetComponentType() => Definition.InternalRoots_id9_PlantObject_4095048946780906312;

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
			var other = (Roots_id9_PlantObject_4095048946780906312)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				enabled = other.enabled;
			}
			mask >>= 1;
			return this;
		}

		public static void Serialize(Roots_id9_PlantObject_4095048946780906312 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.enabled);
			}
			mask >>= 1;
		}

		public static (Roots_id9_PlantObject_4095048946780906312, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Roots_id9_PlantObject_4095048946780906312();
	
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			return (val, mask, null);
		}
		public static (Roots_id9_PlantObject_4095048946780906312, uint, uint?) DeserializeArchetypeRoots_4e2bbc787b16997458ad85cd28b6e92d_Roots_id9_PlantObject_4095048946780906312_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Roots_id9_PlantObject_4095048946780906312();
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
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
			var last = lastSent as Roots_id9_PlantObject_4095048946780906312?;
	
		}
	}
}