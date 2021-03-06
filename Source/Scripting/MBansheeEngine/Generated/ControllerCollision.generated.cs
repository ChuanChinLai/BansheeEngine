using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Physics
	 *  @{
	 */

	/// <summary>Contains data about a collision of a character controller and another object.</summary>
	[StructLayout(LayoutKind.Sequential), SerializeObject]
	public partial struct ControllerCollision
	{
		/// <summary>Contact position.</summary>
		public Vector3 position;
		/// <summary>Contact normal.</summary>
		public Vector3 normal;
		/// <summary>Direction of motion after the hit.</summary>
		public Vector3 motionDir;
		/// <summary>Magnitude of motion after the hit.</summary>
		public float motionAmount;
	}

	/** @} */
}
