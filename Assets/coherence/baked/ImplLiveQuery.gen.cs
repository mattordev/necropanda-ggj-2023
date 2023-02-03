// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Toolkit
{
	using UnityEngine;
	using global::Coherence.Generated;
	using Coherence.Entity;

	public class CoherenceLiveQueryImpl : MonoBehaviour
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void OnRuntimeMethodLoad()
		{
			Impl.CreateLiveQuery = CreateLiveQuery;
			Impl.UpdateLiveQuery = UpdateLiveQuery;
		}

		private static SerializeEntityID CreateLiveQuery(IClient client, float radius, Vector3 pos) {
			var components = new ICoherenceComponentData[] {
				new WorldPosition
				{
					value = pos
				},
				new WorldPositionQuery
				{
					position = pos,
					radius = radius
				}
			};

			return client.CreateEntity(components, false);
		}

		private static void UpdateLiveQuery(IClient client, SerializeEntityID liveQuery, float radius, Vector3 pos)
		{
			var newWorldPosition = new WorldPosition
			{
				value = pos
			};

			var newWorldPositionQuery = new WorldPositionQuery
			{
				position = pos,
				radius = radius,
			};

			var components = new ICoherenceComponentData[]
			{
				newWorldPosition,
				newWorldPositionQuery,
			};

			var masks = new uint[]
			{
				0xff,
				0xff,
			};

			client.UpdateComponents(liveQuery, components, masks);
		}
	}
}
