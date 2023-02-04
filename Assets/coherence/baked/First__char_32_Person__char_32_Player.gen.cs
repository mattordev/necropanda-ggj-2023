// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.Brook;
	using UnityEngine;

	public struct First__char_32_Person__char_32_Player : IEntityInput
	{
		public uint GetComponentType() => Definition.InternalFirst__char_32_Person__char_32_Player;

		private readonly bool isRemoteInput;

		public First__char_32_Person__char_32_Player
		(
			bool isRemoteInput
		)
		{
			this.isRemoteInput = isRemoteInput;
		}

		public override string ToString()
		{
			return isRemoteInput
				? $""
				: $"";
		}

		public static void Serialize(First__char_32_Person__char_32_Player inputData, IOutProtocolBitStream bitStream)
		{
		}

		public static First__char_32_Person__char_32_Player Deserialize(IInProtocolBitStream bitStream)
		{

			return new First__char_32_Person__char_32_Player
			(
				true
			);
		}
	}
}
