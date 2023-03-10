// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_200a876feaaaf244589706ac69e6dc16_77150216_d8f8_46d2_b52b_85fc82bdb71c : BoolBinding
	{
		private PlantObject CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlantObject)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_PlantObject_5444483082972953170";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override bool Value
		{
			get => (bool)(System.Boolean)(CastedUnityComponent.enabled);
			set => CastedUnityComponent.enabled = (System.Boolean)(value);
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_PlantObject_5444483082972953170)coherenceComponent;
			return update.enabled;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_PlantObject_5444483082972953170)coherenceComponent;
			update.enabled = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_PlantObject_5444483082972953170();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_c9102395_bf43_4d64_8afe_d8bd2c7f4bfd : Vector3Binding
	{
		private UnityEngine.BoxCollider CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.BoxCollider)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.size);
			set => CastedUnityComponent.size = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649)coherenceComponent;
			return update.size;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649)coherenceComponent;
			update.size = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_dd75721a_54ad_4840_aee1_41d56d4649b4 : IntBinding
	{
		private Health CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (Health)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_Health_1977754536731014931";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.maxHealth);
			set => CastedUnityComponent.maxHealth = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_Health_1977754536731014931)coherenceComponent;
			return update.maxHealth;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_Health_1977754536731014931)coherenceComponent;
			update.maxHealth = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_Health_1977754536731014931();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_7c0f4952_47f8_4d97_92fc_6d8960321366 : IntBinding
	{
		private Health CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (Health)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_Health_1977754536731014931";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.currentHealth);
			set => CastedUnityComponent.currentHealth = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_Health_1977754536731014931)coherenceComponent;
			return update.currentHealth;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_Health_1977754536731014931)coherenceComponent;
			update.currentHealth = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_Health_1977754536731014931();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_90c5c971_b8dc_4135_830e_96fca9dc7b58 : DeepPositionBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_UnityEngine__char_46_Transform_5188060417753529539";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localPosition);
			set => CastedUnityComponent.localPosition = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			return update.position;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			update.position = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_UnityEngine__char_46_Transform_5188060417753529539();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_572cbe20_ddbd_4255_aeca_dc2d7cd33839 : DeepRotationBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_UnityEngine__char_46_Transform_5188060417753529539";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override Quaternion Value
		{
			get => (Quaternion)(UnityEngine.Quaternion)(CastedUnityComponent.localRotation);
			set => CastedUnityComponent.localRotation = (UnityEngine.Quaternion)(value);
		}

		protected override Quaternion ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			return update.rotation;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			update.rotation = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_UnityEngine__char_46_Transform_5188060417753529539();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_e396e621_7d32_4882_aa58_dc98bf007208 : DeepScaleBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_UnityEngine__char_46_Transform_5188060417753529539";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localScale);
			set => CastedUnityComponent.localScale = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			return update.localScale;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_Transform_5188060417753529539)coherenceComponent;
			update.localScale = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_UnityEngine__char_46_Transform_5188060417753529539();
		}
	}

	public class Binding_200a876feaaaf244589706ac69e6dc16_29b5f0a0_d276_48f4_8582_f53d007a0646 : Vector2Binding
	{
		private UnityEngine.SpriteRenderer CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.SpriteRenderer)UnityComponent;
		}
		public override string CoherenceComponentName => "Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector2 Value
		{
			get => (Vector2)(UnityEngine.Vector2)(CastedUnityComponent.size);
			set => CastedUnityComponent.size = (UnityEngine.Vector2)(value);
		}

		protected override Vector2 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351)coherenceComponent;
			return update.size;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351)coherenceComponent;
			update.size = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'Spores' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncSpores_id8 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands
		private InputBuffer<Spores> inputBuffer;
		private Spores currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncSpores_id8>();
			coherenceInput = coherenceSync.Input;
			inputBuffer = new InputBuffer<Spores>(coherenceInput.InitialBufferSize, coherenceInput.InitialBufferDelay, coherenceInput.UseFixedSimulationFrames);
			if (coherenceSync.TryGetBindingByGuid("77150216-d8f8-46d2-b52b-85fc82bdb71c", "enabled", out Binding InternalSpores_id8_PlantObject_5444483082972953170_Spores_id8_PlantObject_5444483082972953170_enabled))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_77150216_d8f8_46d2_b52b_85fc82bdb71c();
				InternalSpores_id8_PlantObject_5444483082972953170_Spores_id8_PlantObject_5444483082972953170_enabled.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_PlantObject_5444483082972953170_Spores_id8_PlantObject_5444483082972953170_enabled)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlantObject).enabled");
			}
			if (coherenceSync.TryGetBindingByGuid("c9102395-bf43-4d64-8afe-d8bd2c7f4bfd", "size", out Binding InternalSpores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_size))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_c9102395_bf43_4d64_8afe_d8bd2c7f4bfd();
				InternalSpores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_size.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_Spores_id8_UnityEngine__char_46_BoxCollider_6244277848610630649_size)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.BoxCollider).size");
			}
			if (coherenceSync.TryGetBindingByGuid("dd75721a-54ad-4840-aee1-41d56d4649b4", "maxHealth", out Binding InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_maxHealth))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_dd75721a_54ad_4840_aee1_41d56d4649b4();
				InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_maxHealth.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_maxHealth)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (Health).maxHealth");
			}
			if (coherenceSync.TryGetBindingByGuid("7c0f4952-47f8-4d97-92fc-6d8960321366", "currentHealth", out Binding InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_currentHealth))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_7c0f4952_47f8_4d97_92fc_6d8960321366();
				InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_currentHealth.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_Health_1977754536731014931_Spores_id8_Health_1977754536731014931_currentHealth)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (Health).currentHealth");
			}
			if (coherenceSync.TryGetBindingByGuid("90c5c971-b8dc-4135-830e-96fca9dc7b58", "position", out Binding InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_position))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_90c5c971_b8dc_4135_830e_96fca9dc7b58();
				InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_position.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_position)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).position");
			}
			if (coherenceSync.TryGetBindingByGuid("572cbe20-ddbd-4255-aeca-dc2d7cd33839", "rotation", out Binding InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_rotation))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_572cbe20_ddbd_4255_aeca_dc2d7cd33839();
				InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_rotation.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_rotation)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).rotation");
			}
			if (coherenceSync.TryGetBindingByGuid("e396e621-7d32-4882-aa58-dc98bf007208", "localScale", out Binding InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_localScale))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_e396e621_7d32_4882_aa58_dc98bf007208();
				InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_localScale.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_UnityEngine__char_46_Transform_5188060417753529539_Spores_id8_UnityEngine__char_46_Transform_5188060417753529539_localScale)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).localScale");
			}
			if (coherenceSync.TryGetBindingByGuid("29b5f0a0-d276-48f4-8582-f53d007a0646", "size", out Binding InternalSpores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_size))
			{
				var clone = new Binding_200a876feaaaf244589706ac69e6dc16_29b5f0a0_d276_48f4_8582_f53d007a0646();
				InternalSpores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_size.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalSpores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_Spores_id8_UnityEngine__char_46_SpriteRenderer_5750176937178998351_size)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.SpriteRenderer).size");
			}
		}

		public override List<ICoherenceComponentData> CreateEntity()
		{
			if (coherenceSync.UsesLODsAtRuntime && (Archetypes.IndexForName.TryGetValue(coherenceSync.Archetype.ArchetypeName, out int archetypeIndex)))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
			else
			{
				logger.Warning($"Unable to find archetype {coherenceSync.Archetype.ArchetypeName} in dictionary. Please, bake manually (coherence > Bake)");
			}

			return null;
		}
		private void OnDestroy()
		{
			if (monoBridge != null)
			{
				monoBridge.OnLateFixedNetworkUpdate -= SendInputState;
			}
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
			sync.Input.internalSetButtonState = SetButtonState;
			sync.Input.internalSetButtonRangeState = SetButtonRangeState;
			sync.Input.internalSetAxisState = SetAxisState;
			sync.Input.internalSetStringState = SetStringState;
			sync.Input.internalGetButtonState = GetButtonState;
			sync.Input.internalGetButtonRangeState = GetButtonRangeState;
			sync.Input.internalGetAxisState = GetAxisState;
			sync.Input.internalGetStringState = GetStringState;
			sync.Input.internalRequestBuffer = () => inputBuffer;
			sync.Input.internalOnInputReceived += OnInput;
			sync.Input.internalRequestBuffer = () => inputBuffer;

			if (coherenceInput.UseFixedSimulationFrames)
			{
				sync.MonoBridge.OnLateFixedNetworkUpdate += SendInputState;
			}
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncSpores_id8] Unhandled command: {command.GetType()}.");
					break;
			}
		}

		private void SetButtonState(string name, bool value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		private void SetButtonRangeState(string name, float value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}
		}

		private void SetAxisState(string name, Vector2 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}
		}

		private void SetStringState(string name, string value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		public override void SendInputState()
		{
			if (!coherenceInput.IsProducer || !coherenceInput.IsReadyToProcessInputs || !coherenceInput.IsInputOwner)
			{
				return;
			}

			if (lastAddedFrame != currentSimulationFrame)
			{
				inputBuffer.AddInput(currentInput, currentSimulationFrame);
				lastAddedFrame = currentSimulationFrame;
			}

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out Spores input, out bool differs))
			{
				coherenceInput.DebugOnInputSent(frameToSend, input);
				client.SendInput(input, frameToSend, coherenceSync.EntityID);
			}
		}

		private bool ShouldPollCurrentInput(long frame)
		{
			return coherenceInput.IsProducer && coherenceInput.Delay == 0 && frame == currentSimulationFrame;
		}

		private bool GetButtonState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return false;
		}

		private float GetButtonRangeState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}

			return 0f;
		}

		private Vector2 GetAxisState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}

			return Vector2.zero;
		}

		private string GetStringState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return null;
		}

		private void OnInput(IEntityInput entityInput, long frame)
		{
			var input = (Spores)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
