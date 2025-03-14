using Content.Shared.Construction.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Bed.Components
{
    [RegisterComponent]
    public sealed partial class StasisBedComponent : Component
    {
        [DataField]
        public float BaseMultiplier = 10f;

        /// <summary>
        ///     What the metabolic update rate will be multiplied by (higher = slower metabolism)
        /// </summary>
        [ViewVariables(VVAccess.ReadOnly)] // Writing is is not supported. ApplyMetabolicMultiplierEvent needs to be refactored first
        [DataField]
        public float Multiplier = 10f;

        [DataField(customTypeSerializer: typeof(PrototypeIdSerializer<MachinePartPrototype>))]
        public string MachinePartMetabolismModifier = "Capacitor";
    }
}
