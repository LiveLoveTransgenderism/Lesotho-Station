// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.FixedPoint;

namespace Content.Goobstation.Shared.Blob.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class BlobResourceComponent : Component
{
    [DataField]
    public FixedPoint2 PointsPerPulsed = 3;
}
